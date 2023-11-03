using AppShopOnline.Areas.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AppShopOnline.Components
{
    public class Navbar:ViewComponent
    {
        private readonly AppShopOnlineDbContext _context;

        public Navbar(AppShopOnlineDbContext context)
        {
            _context = context;

        }
        public IViewComponentResult Invoke()
        {
            return View(_context.Categories.ToList());
        }


    }
}
