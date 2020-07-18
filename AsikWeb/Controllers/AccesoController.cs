using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AsikWeb.Models.Helpers;
using AsikWeb.Models.Entidades;
using AsikWeb.Base;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;

namespace AsikWeb.Controllers
{
    public class AccesoController : BaseController
    {
        public AccesoController(IServiceProvider serviceProvider)
            : base(serviceProvider)
        {

        }
        #region Methods

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        public async Task<JsonResult> LogIn(int UserAsik, string PassAsik)
        {
            if (!string.IsNullOrEmpty(Convert.ToString(UserAsik).Trim()) && !string.IsNullOrEmpty(PassAsik.Trim()))
            {
                using (var service = GetService<ASIK_PGWEB_Service>())
                {
                    var Result = await service.ValidateLogIn(UserAsik, PassAsik);
                    if (Result != null)
                    {
                        if (Result.errorMetodo == null)
                        {
                            var SetCookieResult = setCookieLogin(Result.Usuarios, Result.LstRol);
                            if (SetCookieResult.Status)
                                return Json(new { Status = true, Rol = Result.LstRol });
                            return Json(new { Status = false, Message = SetCookieResult.Message });
                        }
                        else
                        {
                            return Json(new { Status = false, Message = Result.errorMetodo });
                        }

                    }
                    else
                    {
                        return Json(new { Status = false, Message = "Usuario no encontrado" });
                    }
                }
            }
            else
            {
                return Json(new { Status = false, Message = "Credenciales incorrectas" });
            }
        }

        #endregion

        #region Services

        public async Task<IActionResult> LogOut()
        {
            try
            {
                await RemoveCookie();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return Json(ex.InnerException.Message);
            }
        }
        private AsikWebHelpers setCookieLogin(Usuarios UserAsik, List<Rol> RolUsu)
        {
            try
            {
                int count = 0;
                CookieOptions option = new CookieOptions();
                option.Expires = DateTime.Now.AddDays(1);
                foreach (var LstRol in RolUsu)
                {
                    HttpContext.Response.Cookies.Append("RolUsu_" + count, LstRol.RolNombre, option);
                    HttpContext.Response.Cookies.Append("RolCod_" + count, Convert.ToString(LstRol.RolCodigo), option);
                    count++;
                }
                HttpContext.Response.Cookies.Append("Count", Convert.ToString(count), option);

                List<Claim> claims = new List<Claim>();
                claims.Add(new Claim(ClaimTypes.Name, UserAsik.UsuNombre));
                claims.Add(new Claim(ClaimTypes.PrimarySid, Convert.ToString(UserAsik.UsuIdenti)));
                foreach (var roles in RolUsu)
                {
                    claims.Add(new Claim(ClaimTypes.Role, Convert.ToString(roles.RolCodigo)));
                }

                var ClaimIdentity = new ClaimsIdentity(claims, "Claims Identity");
                var ClaimPrincipal = new ClaimsPrincipal(new[] { ClaimIdentity });

                HttpContext.SignInAsync(ClaimPrincipal);
                return new AsikWebHelpers { Status = true, Message = "" };
            }
            catch (Exception ex)
            {
                return new AsikWebHelpers { Status = false, Message = ex.Message };
            }

        }

        private async Task<bool> RemoveCookie()
        {
            await HttpContext.SignOutAsync();
            return true;
        }
        #endregion
    }
}
