using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AppShopOnline.Areas.Identity.Data;
using AppShopOnline.Models;

namespace AppShopOnline.Areas.Admins.Controllers
{
    [Area("Admins")]
    public class ProductController : Controller
    {
        private readonly AppShopOnlineDbContext _context;

        public ProductController(AppShopOnlineDbContext context)
        {
            _context = context;
        }

        // GET: Admins/Products
        public async Task<IActionResult> Index()
        {
            var appShopOnlineDbContext = _context.Products.Include(p => p.Category).Include(p => p.Color).Include(p => p.Siez);
            return View(await appShopOnlineDbContext.ToListAsync());
        }

        // GET: Admins/Products/Details/5
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

        // GET: Admins/Products/Create
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name");
            ViewData["ColorId"] = new SelectList(_context.Set<Color>(), "ColorId", "ColorId");
            ViewData["SizeId"] = new SelectList(_context.Sizes, "SizeId", "SizeId");
            return View();
        }

        // POST: Admins/Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CategoryId,Code,Name,Description,Content,Image,MetaTitle,MetaKeyword,MetaDescription,Slug,PriceOld,PriceNew,DisCount,Size,Views,Likes,Star,Home,Hot,CreatedDate,UpdatedDate,AdminCreated,AdminUpdated,Status,Isdelete,SizeId,ColorId,IsArrived,Istrandy")] Product product)
        {
            if (ModelState.IsValid)
            {
                var files = HttpContext.Request.Form.Files;
                if (files.Count() > 0 && files[0].Length > 0)
                {
                    var file = files[0];

                    var FileName = file.FileName;
                    // upload ảnh vào thư mục wwwroot\\imgView\\product
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\imgView\\product", FileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        file.CopyTo(stream);

                        product.Image = "/imgView/product/" + FileName; // gán tên ảnh cho thuộc tinh Image
                    }
                }
                //update ngày
                product.CreatedDate = DateTime.Now;


                //Thêm mới
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", product.CategoryId);
            ViewData["ColorId"] = new SelectList(_context.Set<Color>(), "ColorId", "ColorId", product.ColorId);
            ViewData["SizeId"] = new SelectList(_context.Sizes, "SizeId", "SizeId", product.SizeId);
            return View(product);
        }

        // GET: Admins/Products/Edit/5
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
            ViewData["ColorId"] = new SelectList(_context.Set<Color>(), "ColorId", "ColorId", product.ColorId);
            ViewData["SizeId"] = new SelectList(_context.Sizes, "SizeId", "SizeId", product.SizeId);
            return View(product);
        }

        // POST: Admins/Products/Edit/5
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
                    var files = HttpContext.Request.Form.Files;
                    if (files.Count() > 0 && files[0].Length > 0)

                    {
                        var file = files[0];

                        var FileName = file.FileName;
                        // upload ảnh vào thư mục wwwroot\\imgView\\product
                        var path = Path.Combine(Directory.GetCurrentDirectory(),
                        "wwwroot\\imgView\\product", FileName);
                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            file.CopyTo(stream);
                            product.Image = "/imgView/product/" + FileName; // gán tên ảnh cho thuộc tinh Image
                        }
                    }
                    //update ngày
                    product.UpdatedDate = DateTime.Now;

                    // Sửa
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
            ViewData["ColorId"] = new SelectList(_context.Set<Color>(), "ColorId", "ColorId", product.ColorId);
            ViewData["SizeId"] = new SelectList(_context.Sizes, "SizeId", "SizeId", product.SizeId);
            return View(product);
        }

        // GET: Admins/Products/Delete/5
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

        // POST: Admins/Products/Delete/5
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
