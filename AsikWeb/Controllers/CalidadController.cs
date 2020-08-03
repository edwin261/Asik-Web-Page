using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AsikWeb.Base;
using AsikWeb.Models.Entidades;
using AsikWeb.Reportes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AsikWeb.Controllers
{
    public class CalidadController : BaseController
    {
        IServiceProvider _serviceProvider;
        public CalidadController(IServiceProvider serviceProvider)
            : base(serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        [HttpGet]
        public async Task<IActionResult> Index(bool calendar)
        {
            using (var service = GetService<ASIK_PGWEB_Service>())
            {
                var Btn_Procesos = await service.Lst_BtnProcesos();

                if (calendar)
                    return Json(Btn_Procesos);
                return View(Btn_Procesos);

            }
        }
        [HttpGet]
        public IActionResult Calendar()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> GetProgramacion(List<int> rol)
        {
            using (var service = GetService<ASIK_PGWEB_Service>())
            {
                var LstProgamacion = await service.LstProgramacionxrol(rol);
                return Json(LstProgamacion);
            }
        }
        [HttpGet]
        public async Task<IActionResult> SaveFiles(int tarCodigo, int calCodigo)
        {
            using (var service = GetService<ASIK_PGWEB_Service>())
            {
                var datosModel = await service.SaveFiles(tarCodigo, calCodigo);
                return View(datosModel);

            }
        }
        [HttpPost]
        public async Task<IActionResult> SaveFiles(IFormFile uploadFile, int CalCodigo, int codUsu)
        {
            using (var service = GetService<ASIK_PGWEB_Service>())
            {
                var SaveFileResult = await service.saveTask(uploadFile, CalCodigo, codUsu);
                if (SaveFileResult.errorMetodo == null)
                    return RedirectToAction("Calendar");
                return Json(new { Status = false, Message = SaveFileResult.errorMetodo });
            }
        }
        [HttpPost]
        public async Task<JsonResult> Load_Actividades(int Pro_Codigo)
        {
            using (var service = GetService<ASIK_PGWEB_Service>())
            {
                var Btn_Actividades = await service.Lst_BtnActividades(Pro_Codigo);
                return Json(Btn_Actividades);
            }
        }
        [HttpPost]
        public async Task<JsonResult> Load_Tareas(int Act_Codigo)
        {
            using (var service = GetService<ASIK_PGWEB_Service>())
            {
                var Btn_Tareas = await service.Lst_BtnTareas(Act_Codigo);
                return Json(Btn_Tareas);
            }
        }
        [HttpGet]
        public async Task<JsonResult> LoadInfoIntoTables()
        {
            using (var service = GetService<ASIK_PGWEB_Service>())
            {
                string SaveSucefully = await service.SaveintoTables();
                return Json(SaveSucefully);
            }
        }
        [HttpPost]
        public async Task<JsonResult> SaveNewProgTask(int tarCodigo, DateTime CalFecprog, int Calfecvenc)
        {
            using (var service = GetService<ASIK_PGWEB_Service>())
            {
                string message = await service.SaveNewProgTask(tarCodigo, CalFecprog, Calfecvenc);
                return Json(message);
            }
        }
        [HttpGet]
        public async Task<JsonResult> DelayTask()
        {
            using (var service = GetService<ASIK_PGWEB_Service>())
            {
                string UpdateTask = await service.DelayTask();
                return Json(UpdateTask);
            }
        }
        [HttpPost]
        public async Task<IActionResult> UpdateCalendarTask(int calCodigo, DateTime CalFecreprog)
        {
            using (var service = GetService<ASIK_PGWEB_Service>())
            {
                string UpdateTask = await service.UpdateCalendarTask(calCodigo, CalFecreprog);
                return Json(new { Mesasage = UpdateTask });
            }
        }
        [HttpGet]
        public async Task<IActionResult> TaskReprog()
        {
            using (var service = GetService<ASIK_PGWEB_Service>())
            {
                List<CalCalendario> lstDelayTask = await service.ReprogTask();
                return View(lstDelayTask);
            }
        }
        [HttpPost]
        public async Task<IActionResult> sendMailToReprog(int calCodigo, string calObserva, int codUsu)
        {
            using (var service = GetService<ASIK_PGWEB_Service>())
            {
                var infoToSendMailTaskDelay = await service.sendMailToReprog(calCodigo, calObserva, codUsu);

                if (infoToSendMailTaskDelay.errorMetodo == null)
                {
                    CorreoController ClientCorreo = new CorreoController(_serviceProvider);
                    bool sendMail = ClientCorreo.sendEmailTaskDelay(infoToSendMailTaskDelay.calCalendarios.FirstOrDefault(),
                        infoToSendMailTaskDelay.LstUsuarios, codUsu);
                    if (sendMail)
                        return Json(new { Status = true, Message = infoToSendMailTaskDelay.successMetodo });
                    return Json(new { Status = false, Message = "Ha ocurrido un error al enviar la solicitud." });
                }
                else
                {
                    return Json(new { Status = false, Message = infoToSendMailTaskDelay.errorMetodo });
                }
            }
        }
    }
}