using System;
using System.Linq;
using System.Threading.Tasks;
using AsikWeb.Base;
using AsikWeb.Models.Entidades;
using AsikWeb.Reportes;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AsikWeb.Controllers
{
    public class Fac_Cont : BaseController
    {
        IServiceProvider _serviceProvider;
        public Fac_Cont(IServiceProvider serviceProvider)
            : base(serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        // GET: /<controller>/
        public async Task<IActionResult> Create(int Ord_codotc)
        {
            using (var service = GetService<ASIK_PGWEB_Service>())
            {
                var ot_joins = await service.Fac_Cont_Ot(Ord_codotc);
                return View(ot_joins);
            }
        }
        [HttpPost]
        public async Task<IActionResult> Save(int codOt, int rol)
        {
            using (var service = GetService<ASIK_PGWEB_Service>())
            {
                var Result = await service.Fac_Cont_Save(codOt, rol);
                if (Result.errorMetodo == null)
                {
                    var LstOT = await service.GetOT(codOt);
                    if (LstOT.Ord_Trabajo.Count() > 0)
                    {
                        CorreoController correoController = new CorreoController(_serviceProvider);
                        if (Result.IsFacturada)
                        {
                            correoController.Send_Email_Contabilidad(LstOT.Ord_Trabajo.FirstOrDefault().Ord_Nomproy,
                                LstOT.Clientes.FirstOrDefault(), LstOT.Ord_Trabajo.FirstOrDefault().Ord_Codotc.ToString(),
                                await service.GetUsuarios(6));
                        }
                        else
                        {
                            correoController.mailLoadDictamen(await service.GetUsuarios(10),LstOT.Ord_Trabajo.FirstOrDefault());
                        }
                    }
                    return Json(new { Status = true, Message = Result.successMetodo });
                }
                return Json(new { Status = false, Message = Result.errorMetodo });
            }
        }

        [HttpGet]
        public async Task<IActionResult> Show()
        {
            using (var service = GetService<ASIK_PGWEB_Service>())
            {
                var LstOT = await service.GetLstOT(false);
                return View(LstOT);
            }
        }
    }
}
