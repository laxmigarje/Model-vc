using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Model_vc.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Model_vc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<string> colorList = new List<string>()
            {
                "Red","Green","Blue","Black","White","Purple","Pink"

            };
            ViewData["message"] = "This is my first mvc page";
            ViewData["Experience"] = "I have 2 years of experience";
            ViewData["Year"] = 2022;

            ViewData["list"] = colorList;
            ViewBag.ColorList = colorList;
            return View();
        }
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }



        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
