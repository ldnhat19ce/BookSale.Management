﻿using Microsoft.AspNetCore.Mvc;

namespace BookSale.Management.UI.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
