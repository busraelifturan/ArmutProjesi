using ArmutProjesi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ArmutProjesi.Controllers
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

        public IActionResult Hakkımızda()
        {
            return View();
        }


        public IActionResult Yardım()
        {
            return View();
        }

        public IActionResult Kategoriler()
        {
            return View();
        }
        public IActionResult Temizlik()
        {
            return View();
        }
        public IActionResult Tadilat()
        {
            return View();
        }

        public IActionResult ÖzelDers()
        {
            return View();
        }

        public IActionResult Saglık()
        {
            return View();
        }

        public IActionResult Diger()
        {
            return View();
        }

        public IActionResult İletisim()
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

        public IActionResult Teklif()
        {
            return View();
        }

    }
}