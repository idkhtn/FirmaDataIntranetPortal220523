using Firma.PortalWWW.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Firma.PortalWWW.Controllers
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
        public IActionResult Contact()
        {
            return View();//widok będzienazywał się tak samo jak funkcja czyli kontakt
        }

        public IActionResult About()
        {
            return View();//widok będzienazywał się tak samo jak funkcja czyli kontakt
        }
        public IActionResult Blog()
        {
            return View();//widok będzienazywał się tak samo jak funkcja czyli kontakt
        }
        public IActionResult Cart()
        {
            return View();//widok będzienazywał się tak samo jak funkcja czyli kontakt
        }
        public IActionResult Shop()
        {
            return View();//widok będzienazywał się tak samo jak funkcja czyli kontakt
        }

        public IActionResult Home()
        {
            return View();//widok będzienazywał się tak samo jak funkcja czyli kontakt
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}