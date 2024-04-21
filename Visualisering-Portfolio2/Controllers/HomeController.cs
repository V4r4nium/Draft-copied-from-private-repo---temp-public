using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Visualisering_Portfolio2.Models;

namespace Visualisering_Portfolio2.Controllers
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
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult Billetter()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }
        public IActionResult Explore()
        {
            return View();
        }
        public IActionResult Merch()
        {
            return View();
        }
        public IActionResult Mobile()
        {
            return View();
        }
        public IActionResult PC()
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
