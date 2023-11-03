using AppShopOnline.Areas.Identity.Data;
using Microsoft.AspNetCore.Mvc;

namespace AppShopOnline.Components
{
    public class Arrived:ViewComponent
    {

        private readonly AppShopOnlineDbContext _context;

        public Arrived(AppShopOnlineDbContext context)
        {
            _context = context;

        }
        public IViewComponentResult Invoke()
        {
            return View(_context.Products.Where(p => p.IsArrived == true).ToList());
        }
    }
}
