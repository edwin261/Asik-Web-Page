using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AsikWeb.Base;
using AsikWeb.Models.Entidades;
using AsikWeb.Models.ViewModels;
using AsikWeb.Reportes;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AsikWeb.Controllers
{
    public class VisitaTecnica : BaseController
    {
        IServiceProvider _serviceProvider;
        public VisitaTecnica(IServiceProvider serviceProvider)
            : base(serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        // GET: /<controller>/
        public async Task<IActionResult> Visit_Start(int Ord_CodOtc)
        {
            using (var service = GetService<ASIK_PGWEB_Service>())
            {
                var identity = HttpContext.User.Identity as ClaimsIdentity;
                var OT = await service.SearchOT(Ord_CodOtc, 4, Convert.ToInt32(identity.Claims.Where(x => x.Type == ClaimTypes.PrimarySid).FirstOrDefault().Value));
                return View(OT);
            }
        }

        public async Task<IActionResult> VisiTec_OtLst()
        {
            using (var service = GetService<ASIK_PGWEB_Service>())
            {
                var identity = HttpContext.User.Identity as ClaimsIdentity;
                var OT = await service.VisiTec_OtLst(Convert.ToInt32(identity.Claims.Where(x => x.Type == ClaimTypes.PrimarySid).FirstOrDefault().Value));
                return View(OT);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Start(int codOt, bool start)
        {
            using (var service = GetService<ASIK_PGWEB_Service>())
            {
                var identity = HttpContext.User.Identity as ClaimsIdentity;
                AsikViewModel Visit_tec = await service.VisiTec_Start(codOt,
                    Convert.ToInt32(identity.Claims.Where(x => x.Type == ClaimTypes.PrimarySid).FirstOrDefault().Value), start);

                int cant_visitRev = await service.cant_visitRev(codOt, true);

                if (!start)
                {
                    CorreoController correoController = new CorreoController(_serviceProvider);
                    correoController.Send_Email_DirTecnico(Visit_tec.Ord_Trabajo.FirstOrDefault(), Visit_tec.Calendario.FirstOrDefault(),
                        Visit_tec.Usuarios, Visit_tec.LstUsuarios, Visit_tec.Clientes.FirstOrDefault(), Visit_tec.Deparcol.FirstOrDefault(),
                        Visit_tec.Munidep.FirstOrDefault());
                    if (cant_visitRev == 1)
                    {
                        List<Usuarios> usuariosComercial = await service.GetUsuarios(8);
                        correoController.Send_Email_Cant_VisitRev(Visit_tec.Ord_Trabajo.FirstOrDefault(), "visita tecnica",
                            usuariosComercial);
                    }
                }

                if (Visit_tec.errorMetodo == null)
                    return Json(new { Status = true });
                return Json(new { Status = false });
            }
        }

        [HttpPost]
        public async Task<IActionResult> Pausar(int Insp_Codigo, bool pausar)
        {
            using (var service = GetService<ASIK_PGWEB_Service>())
            {
                AsikViewModel tiem_insp = await service.VisiTec_Pausar(Insp_Codigo, pausar);

                if (tiem_insp.errorMetodo == null)
                    return Json(new { Status = true, Message = tiem_insp.successMetodo });
                return Json(new { Status = false, Message = tiem_insp.errorMetodo });
            }
        }        

        [HttpPost]
        public async Task<IActionResult> ConformeCampo(int Insp_Codigo, bool Isconforme, string observa)
        {
            using (var service = GetService<ASIK_PGWEB_Service>())
            {
                var Result = await service.ConformeCampo(Insp_Codigo, Isconforme, observa);
                if (Result.errorMetodo == null)
                {
                    if (!Isconforme)
                    {
                        CorreoController correoController = new CorreoController(_serviceProvider);
                        correoController.SenMailNoConforme(Result.Usuarios, Result.Ord_Trabajo.FirstOrDefault(),
                            Result.Calendario.FirstOrDefault());
                    }
                    return Json(new { Status = true, Message = Result.successMetodo });
                }
                return Json(new { Status = false, Message = Result.errorMetodo });
            }
        }

        [HttpPost]
        public async Task<IActionResult> ConformeDirTec(int codOt, int Insp_Codigo, bool Isconforme)
        {
            using (var service = GetService<ASIK_PGWEB_Service>())
            {
                var Result = await service.ConformeDirTec(codOt, Insp_Codigo, Isconforme);
                if (Result.errorMetodo == null)
                {
                    CorreoController correoController = new CorreoController(_serviceProvider);
                    if (!Isconforme)
                    {
                        correoController.SenMailNoConforme(Result.Usuarios, Result.Ord_Trabajo.FirstOrDefault(),
                            Result.Calendario.FirstOrDefault());
                    }
                    else
                    {
                        bool GetLstAtestacion = await service.GetAtestacion(codOt);
                        if (GetLstAtestacion)
                        {
                            List<Usuarios> Lstusuarios = await service.GetUsuarios(8);
                            Usuarios usuarios = await service.GetTecnico(codOt);
                            var ot = await service.GetOT(codOt);
                            correoController.Conf_CampoDoc(Lstusuarios, usuarios, ot.Ord_Trabajo.FirstOrDefault());
                        }
                    }
                    return Json(new { Status = true, Message = Result.successMetodo });
                }
                return Json(new { Status = false, Message = Result.errorMetodo });
            }
        }
    }
}
