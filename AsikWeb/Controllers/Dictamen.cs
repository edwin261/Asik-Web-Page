using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AsikWeb.Base;
using AsikWeb.Models.Entidades;
using AsikWeb.Reportes;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AsikWeb.Controllers
{
    public class Dictamen : BaseController
    {
        IServiceProvider _serviceProvider;
        public Dictamen(IServiceProvider serviceProvider)
            : base(serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            using (var service = GetService<ASIK_PGWEB_Service>())
            {
                var LstOT = await service.GetLstOT(false);
                return View(LstOT);
            }
        }
        [HttpGet]
        public async Task<IActionResult> Create(int codOt)
        {
            using (var service = GetService<ASIK_PGWEB_Service>())
            {
                var LstOT = await service.Fac_Cont_Ot(codOt);
                return View(LstOT);
            }
        }

        [HttpPost]
        public async Task<IActionResult> SendEmailDict(int codOt, int CodProc, Env_Dictamen env_Dictamen)
        {
            try
            {
                using (var service = GetService<ASIK_PGWEB_Service>())
                {
                    var LstOT = await service.GetOT(codOt);
                    if (LstOT.Ord_Trabajo.Count() > 0)
                    {
                        CorreoController correoController = new CorreoController(_serviceProvider);
                        switch (CodProc)
                        {
                            case 1:
                                //var Env_DictSave = await service.Env_DictSave(env_Dictamen);
                                //if (Env_DictSave.errorMetodo == null)
                                //{
                                    await correoController.Send_Email_Facturacion(LstOT.Ord_Trabajo.FirstOrDefault().Ord_Nomproy,
                                        LstOT.Clientes.FirstOrDefault(), 9, LstOT.Ord_Trabajo.FirstOrDefault().Ord_Codotc.ToString(),
                                        LstOT.LstUsuarios);
                                //}
                                break;
                            case 2:
                                var Env_DictSave2 = await service.Env_DictSave(env_Dictamen);
                                if (Env_DictSave2.errorMetodo == null)
                                {
                                    ReporteCliente ClientReport = new ReporteCliente();
                                    var Report = ClientReport.PdfReportClient(
                                        LstOT.Ord_Trabajo.FirstOrDefault(),
                                        LstOT.Clientes.FirstOrDefault(),
                                        LstOT.Usuarios,
                                        LstOT.Alcance.FirstOrDefault()
                                        );
                                    if (Report.Status)
                                        correoController.Send_EmailDictamen(LstOT.Ord_Trabajo.FirstOrDefault(), env_Dictamen, Report.Message);
                                }
                                break;
                        }
                    }
                    return Json(new { Status = true, Message = "Dictamen generado exitosamente" });
                }
            }
            catch (Exception ex)
            {
                return Json(new { Status = false, Message = ex.InnerException.Message });
            }
        }
    }
}