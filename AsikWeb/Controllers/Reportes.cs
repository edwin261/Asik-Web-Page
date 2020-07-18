using System;
using System.Linq;
using System.Threading.Tasks;
using AsikWeb.Models.Entidades;
using AsikWeb.Reportes;
using Microsoft.AspNetCore.Mvc;
using AsikWeb.Models.ViewModels;
using AsikWeb.Base;
using System.Security.Claims;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AsikWeb.Controllers
{
    public class Reportes : BaseController
    {
        public Reportes(IServiceProvider serviceProvider)
            : base(serviceProvider)
        {            
        }
        // GET: /<controller>/
        public IActionResult RDocNApr()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            Deletefile(@"wwwroot\Asik_Reporte_DocNoAprovado_" + identity.Claims.ToList()[1].Value + ".xlsx");
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> InspecTime()
        {
            using (var service = GetService<ASIK_PGWEB_Service>())
            {
                var identity = HttpContext.User.Identity as ClaimsIdentity;
                Deletefile(@"wwwroot\Asik_Reporte_HoraTec_" + identity.Claims.ToList()[1].Value + ".xlsx");
                AsikViewModel asikViewModel = new AsikViewModel();
                asikViewModel.LstUsuarios = await service.GetUsuarios(4);
                return View(asikViewModel);
            }
        }

        [HttpPost]
        public async Task<string> DictamenReport(int CodCli, DateTime inicio, DateTime fin)
        {
            using (var service = GetService<ASIK_PGWEB_Service>())
            {
                var ObjToExcel = await service.GetObjsToExcel(CodCli, inicio, fin);

                if (ObjToExcel.errorMetodo == null)
                {
                    var identity = HttpContext.User.Identity as ClaimsIdentity;
                    ReporteCliente reporteCliente = new ReporteCliente();
                    string link = await reporteCliente.ExcelRevDoc(
                        Convert.ToInt32(identity.Claims.ToList()[1].Value),
                        ObjToExcel.Rev_Noaprov,
                        ObjToExcel.Ord_Trabajo,
                        ObjToExcel.Clientes,
                        ObjToExcel.Alcance,
                        ObjToExcel.TipAlcance
                        );
                    return "True-" + link + "-Reporte Generado";
                }
                else
                {
                    return "False-" + ObjToExcel.errorMetodo;
                }
            }
        }

        [HttpPost]
        public bool Deletefile(string link)
        {
            using (var service = GetService<ASIK_PGWEB_Service>())
            {
                bool Result = service.DeleteFile(link);
                return Result;
            }
        }

        [HttpPost]
        public async Task<string> DictamenReportTecnicos(int CodTec, DateTime inicio, DateTime fin)
        {
            using (var service = GetService<ASIK_PGWEB_Service>())
            {
                var ObjToExcel = await service.GetReportTec(CodTec, inicio, fin);

                if (ObjToExcel.errorMetodo == null)
                {
                    var identity = HttpContext.User.Identity as ClaimsIdentity;
                    ReporteCliente reporteCliente = new ReporteCliente();
                    string link = await reporteCliente.ExcelTecTime(
                        Convert.ToInt32(identity.Claims.ToList()[1].Value),
                        ObjToExcel.inspeccion,
                        ObjToExcel.Ord_Trabajo,
                        ObjToExcel.Clientes,
                        ObjToExcel.Alcance,
                        ObjToExcel.TipAlcance,
                        ObjToExcel.LstUsuarios
                        );
                    return "True-" + link + "-Reporte Generado";
                }
                else
                {
                    return "False-" + ObjToExcel.errorMetodo;
                }
            }
        }
    }
}