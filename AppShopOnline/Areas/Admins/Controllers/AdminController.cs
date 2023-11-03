using Microsoft.AspNetCore.Mvc;

namespace AppShopOnline.Areas.Admins.Controllers
{
    [Area("Admins")]
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
