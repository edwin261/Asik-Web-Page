using System;
using System.Threading.Tasks;
using AsikWeb.Base;
using AsikWeb.Models.Entidades;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AsikWeb.Controllers
{
    public class ConsultarOT : BaseController
    {
        public ConsultarOT(IServiceProvider serviceProvider)
            : base(serviceProvider)
        {
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SearchOT(int Ord_codotc)
        {
            using (var service = GetService<ASIK_PGWEB_Service>())
            {
                var SearchResult = await service.SearchOTTimeLine(Ord_codotc);
                return Json(SearchResult);
            }
        }
    }
}
