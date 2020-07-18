using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AsikWeb.Base;
using AsikWeb.Models.Entidades;
using AsikWeb.Reportes;
using Microsoft.AspNetCore.Mvc;

namespace AsikWeb.Controllers
{
    public class ProgramarOT : BaseController
    {
        IServiceProvider _serviceProvider;
        public ProgramarOT(IServiceProvider serviceProvider)
            : base(serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        // GET: /<controller>/
        public async Task<IActionResult> Create(int Ord_codotc)
        {
            using (var service = GetService<ASIK_PGWEB_Service>())
            {
                var SearchResult = await service.SearchOT(Ord_codotc, 0, 0);
                return View(SearchResult);
            }
        }

        [HttpPost]
        public async Task<JsonResult> SaveEvent(Calendario Calendar)
        {
            using (var service = GetService<ASIK_PGWEB_Service>())
            {
                var Result = await service.Create_Prog_Tec(Calendar);
                if (Result != null)
                {
                    if (Result.errorMetodo == null)
                    {
                        return Json(new { Status = true, Message = Result.successMetodo });
                    }
                    return Json(new { Status = false, Message = Result.errorMetodo });
                }
                else
                {
                    return Json(new { Status = false, Message = "Error al guardar, intente nuevamente." });
                }
            }
        }

        [HttpPost]
        public async Task<IActionResult> DeleteEvent(int CalendarId)
        {
            using (var service = GetService<ASIK_PGWEB_Service>())
            {
                var status = await service.DeleteProgEvent(CalendarId);
                if (status.errorMetodo == null)
                    return Json(new { Status = true, Message = status.successMetodo });
                return Json(new { Status = false, Message = status.errorMetodo });
            }
        }

        [HttpPost]
        public async Task<IActionResult> GetProgramacion(int codTec, int codigoOt, int rol)
        {
            using (var service = GetService<ASIK_PGWEB_Service>())
            {
                var LstProgamacion = await service.LstProgramacionxTecnico(codigoOt, codTec, rol);
                return Json(LstProgamacion);
            }
        }

        [HttpPost]
        public async Task<IActionResult> LoadHerAsigtoTec(int codTec)
        {
            using (var service = GetService<ASIK_PGWEB_Service>())
            {
                var LstHerramientas = await service.LoadHerAsigtoTec(codTec);
                return Json(LstHerramientas);
            }
        }

        [HttpPost]
        public async Task<IActionResult> save(Prog_Ot prog_Ot)
        {
            using (var service = GetService<ASIK_PGWEB_Service>())
            {
                var Result = await service.prog_Ot_save(prog_Ot);
                if (Result.errorMetodo == null)
                {
                    CorreoController ClientCorreo = new CorreoController(_serviceProvider);
                    await ClientCorreo.Send_Email_Tecnico(
                        Result.Ord_Trabajo.FirstOrDefault(),
                        Result.Calendario.FirstOrDefault(),
                        Result.Usuarios,
                        Result.Clientes.FirstOrDefault(),
                        Result.Deparcol.FirstOrDefault(),
                        Result.Munidep.FirstOrDefault());
                    return Json(new { Status = true, Message = Result.successMetodo });
                }
                else
                {
                    return Json(new { Status = false, Message = Result.errorMetodo });
                }
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
