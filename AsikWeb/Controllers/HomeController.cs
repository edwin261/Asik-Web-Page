using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AsikWeb.Models;
using Microsoft.AspNetCore.Http;
using AsikWeb.Base;
using AsikWeb.Models.Entidades;

namespace AsikWeb.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IServiceProvider serviceProvider)
            : base(serviceProvider)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SplashScreen()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Menu()
        {
            using (var service = GetService<ASIK_PGWEB_Service>())
            {
                var Result = await service.GetMenu();               
                return Json(Result);
            }
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
