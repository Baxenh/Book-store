
using AppShopOnline.Areas.Identity.Data;
using AppShopOnline.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;

namespace Lesson09_Login.Controllers
{
    public class CartController : Controller
    {
        private readonly AppShopOnlineDbContext _context;
        private List<Cart> carts = new List<Cart>();
        public CartController(AppShopOnlineDbContext context)
        {
            _context = context;
        }

        


        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var cartInSession = HttpContext.Session.GetString("My-Cart");
            if (cartInSession != null)
            {
                // nếu cartInSession không null thì gán dữ liệu cho biến carts
                // Chuyển san dữ liệu json
                carts = JsonConvert.DeserializeObject <List<Cart>>(cartInSession);
            }
            base.OnActionExecuting(context);
        }

        public IActionResult Index()
        {

            float total = 0;
            foreach (var item in carts)
            {
                total += item.Quantity * item.Price;
            }
            ViewBag.total = total;
            return View(carts);
        }
       

        /// <summary>
        /// Code logic cho chức năng thêm sản phẩm vào giỏ hàng
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult Add(int id)
        {
            if (carts.Any(c => c.Id == id)) // nếu sản phẩm này đã có trong giỏ hàng
            {

                carts.Where(c => c.Id == id).First().Quantity += 1; // Tăng số  lượng
            }
            else // Nếu sản phẩm chưa có trong giỏ hàng, thêm sản phẩm vào giỏ hàng
            {
                var p = _context.Products.Find(id); // tìm sản phẩm cần mua trong bảng sản phẩm
                // tạo mới một sản phẩm để thêm vào giỏ hàng
                var item = new Cart()
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = (float)p.PriceNew,
                    Quantity = 1,
                    Image = p.Image,
                    Total = (float)p.PriceNew

                };
                // thêm sản phẩm vào giỏ hàng
                carts.Add(item);
            }
            // lưu carts vào session, cần phải chuyển sang dữ liệu json
            HttpContext.Session.SetString("My-Cart",
            JsonConvert.SerializeObject(carts));
            return RedirectToAction("Index");
        }


        /// <summary>
        /// Code logic cho chức năng xóa sản phẩm trong giỏ hàng
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult Remove(int id)
        {
            if (carts.Any(c => c.Id == id))
            {
                // tìm sản phẩm trong giỏ hàng
                var item = carts.Where(c => c.Id == id).First();
                //thực hiện xóa
                carts.Remove(item);
                // lưu carts vào session, cần phải chuyển sang dữ liệu json
                HttpContext.Session.SetString("My-Cart",JsonConvert.SerializeObject(carts));
            }
            return RedirectToAction("Index");
        }


        /// <summary>
        /// Code logic cho chức năng cập nhật dữ liệu trong giỏ hàng
        /// </summary>
        /// <param name="id"></param>
        /// <param name="quantity"></param>
        /// <returns></returns>
        public IActionResult Update(int id, int quantity)
        {
            if (carts.Any(c => c.Id == id))
            {
                // tìm sản phẩm trong giỏ hàng và cập nhật lại số lượng mới
                carts.Where(c => c.Id == id).First().Quantity = quantity;
                // lưu carts vào session, cần phải chuyển sang dữ liệu json
                HttpContext.Session.SetString("My-Cart",JsonConvert.SerializeObject(carts));
            }
            return RedirectToAction("Index");
        }


        /// <summary>
        /// Code logic cho chức năng xóa hết sản phẩm trong giỏ hàng
        /// </summary>
        /// <returns></returns>
        public IActionResult Clear()
        {
            HttpContext.Session.Remove("My-Cart");
            return RedirectToAction("Index");
        }
    }
}
