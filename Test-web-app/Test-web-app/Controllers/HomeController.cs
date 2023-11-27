using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Test_web_app.Models;

namespace Test_web_app.Controllers
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

        [Route("polityka-prywatnosci")]
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Redirect()
        {
            return RedirectToAction("Privacy");
        }

        [Route("testowy-route/{name}")]
        public IActionResult Produkt(string name)
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