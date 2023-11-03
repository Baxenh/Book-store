using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AppShopOnline.Areas.Identity.Data;
using AppShopOnline.Models;
using X.PagedList.Mvc.Core;
using AppShopOnline.Models.ViewModels;
using Microsoft.CodeAnalysis.Elfie.Model.Structures;
using Range = System.Range;
using System;

namespace AppShopOnline.Controllers
{
    public class ProductsController : Controller
    {
        private readonly AppShopOnlineDbContext _context;
        public int PageSize = 9;
        public ProductsController(AppShopOnlineDbContext context)
        {
            _context = context;
        }

        // GET: Products
        public async Task<IActionResult> Index(int page = 1)
        {
            return View(
                new ProductListViewModel
                {
                    Products= _context.Products.Skip((page-1)*PageSize).Take(PageSize),
                    PagingInfo=new PagingInfo
                    {
                        ItemsPerpage=PageSize,
                        CurrentPage=page,
                        TotalItems=_context.Products.Count()

                    }
                });

            //var appShopOnlineDbContext = _context.Products.Include(p => p.Category).Include(p => p.Color).Include(p => p.Siez)
            //    .Skip((PageSize - 1) * PageSize)
            //    .Take(PageSize);
           // return View(await appShopOnlineDbContext.ToListAsync());
        }

        // thêm [HttpPost]
        [HttpPost]
        public async Task<IActionResult> Search(string keywords,int page = 1)
        {
            return View("Index",
                new ProductListViewModel
                {
                    Products = _context.Products.Where(p => p.Name.Contains(keywords)).Skip((page - 1) * PageSize).Take(PageSize),
                    PagingInfo = new PagingInfo
                    {
                        ItemsPerpage = PageSize,
                        CurrentPage = page,
                        TotalItems = _context.Products.Count()

                    }
                });
          
        }
        public async Task<IActionResult> ProducByCart(int categoryId)
        {
            var appShopOnlineDbContext = _context.Products.Where(p=>p.CategoryId==categoryId).Include(p => p.Category).Include(p => p.Color).Include(p => p.Siez)
                .Skip((PageSize-1)*PageSize)
                .Take(PageSize);
            return View("Index",await appShopOnlineDbContext.ToListAsync());
        }

        /// <summary>
        ///  Hàm chọn price, color, size
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// 
        public class PriceRange
        {
            public int min { get; set; }
            public int max { get; set; }
        }
       
        [HttpPost]        
         public IActionResult GetFilteredProducts([FromBody] FilterData filter)
        {
            var filteredProducts = _context.Products.ToList();
            if(filter.PriceRanges!=null && filter.PriceRanges.Count>0 && !filter.PriceRanges.Contains("all"))
            {
                List<PriceRange> priceRanges = new List<PriceRange>();
                foreach(var range in filter.PriceRanges)
                {
                    var value = range.Split("_").ToArray();
                    PriceRange priceRange = new PriceRange();
                    priceRange.min = Int16.Parse(value[0]);
                    priceRange.max = Int16.Parse(value[1]);
                    priceRanges.Add(priceRange);
                }
                filteredProducts = filteredProducts.Where(p => priceRanges.Any(r =>p.PriceNew >= r.min && p.PriceNew <= r.max)).ToList();

            }
            if (filter.Colors != null && filter.Colors.Count > 0 && !filter.Colors.Contains("all"))
            {
                filteredProducts = filteredProducts.Where(p => filter.Colors.Contains(p.Siez.SizeName)).ToList();
            }
            //if (filter.Sizes != null && filter.Sizes.Count > 0 && !filter.Sizes.Contains("all")
            //{
            //    filteredProducts = filteredProducts.Where(p => filter.Sizes.Contains(p.Siez.SizeName)).ToList();

            //}    
            return PartialView("_ReturnProducts",filteredProducts);
        }
     


        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Products == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.Category)
                .Include(p => p.Color)
                .Include(p => p.Siez)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name");
            ViewData["ColorId"] = new SelectList(_context.Color, "ColorId", "ColorId");
            ViewData["SizeId"] = new SelectList(_context.Sizes, "SizeId", "SizeId");
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CategoryId,Code,Name,Description,Content,Image,MetaTitle,MetaKeyword,MetaDescription,Slug,PriceOld,PriceNew,DisCount,Size,Views,Likes,Star,Home,Hot,CreatedDate,UpdatedDate,AdminCreated,AdminUpdated,Status,Isdelete,SizeId,ColorId,IsArrived,Istrandy")] Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", product.CategoryId);
            ViewData["ColorId"] = new SelectList(_context.Color, "ColorId", "ColorId", product.ColorId);
            ViewData["SizeId"] = new SelectList(_context.Sizes, "SizeId", "SizeId", product.SizeId);
            return View(product);
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Products == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", product.CategoryId);
            ViewData["ColorId"] = new SelectList(_context.Color, "ColorId", "ColorId", product.ColorId);
            ViewData["SizeId"] = new SelectList(_context.Sizes, "SizeId", "SizeId", product.SizeId);
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CategoryId,Code,Name,Description,Content,Image,MetaTitle,MetaKeyword,MetaDescription,Slug,PriceOld,PriceNew,DisCount,Size,Views,Likes,Star,Home,Hot,CreatedDate,UpdatedDate,AdminCreated,AdminUpdated,Status,Isdelete,SizeId,ColorId,IsArrived,Istrandy")] Product product)
        {
            if (id != product.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", product.CategoryId);
            ViewData["ColorId"] = new SelectList(_context.Color, "ColorId", "ColorId", product.ColorId);
            ViewData["SizeId"] = new SelectList(_context.Sizes, "SizeId", "SizeId", product.SizeId);
            return View(product);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Products == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.Category)
                .Include(p => p.Color)
                .Include(p => p.Siez)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Products == null)
            {
                return Problem("Entity set 'AppShopOnlineDbContext.Products'  is null.");
            }
            var product = await _context.Products.FindAsync(id);
            if (product != null)
            {
                _context.Products.Remove(product);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
          return _context.Products.Any(e => e.Id == id);
        }
    }
}
