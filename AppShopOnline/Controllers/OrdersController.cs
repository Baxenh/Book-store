﻿using Microsoft.AspNetCore.Mvc;

namespace AppShopOnline.Controllers
{
    public class OrdersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
