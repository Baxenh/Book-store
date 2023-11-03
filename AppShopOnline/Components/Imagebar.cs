using AppShopOnline.Areas.Identity.Data;
using Microsoft.AspNetCore.Mvc;

namespace AppShopOnline.Components
{
    public class Imagebar:ViewComponent
    {
        private readonly AppShopOnlineDbContext _context;

        public Imagebar(AppShopOnlineDbContext context)
        {
            _context = context;

        }
        public IViewComponentResult Invoke()
        {
            return View("Index",_context.Categories.ToList());
        }

    }
}
