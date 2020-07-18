using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AsikWeb.Reportes;
using AsikWeb.Models.ViewModels;
using AsikWeb.Models.Entidades;
using AsikWeb.Base;
using System.Security.Claims;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AsikWeb.Controllers
{
    public class OrdenTrabajo : BaseController
    {
        IServiceProvider _serviceProvider;
        public OrdenTrabajo(IServiceProvider serviceProvider)
            : base(serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        // GET: /<controller>/
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            using (var service = GetService<ASIK_PGWEB_Service>())
            {
                AsikViewModel AsikViewModel = new AsikViewModel();
                AsikViewModel.TipPago = await service.GetTipPago();
                AsikViewModel.Alcance = await service.GetAlcance();
                AsikViewModel.TipAlcance = await service.GetLstTipAlcance(1);
                return View(AsikViewModel);
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

        [HttpGet]
        public async Task<IActionResult> ShowOT(int Ord_CodOtc)
        {
            using (var service = GetService<ASIK_PGWEB_Service>())
            {
                var LstOT = await service.GetOT(Ord_CodOtc);
                return View(LstOT);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Save(Ord_Trabajo OT)
        {
            using (var service = GetService<ASIK_PGWEB_Service>())
            {
                try
                {
                    var identity = HttpContext.User.Identity as ClaimsIdentity;
                    OT.Ord_Feccre = DateTime.Now;
                    OT.Ord_Fecmod = OT.Ord_Feccre;
                    OT.Ord_Codotc = await service.GetConsecutivo();
                    OT.Ord_Usucre = Convert.ToInt32(identity.Claims.Where(x => x.Type == ClaimTypes.PrimarySid).FirstOrDefault().Value);
                    OT.Ord_Usumod = OT.Ord_Usucre;
                    OT.Ord_Fec90 = Convert.ToDateTime(DateTime.Now.AddDays(90).ToShortDateString());
                    OT.Ord_Fecfin = Convert.ToDateTime(DateTime.Now.AddDays(120).ToShortDateString());
                    OT.Ord_Estado = 14;
                    OT.Ord_Canvis_Rest = OT.Ord_Canvis;
                    OT.Ord_RevDoc_Rest = OT.Ord_Revdoc;
                    OT.Ord_Codsed = OT.Ord_Codsed;
                    if (OT.Ord_Emacad == null)
                        OT.Ord_Emacad = "emarquez26@misena.edu.co";

                    var Result = await service.ValidateSaveOT(OT);
                    if (Result != null)
                    {
                        if (Result.errorMetodo == null)
                        {
                            CorreoController ClientCorreo = new CorreoController(_serviceProvider);
                            await ClientCorreo.Send_Email_ProgTec(OT, Result.LstUsuarios, Result.Clientes.FirstOrDefault(),
                                Result.Deparcol.FirstOrDefault(), Result.Munidep.FirstOrDefault());

                            ClientCorreo.Send_Email_Documental(OT, Result.LstUsuarios, Result.Clientes.FirstOrDefault(),
                                Result.Deparcol.FirstOrDefault(), Result.Munidep.FirstOrDefault(), Result.Alcance,
                                Result.TipAlcance);

                            ClientCorreo.Send_Rev_DocumentalToCli(Result.rev_DocItems, OT);
                        }
                        else
                        {
                            return Json(new { Status = false, Message = Result.errorMetodo });
                        }
                    }
                    else
                    {
                        return Json(new { Status = false, Message = "Error al guardar, intente nuevamente." });
                    }
                    return Json(new { Status = true, Message = Result.successMetodo });
                }
                catch (Exception ex)
                {
                    return Json(new { Status = false, Message = ex.Message });
                }

            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int Ord_Codigo, int canvis, int canrevdoc)
        {
            using (var service = GetService<ASIK_PGWEB_Service>())
            {
                try
                {
                    var Result = await service.EditOt(Ord_Codigo, canvis, canrevdoc);
                    return Json(new { Message = Result });
                }
                catch (Exception ex)
                {
                    return Json(new { Status = false, Message = ex.Message });
                }

            }
        }

        [HttpPost]
        public async Task<IActionResult> Clientes()
        {
            using (var service = GetService<ASIK_PGWEB_Service>())
            {
                var Cliente = await service.Getclientes();
                return Json(Cliente);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Sedes(int codcli)
        {
            using (var service = GetService<ASIK_PGWEB_Service>())
            {
                var Sedes = await service.GetSedes(codcli);
                return Json(Sedes);
            }
        }

        [HttpPost]
        public async Task<IActionResult> GetTipAlcance(int Tip_Alcodi)
        {
            using (var service = GetService<ASIK_PGWEB_Service>())
            {
                var GetLstTipAlmance = await service.GetLstTipAlcance(Tip_Alcodi);
                return Json(GetLstTipAlmance);
            }
        }

        [HttpGet]
        public async Task<IActionResult> MailNinetyDays()
        {
            using (var service = GetService<ASIK_PGWEB_Service>())
            {
                try
                {
                    CorreoController correo = new CorreoController(_serviceProvider);
                    bool SendMail = await correo.ninetyDaysMail();
                    return View();
                }
                catch (Exception ex)
                {
                    return Json(new { Error = ex.InnerException.Message });
                }
            }
        }
    }
}