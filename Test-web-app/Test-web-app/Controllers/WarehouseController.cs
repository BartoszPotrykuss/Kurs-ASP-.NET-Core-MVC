using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Test_web_app.Models;
using Test_web_app.Services.Interfaces;

namespace Test_web_app.Controllers
{
    [Authorize]
    public class WarehouseController : Controller
    {
        private readonly IWarehouseService _warehouseService;

        public WarehouseController(IWarehouseService warehouseService)
        {
            _warehouseService = warehouseService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Add(Product body)
        {
            if (!ModelState.IsValid)
            {
                return View(body);
            }



            //logika do zapisu produktu
            var id = _warehouseService.Save(body);

            ViewData["ProductId"] = id;
            TempData["ProductId"] = id;

            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult List()
        {
            var products = _warehouseService.GetAll();
            return View(products);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var product = _warehouseService.Get(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            _warehouseService.Delete(id);
            return RedirectToAction("List");
        }
    }
}
