using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AsikWeb.Base;
using AsikWeb.Models.Entidades;
using AsikWeb.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AsikWeb.Controllers
{
    public class Maestros : BaseController
    {
        public Maestros(IServiceProvider serviceProvider)
            : base(serviceProvider)
        {
        }

        #region Clientes
        [HttpGet]
        public async Task<IActionResult> Clientes()
        {
            using (var service = GetService<ASIK_PGWEB_Service>())
            {
                AsikViewModel AsikViewModel = new AsikViewModel();
                AsikViewModel.Deparcol = await service.GetDepartamento();
                return View(AsikViewModel);

            }
        }

        [HttpGet]
        public async Task<IActionResult> Lst_Clientes()
        {
            using (var service = GetService<ASIK_PGWEB_Service>())
            {
                var GetLstCliDepCiu = await service.GetLstCliDepCiu();
                return View(GetLstCliDepCiu);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Edit_Clientes(int cli_identi)
        {
            using (var service = GetService<ASIK_PGWEB_Service>())
            {
                AsikViewModel asikViewModel = new AsikViewModel();
                asikViewModel.Clientes = await service.VerifiNitCli(cli_identi);
                asikViewModel.Munidep = await service.GetCiudad();
                asikViewModel.Deparcol = await service.GetDepartamento();
                asikViewModel.Sedes_Cli = await service.SedesCli(cli_identi);
                return View(asikViewModel);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Add_Clientes(bool save, Clientes clientes)
        {
            using (var service = GetService<ASIK_PGWEB_Service>())
            {
                var Result = await service.SaveCliente(save, clientes);
                if (Result.errorMetodo == null)
                    return Json(new { Status = true, Message = Result.successMetodo });
                return Json(new { Status = false, Message = Result.errorMetodo });
            }
        }

        [HttpPost]
        public async Task<IActionResult> VerifiNit(int Nit)
        {
            using (var service = GetService<ASIK_PGWEB_Service>())
            {
                var cliente = await service.VerifiNitCli(Nit);
                return Json(cliente);
            }
        }
        #endregion

        #region Sede
        [HttpPost]
        public async Task<IActionResult> Get_Sede(int Cod_sede)
        {
            using (var service = GetService<ASIK_PGWEB_Service>())
            {
                var Sede = await service.GetSede(Cod_sede);
                return Json(Sede);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Delete_Sede(int Cod_sede)
        {
            using (var service = GetService<ASIK_PGWEB_Service>())
            {
                var Result = await service.Del_Sede(Cod_sede);
                if (Result.errorMetodo == null)
                    return Json(new { Status = true, Message = Result.successMetodo });
                return Json(new { Status = false, Message = Result.errorMetodo });
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddSedeCliente(bool save, Sedes_Cli sede)
        {
            using (var service = GetService<ASIK_PGWEB_Service>())
            {
                var Result = await service.AddSede(save, sede);
                if (Result.errorMetodo == null)
                    return Json(new { Status = true, Message = Result.successMetodo });
                return Json(new { Status = false, Message = Result.errorMetodo });
            }
        }
        #endregion

        #region Ciudades
        [HttpPost]
        public async Task<IActionResult> Lstciudades(int Dep_Codigo)
        {
            using (var service = GetService<ASIK_PGWEB_Service>())
            {
                var GetLstTipAlmance = await service.GetLstCidades(Dep_Codigo);
                return Json(GetLstTipAlmance);
            }
        }
        #endregion

        #region Usuarios
        [HttpGet]
        public async Task<IActionResult> Usuarios()
        {
            using (var service = GetService<ASIK_PGWEB_Service>())
            {
                AsikViewModel AsikViewModel = new AsikViewModel();
                AsikViewModel.LstRol = await service.GetRol();
                return View(AsikViewModel);

            }
        }

        [HttpGet]
        public async Task<IActionResult> Lst_Usuarios()
        {
            using (var service = GetService<ASIK_PGWEB_Service>())
            {
                AsikViewModel AsikViewModel = new AsikViewModel();
                AsikViewModel.LstUsuarios = await service.GetUsuarios(0);
                return View(AsikViewModel);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Edit_Usuario(int usu_identi)
        {
            using (var service = GetService<ASIK_PGWEB_Service>())
            {
                var obj_usu = await service.ViewEditUsuario(usu_identi);
                return View(obj_usu);
            }
        }

        [HttpPost]
        public async Task<IActionResult> VerifiNitUsu(int Nit)
        {
            using (var service = GetService<ASIK_PGWEB_Service>())
            {
                var cliente = await service.VerifiNitUsu(Nit);
                return Json(cliente);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Est_Usuario(int codigo, int usuIdenti)
        {
            using (var service = GetService<ASIK_PGWEB_Service>())
            {
                string mensaje = codigo == 5 ? "Activado" : codigo == 14 ? "Eliminado" : "Desactivado";
                bool Result = await service.Est_Usuario(codigo, usuIdenti);
                if (Result)
                    return Json(new { Status = true, Message = "Usuario " + mensaje + " exitosamente" });
                return Json(new { Status = false, Message = "Ocurrio un error" });
            }
        }

        [HttpPost]
        public async Task<IActionResult> Add_Usuarios(Usuarios usuarios, List<Rol_Usuario> rol_Usuario)
        {
            using (var service = GetService<ASIK_PGWEB_Service>())
            {
                var Result = await service.SaveUsuario(usuarios, rol_Usuario);
                if (Result.errorMetodo == null)
                    return Json(new { Status = true, Message = Result.successMetodo });
                return Json(new { Status = false, Message = Result.errorMetodo });
            }
        }
        #endregion

        #region Herramientas
        [HttpGet]
        public async Task<IActionResult> Herramientas()
        {
            using (var service = GetService<ASIK_PGWEB_Service>())
            {
                AsikViewModel AsikViewModel = new AsikViewModel();
                AsikViewModel.LstUsuarios = await service.GetUsuarios(4);
                return View(AsikViewModel);

            }
        }

        [HttpGet]
        public async Task<IActionResult> Lst_Herramientas()
        {
            using (var service = GetService<ASIK_PGWEB_Service>())
            {
                var Lst_her = await service.GetHerramientas(0);
                return View(Lst_her);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Edit_herramientas(int herCod)
        {
            using (var service = GetService<ASIK_PGWEB_Service>())
            {
                var obj_Her = await service.GetHerramientas(herCod);
                return View(obj_Her);
            }
        }

        [HttpPost]
        public async Task<IActionResult> SaveHerramienta(Herramientas herramientas, List<Herramientas_Usuarios> herramientas_Usuarios)
        {
            using (var service = GetService<ASIK_PGWEB_Service>())
            {
                var Result = await service.SaveHerramienta(herramientas, herramientas_Usuarios);
                if (Result.errorMetodo == null)
                    return Json(new { Status = true, Message = Result.successMetodo });
                return Json(new { Status = false, Message = Result.errorMetodo });
            }
        }
        #endregion

        #region FormaPago
        [HttpGet]
        public async Task<IActionResult> TipoPago()
        {
            using (var service = GetService<ASIK_PGWEB_Service>())
            {
                List<TipPago> LstTipPag = await service.GetTipPago();
                return View(LstTipPag);
            }
        }

        [HttpPost]
        public async Task<JsonResult> AddOrUpdateTipag(TipPago tipPago, string save)
        {
            using (var service = GetService<ASIK_PGWEB_Service>())
            {
                var Result = await service.AddOrUpdateTipag(tipPago, save);
                if (Result.errorMetodo == null)
                    return Json(new { Status = true, Message = Result.successMetodo });
                return Json(new { Status = false, Message = Result.errorMetodo });
            }
        }

        [HttpPost]
        public async Task<JsonResult> DeleteFrmPago(int TipCodigo)
        {
            using (var service = GetService<ASIK_PGWEB_Service>())
            {
                var Result = await service.DeleteFrmPago(TipCodigo);
                if (Result.errorMetodo == null)
                    return Json(new { Status = true, Message = Result.successMetodo });
                return Json(new { Status = false, Message = Result.errorMetodo });

            }
        }

        [HttpPost]
        public async Task<JsonResult> SearchTipago(int TipCodigo)
        {
            using (var service = GetService<ASIK_PGWEB_Service>())
            {
                TipPago TipPag = await service.SearchTipago(TipCodigo);
                return Json(TipPag);
            }
        }
        #endregion
    }
}