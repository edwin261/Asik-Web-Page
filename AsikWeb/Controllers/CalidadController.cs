﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AsikWeb.Base;
using AsikWeb.Models.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace AsikWeb.Controllers
{
    public class CalidadController : BaseController
    {
        public CalidadController(IServiceProvider serviceProvider)
            : base(serviceProvider)
        {
        }
        [HttpGet]
        public async Task<IActionResult> Index(bool calendar)
        {
            using (var service = GetService<ASIK_PGWEB_Service>())
            {
                var Btn_Procesos = await service.Lst_BtnProcesos();
                if (!calendar)
                    return View(Btn_Procesos);
                return Json(Btn_Procesos);
            }
        }
        [HttpGet]
        public IActionResult Calendar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SaveFiles()
        {
            return View();
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
    }
}