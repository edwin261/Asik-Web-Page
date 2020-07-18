using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AsikWeb.Base;
using AsikWeb.Models.Entidades;
using AsikWeb.Reportes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AsikWeb.Controllers
{
    public class RevDocumentalController : BaseController
    {
        IServiceProvider _serviceProvider;
        public RevDocumentalController(IServiceProvider serviceProvider)
             : base(serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        [HttpGet]
        public async Task<IActionResult> Show()
        {
            using (var service = GetService<ASIK_PGWEB_Service>())
            {
                var LstOT = await service.GetLstOT(true);
                return View(LstOT);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Create(int Ord_CodOtc)
        {
            using (var service = GetService<ASIK_PGWEB_Service>())
            {
                var LstOT = await service.GetDocs(Ord_CodOtc);
                return View(LstOT);
            }
        }

        [HttpPost]
        public async Task<IActionResult> updateCheckDoc(List<int> Docs, List<int> DocsNoApr, List<string> Observa, int CodOt)
        {
            if(Docs.Count > 0)
            {
                using (var service = GetService<ASIK_PGWEB_Service>())
                {
                    var status = await service.updateCheckDoc(Docs, DocsNoApr, Observa, CodOt);

                    int cant_visitRev = await service.cant_visitRev(CodOt, false);
                    if (status.errorMetodo == null)
                    {
                        CorreoController correo = new CorreoController(_serviceProvider);
                        correo.Send_Email_Rev_Documental(status.rev_DocItems, status.Ord_Trabajo.FirstOrDefault());
                        if (cant_visitRev == 1)
                            correo.Send_Email_Cant_VisitRev(status.Ord_Trabajo.FirstOrDefault(), "Revision documental",
                                status.LstUsuarios);
                        bool GetLstAtestacion = await service.GetAtestacion(status.Ord_Trabajo.FirstOrDefault().Ord_Codotc);
                        if(GetLstAtestacion)
                        {
                            List<Usuarios> Lstusuarios = await service.GetUsuarios(8);
                            Usuarios usuarios = await service.GetTecnico(status.Ord_Trabajo.FirstOrDefault().Ord_Codotc);
                            correo.Conf_CampoDoc(Lstusuarios, usuarios, status.Ord_Trabajo.FirstOrDefault());
                        }
                        return Json(new { Status = true, Message = status.successMetodo });
                    }
                    return Json(new { Status = false, Message = status.errorMetodo });
                }
            }
            else
            {
                return Json(new { Status = false, Message = "No se han seleccionado documentos" });
            }       
        }
    }
}