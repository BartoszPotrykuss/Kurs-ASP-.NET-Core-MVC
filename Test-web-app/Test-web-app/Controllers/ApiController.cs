using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Test_web_app.Services.Interfaces;

namespace Test_web_app.Controllers
{
    [Authorize]
    public class ApiController : Controller
    {
        private readonly IApiService _apiService;

        public ApiController(IApiService apiService)
        {

            _apiService = apiService;

        }

        public IActionResult Index()
        {
           var response = _apiService.Get("london");
            return View(response);
        }
    }
}
