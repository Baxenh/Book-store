using Microsoft.AspNetCore.Mvc;

namespace WebAppShopElectro.Areas.Admins.Controllers
{
    [Area("Admins")]
    //[HttpPost]
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
