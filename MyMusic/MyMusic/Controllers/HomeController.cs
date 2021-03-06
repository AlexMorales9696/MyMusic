using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using MyMusic.Repository;
using MyMusic1.Models;

namespace MyMusic.Controllers
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
        public IActionResult IndexBrani()
        {

            ritorno Visualizza(_dbReader.GetAllBrani ());
        }
        public IActionResult IndexAlbum()
        {
            restituisce Visualizza(_dbReader.GetAllAlbum ());

        }
        public IActionResult IndexBand()
        {
            ritorno Visualizza(_dbReader.GetAllBand ());
        }

      
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}