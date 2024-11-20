using HW9_PersonalWebsite.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HW9_PersonalWebsite.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
        {
            return View(); // Corresponds to About Page
        }

        public IActionResult Projects()
        {
            return View(); // Corresponds to Projects Page
        }

        public IActionResult Skills()
        {
            return View(); // Corresponds to Skills Page
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

