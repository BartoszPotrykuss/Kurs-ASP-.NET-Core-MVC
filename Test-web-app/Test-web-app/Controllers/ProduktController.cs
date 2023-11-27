using Microsoft.AspNetCore.Mvc;
using Test_web_app.Models;
using Test_web_app.Services.Interfaces;

namespace Test_web_app.Controllers
{
    public class ProduktController : Controller
    {
        private readonly IWarehouseService _warehouseService;

        public ProduktController(IWarehouseService warehouseService)
        {
            _warehouseService = warehouseService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Product()
        {
            var product = new Product
            {
                Id = 1,
                Category = "samochod",
                Description = "To jest super samochod",
                Name = "BMW M5"
            };

            return View(product);
        }

        public IActionResult List()
        {
            //var productsList = new List<Product>
            //{
            //        new Product
            //        {
            //            Id = 1,
            //            Category = "samochod",
            //            Description = "To jest super samochod",
            //            Name = "BMW M5"
            //        },

            //        new Product
            //        {
            //            Id = 2,
            //            Category = "napoj",
            //            Description = "To jest opis napoju",
            //            Name = "PEPSI"
            //        },

            //        new Product
            //        {
            //            Id = 3,
            //            Category = "roslina",
            //            Description = "To jest extra roslina",
            //            Name = "Storczyk"
            //        }
            //};

            var productsList = _warehouseService.GetAll();

                return View(productsList);
        }

        public IActionResult Data() 
        {
            ViewBag.Name = "Jarek";
            ViewData["Surname"] = "Kowalski";
            TempData["SecondName"] = "Piotr";

            return View();
        }
    }
}
