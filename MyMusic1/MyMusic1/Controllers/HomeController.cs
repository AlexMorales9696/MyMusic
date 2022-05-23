using Microsoft.AspNetCore.Mvc;
using MyMusic1.DBManager;
using MyMusic1.Models;
using System.Diagnostics;

namespace MyMusic1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private DBManagerReader dBManager;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            dBManager = new DBManagerReader();
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(dBManager.GetAllArtista());
        }
        public IActionResult IndexBrani()
        {

            return View(dBManager.GetAllBrani());
        }
        public IActionResult IndexAlbum()
        {
            return View(dBManager.GetAllAlbum());

        }
        public IActionResult IndexBand()
        {
            return View(dBManager.GetAllBand());
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