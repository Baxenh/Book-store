using AppShopOnline.Areas.Identity.Data;
using Microsoft.AspNetCore.Mvc;

namespace AppShopOnline.Components
{
    public class Trandy:ViewComponent
    {

        private readonly AppShopOnlineDbContext _context;

        public Trandy(AppShopOnlineDbContext context)
        {
            _context = context;

        }
        public IViewComponentResult Invoke()
        {
            return View(_context.Products.Where(p =>p.Istrandy==true).ToList());
        }
    }
}
