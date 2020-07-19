using AsikWeb.Models.Service;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AsikWeb.Models.ViewModels;
using System.IO;
using System.Globalization;
using System.Runtime.InteropServices.ComTypes;
using System.Net;

namespace AsikWeb.Models.Entidades
{
    public class ASIK_PGWEB_Service : BaseService
    {
        private readonly ASIK_PGWEB_Context _context;
        public ASIK_PGWEB_Service(ASIK_PGWEB_Context context)
        {
            _context = context;
        }
        public async Task<AsikViewModel> ValidateLogIn(int UserAsik, string PassAsik)
        {
            try
            {
                var UserExist = await (from u in _context.Usuarios
                                       where u.UsuIdenti == UserAsik && u.UsuContra == PassAsik
                                       select u).FirstOrDefaultAsync();

                if (UserExist != null)
                {
                    AsikViewModel asikViewModel = new AsikViewModel();
                    asikViewModel.LstRol = await (from r in _context.Rol
                                                  join ru in _context.Rol_Usuario on UserExist.UsuIdenti equals ru.UsuIdenti
                                                  where r.RolCodigo == ru.RolCodigo
                                                  select r).ToListAsync();
                    return new AsikViewModel { Usuarios = UserExist, LstRol = asikViewModel.LstRol };
                }
                return null;
            }
            catch (Exception ex)
            {
                return new AsikViewModel { errorMetodo = ex.Message };
            }
        }

        public async Task<List<Tareas>> Lst_BtnTareas(int act_Codigo)
        {
            return await _context.Tareas.Where(w => w.TarActcod == act_Codigo).ToListAsync();
        }

        public async Task<List<Actividad>> Lst_BtnActividades(int pro_Codigo)
        {
            return await _context.Actividad.Where(w => w.ActProcod == pro_Codigo).ToListAsync();
        }

        public async Task<List<Proceso>> Lst_BtnProcesos()
        {
            return await _context.Proceso.ToListAsync();
        }

        //, DateTime inicio, DateTime fin
        public async Task<AsikViewModel> GetObjsToExcel(int codCli, DateTime inicio, DateTime fin)
        {
            try
            {
                List<Rev_Noaprov> nap = new List<Rev_Noaprov>();
                List<Tip_alcance> tp = new List<Tip_alcance>();
                List<Alcance> alc = new List<Alcance>();
                var ot = await _context.Ord_Trabajo.Where(
                    w => w.Ord_Codcli == codCli &&
                    w.Ord_Feccre >= inicio && w.Ord_Feccre <= fin.AddDays(1)).ToListAsync();
                if (ot.Count() > 0)
                {
                    foreach (var itemot in ot)
                    {
                        List<Rev_Noaprov> lst_rna = await _context.Rev_Noaprov.Where(w => w.Rev_CodOt == itemot.Ord_Codotc && w.Rev_TipAlcodi == itemot.Ord_Talcod).ToListAsync();
                        if (lst_rna.Count() > 0)
                            nap.AddRange(lst_rna);

                        List<Tip_alcance> lst_tpa = await _context.Tip_alcance.Where(w => w.Tip_alcodi == itemot.Ord_Talcod).ToListAsync();
                        if (lst_tpa.Count() > 0)
                            tp.AddRange(lst_tpa);

                        List<Alcance> lst_alc = await _context.Alcance.Where(w => w.AlcCodigo == itemot.Ord_Alccod).ToListAsync();
                        if (lst_alc.Count() > 0)
                            alc.AddRange(lst_alc);
                    }

                    return new AsikViewModel
                    {
                        Ord_Trabajo = ot,
                        Clientes = await _context.Clientes.Where(w => w.CliIdenti == codCli).ToListAsync(),
                        Rev_Noaprov = nap,
                        TipAlcance = tp,
                        Alcance = alc,
                        successMetodo = "Generando y exportando reporte a Excel."
                    };
                }
                else
                {
                    return new AsikViewModel { errorMetodo = "No se han encontrado registros con el filtro aplicado." };
                }
            }
            catch (Exception ex)
            {
                return new AsikViewModel { errorMetodo = ex.InnerException.Message };
            }
        }

        public async Task<Sedes_Cli> GetSede(int Cod_sede)
        {
            try
            {
                Sedes_Cli sedes_Cli = await _context.Sedes_Cli.Where(w => w.SeCodigo == Cod_sede).FirstOrDefaultAsync();
                return sedes_Cli;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<AsikViewModel> Del_Sede(int cod_sede)
        {
            try
            {
                var Sede_Cli = await _context.Sedes_Cli.Where(w => w.SeCodigo == cod_sede).FirstOrDefaultAsync();
                if (Sede_Cli != null)
                    _context.Sedes_Cli.Remove(Sede_Cli);
                await _context.SaveChangesAsync();
                return new AsikViewModel { successMetodo = "Sede eliminada exitosamente" };
            }
            catch (Exception ex)
            {
                return new AsikViewModel { errorMetodo = ex.Message };
            }
        }

        public bool DeleteFile(string link)
        {
            try
            {
                File.Delete(link);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<AsikViewModel> GetReportTec(int codTec, DateTime inicio, DateTime fin)
        {
            try
            {
                AsikViewModel asikViewModel = new AsikViewModel();

                if (codTec == 0)
                {
                    asikViewModel.inspeccion = await _context.Inspeccion.Where(w => w.Insp_Inici >= inicio && w.Insp_Inici <= fin.AddDays(1)).ToListAsync();
                }
                else
                {
                    asikViewModel.inspeccion = await _context.Inspeccion.Where(w => w.Insp_Codtec == codTec && w.Insp_Inici >= inicio && w.Insp_Inici <= fin.AddDays(1)).ToListAsync();
                }

                if (asikViewModel.inspeccion.Count() > 0)
                {
                    foreach (var inspeccion in asikViewModel.inspeccion)
                    {
                        asikViewModel.Ord_Trabajo = await _context.Ord_Trabajo.Where(w => w.Ord_Codotc == inspeccion.Insp_Codot).ToListAsync();
                    }

                    foreach (var itemot in asikViewModel.Ord_Trabajo)
                    {
                        asikViewModel.TipAlcance = await _context.Tip_alcance.Where(w => w.Tip_alcodi == itemot.Ord_Talcod).ToListAsync();
                        asikViewModel.Alcance = await _context.Alcance.Where(w => w.AlcCodigo == itemot.Ord_Alccod).ToListAsync();
                        asikViewModel.Clientes = await _context.Clientes.Where(w => w.CliIdenti == itemot.Ord_Codcli).ToListAsync();
                        asikViewModel.LstUsuarios = await GetUsuarios(4);
                    }

                    return asikViewModel;
                }
                else
                {
                    return new AsikViewModel { errorMetodo = "No se han encontrado registros con el filtro aplicado." };
                }
            }
            catch (Exception ex)
            {
                return new AsikViewModel { errorMetodo = ex.InnerException.Message };
            }
        }

        public async Task<string> EditOt(int ord_Codigo, int canvis, int canrevdoc)
        {
            try
            {
                Ord_Trabajo ot = await _context.Ord_Trabajo.Where(w => w.Ord_Codotc == ord_Codigo).FirstOrDefaultAsync();
                int canvisant = ot.Ord_Canvis;
                int revdocant = ot.Ord_Revdoc;

                ot.Ord_Canvis = canvis;
                ot.Ord_Revdoc = canrevdoc;

                ot.Ord_Canvis_Rest = canvis - canvisant;
                ot.Ord_RevDoc_Rest = canrevdoc - revdocant;

                _context.Ord_Trabajo.Update(ot).Property(p => p.Ord_Codigo).IsModified = false;
                await _context.SaveChangesAsync();
                return "Orden de trabajo editada";
            }
            catch (Exception ex)
            {
                return ex.InnerException.Message;
            }
        }

        public async Task<int> cant_visitRev(int codOt, bool visita)
        {
            try
            {
                int count = 0;
                if (visita)
                {
                    count = await _context.Ord_Trabajo.Where(w => w.Ord_Codotc == codOt).Select(s => s.Ord_Canvis_Rest).FirstOrDefaultAsync();
                }
                else
                {
                    count = await _context.Ord_Trabajo.Where(w => w.Ord_Codotc == codOt).Select(s => s.Ord_RevDoc_Rest).FirstOrDefaultAsync();
                }
                return count;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public async Task<AsikViewModel> updateCheckDoc(List<int> docs, List<int> DocsNoApr, List<string> observa, int codOt)
        {
            try
            {
                var DocItems = await _context.Rev_DocItem.Where(w => w.Rev_CodOt == codOt && w.Rev_Estado == false).ToListAsync();
                if (DocItems.Count() > 0)
                {
                    for (int i = 0; i < DocsNoApr.Count(); i++)
                    {
                        var setobserva = DocItems.Where(w => w.Rev_CodDocItem == DocsNoApr[i]).FirstOrDefault();
                        if (setobserva != null)
                        {
                            setobserva.Rev_Descrip = observa[i];
                            _context.Rev_DocItem.Update(setobserva).Property(p => p.Rev_Codigo).IsModified = false;
                        }
                    }

                    for (int i = 0; i < docs.Count(); i++)
                    {
                        var SetEstado = DocItems.Where(w => w.Rev_CodDocItem == docs[i]).FirstOrDefault();
                        if (SetEstado != null)
                        {
                            SetEstado.Rev_Estado = true;
                            _context.Rev_DocItem.Update(SetEstado).Property(p => p.Rev_Codigo).IsModified = false;
                        }
                    }
                    var ord_trabajo = await _context.Ord_Trabajo.Where(w => w.Ord_Codotc == codOt).FirstOrDefaultAsync();
                    ord_trabajo.Ord_RevDoc_Rest--;

                    if (DocsNoApr.Count() == 0)
                    {
                        ord_trabajo.Ord_Estado = 13;
                        await Save_RevDocOt(codOt, "AP");
                    }
                    else
                    {
                        DocItems = await _context.Rev_DocItem.Where(w => w.Rev_CodOt == codOt && w.Rev_Estado == false).ToListAsync();
                        await Save_Rev_NoAprov(DocItems);
                    }
                    _context.Ord_Trabajo.Update(ord_trabajo).Property(p => p.Ord_Codigo).IsModified = false;

                    await _context.SaveChangesAsync();

                    return new AsikViewModel
                    {
                        Ord_Trabajo = await _context.Ord_Trabajo.Where(w => w.Ord_Codotc == codOt && w.Ord_Estado != 6 && w.Ord_Estado != 7).ToListAsync(),
                        rev_DocItems = await _context.Rev_DocItem.Where(w => w.Rev_CodOt == codOt && w.Rev_Estado == false).ToListAsync(),
                        LstUsuarios = await GetUsuarios(8),
                        Estados = await _context.Estados.Where(w => w.EstCodigo == ord_trabajo.Ord_Estado).ToListAsync(),
                        successMetodo = "Revision Documental Actualizada"
                    };
                }
                return null;
            }
            catch (Exception ex)
            {
                return new AsikViewModel { errorMetodo = ex.InnerException.Message };
            }
        }
        public async Task<bool> Save_Rev_NoAprov(List<Rev_DocItem> rev_DocItems)
        {
            try
            {
                foreach (var item in rev_DocItems)
                {
                    int numrevCount = 0;
                    var numrev = await _context.Rev_Noaprov.Where(w => w.Rev_CodOt == item.Rev_CodOt).ToListAsync();
                    if (numrev.Count() > 0)
                    {
                        numrevCount = _context.Rev_Noaprov.Where(w => w.Rev_CodOt == item.Rev_CodOt).Select(s => s.Rev_Numrev).Distinct().Count() + 1;
                    }
                    else
                    {
                        numrevCount++;
                    }
                    Rev_Noaprov rev_Noaprov = new Rev_Noaprov
                    {
                        Rev_CodOt = item.Rev_CodOt,
                        Rev_TipAlcodi = item.Rev_TipAlcodi,
                        Rev_DocCheck = item.Rev_DocCheck,
                        Rev_Numrev = numrevCount
                    };
                    await _context.Rev_Noaprov.AddRangeAsync(rev_Noaprov);
                }
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public async Task<AsikViewModel> ConformeDirTec(int codOt, int Insp_Codigo, bool isconforme)
        {
            try
            {
                Inspeccion inspeccion = await _context.Inspeccion.Where(w => w.Insp_Codigo == Insp_Codigo).FirstOrDefaultAsync();
                List<Calendario> calendario = await _context.Calendario.Where(
                    w => w.Codigo_Ot == inspeccion.Insp_Codot && w.Codi_Tec == inspeccion.Insp_Codtec && w.Finalizado != true).ToListAsync();
                if (inspeccion != null)
                {
                    switch (isconforme)
                    {
                        case true:
                            inspeccion.Insp_Dic_Dictec = true;
                            break;
                        case false:
                            inspeccion.Insp_Dic_Dictec = false;
                            break;
                    }
                    inspeccion.Insp_Dic_Fecha = DateTime.Now;
                    if (inspeccion.Insp_Con_Cam && inspeccion.Insp_Dic_Dictec && inspeccion.Insp_Final)
                        calendario.FirstOrDefault().Finalizado = true;
                    _context.Inspeccion.Update(inspeccion).Property(p => p.Insp_Codigo).IsModified = false;
                    await _context.SaveChangesAsync();
                }
                return new AsikViewModel
                {
                    Ord_Trabajo = await _context.Ord_Trabajo.Where(w => w.Ord_Codotc == codOt).ToListAsync(),
                    Usuarios = await _context.Usuarios.Where(w => w.UsuIdenti == calendario.FirstOrDefault().Codi_Tec).FirstOrDefaultAsync(),
                    Calendario = calendario,
                    successMetodo = "Registro actualizado exitosamente"
                };
            }
            catch (Exception ex)
            {
                return new AsikViewModel { errorMetodo = ex.InnerException.Message };
            }
        }
        public async Task<AsikViewModel> ConformeCampo(int Insp_Codigo, bool IsConforme, string observa)
        {
            try
            {
                Inspeccion inspeccion = await _context.Inspeccion.Where(w => w.Insp_Codigo == Insp_Codigo).FirstOrDefaultAsync();
                List<Calendario> calendario = await _context.Calendario.Where(
                    w => w.Codigo_Ot == inspeccion.Insp_Codot && w.Codi_Tec == inspeccion.Insp_Codtec && w.Finalizado != true).ToListAsync();
                if (inspeccion != null)
                {
                    switch (IsConforme)
                    {
                        case true:
                            inspeccion.Insp_Final = true;
                            break;
                        case false:
                            inspeccion.Insp_Final = false;
                            break;
                    }
                    inspeccion.Insp_Observa = observa;
                    if (inspeccion.Insp_Con_Cam && inspeccion.Insp_Dic_Dictec && inspeccion.Insp_Final)
                        calendario.FirstOrDefault().Finalizado = true;
                    inspeccion.Insp_Fefin = DateTime.Now;
                    _context.Calendario.Update(calendario.FirstOrDefault()).Property(p => p.Cal_EventId).IsModified = false;
                    _context.Inspeccion.Update(inspeccion).Property(p => p.Insp_Codigo).IsModified = false;
                    await _context.SaveChangesAsync();
                }

                return new AsikViewModel
                {
                    Ord_Trabajo = await _context.Ord_Trabajo.Where(w => w.Ord_Codotc == inspeccion.Insp_Codot).ToListAsync(),
                    Usuarios = await _context.Usuarios.Where(w => w.UsuIdenti == calendario.FirstOrDefault().Codi_Tec).FirstOrDefaultAsync(),
                    Calendario = calendario,
                    successMetodo = "Registro actualizado exitosamente"
                };
            }
            catch (Exception ex)
            {
                return new AsikViewModel { errorMetodo = ex.InnerException.Message };
            }
        }
        public async Task<AsikViewModel> GetDocs(int ord_CodOtc)
        {
            try
            {
                var OT = await _context.Ord_Trabajo.Where(w => w.Ord_Codotc == ord_CodOtc && w.Ord_RevDoc_Rest > 0).ToListAsync();

                if (OT.Count > 0)
                {
                    return new AsikViewModel
                    {
                        Ord_Trabajo = OT,
                        Clientes = await _context.Clientes.Where(w => w.CliIdenti == OT.FirstOrDefault().Ord_Codcli).ToListAsync(),
                        Alcance = await _context.Alcance.Where(w => w.AlcCodigo == OT.FirstOrDefault().Ord_Alccod).ToListAsync(),
                        TipAlcance = await _context.Tip_alcance.Where(w => w.Tip_alcodi == OT.FirstOrDefault().Ord_Talcod).ToListAsync(),
                        rev_DocItems = await _context.Rev_DocItem.Where(w => w.Rev_CodOt == OT.FirstOrDefault().Ord_Codotc).ToListAsync()
                    };
                }
                return new AsikViewModel
                {
                    errorMetodo = "Informamos que la orden de trabajo no se le permiten nuevas revisiones documentales."
                };
            }
            catch (Exception ex)
            {
                return new AsikViewModel { errorMetodo = ex.InnerException.Message };
            }
        }
        public async Task<AsikViewModel> VisiTec_Start(int codOt, int cod_Usu, bool Is_Start)
        {
            AsikViewModel asikViewModel = new AsikViewModel();
            try
            {
                var inspeccion = await _context.Inspeccion.Where(w => w.Insp_Codot == codOt && w.Insp_Codtec == cod_Usu).ToListAsync();
                inspeccion.FirstOrDefault().Insp_Acept = true;
                if (Is_Start)
                {
                    inspeccion.FirstOrDefault().Insp_Inici = DateTime.Now;

                    Tiem_Insp Tiem_Insps = new Tiem_Insp
                    {
                        TiemCod_Insp = inspeccion.FirstOrDefault().Insp_Codigo,
                        TiemIni = Convert.ToDateTime(inspeccion.FirstOrDefault().Insp_Inici),
                        TiemFin = null,
                        Tiemtot = null
                    };
                    await _context.Tiem_Insps.AddAsync(Tiem_Insps);
                }
                else
                {
                    inspeccion.FirstOrDefault().Insp_Fin = DateTime.Now;

                    List<Tiem_Insp> tiem_Insp = await _context.Tiem_Insps.Where(w => w.TiemCod_Insp == inspeccion.FirstOrDefault().Insp_Codigo).ToListAsync();
                    TimeSpan TiemInspTot = tiem_Insp.FirstOrDefault().TiemIni - tiem_Insp.FirstOrDefault().TiemIni;
                    if (tiem_Insp != null)
                    {
                        foreach (var lstTiemInsp in tiem_Insp)
                        {
                            if (lstTiemInsp.TiemFin == null)
                            {
                                lstTiemInsp.TiemFin = inspeccion.FirstOrDefault().Insp_Fin;
                                _context.Tiem_Insps.Update(lstTiemInsp).Property(p => p.TiemCod).IsModified = false;
                            }
                            TiemInspTot += (Convert.ToDateTime(lstTiemInsp.TiemFin) - lstTiemInsp.TiemIni);
                        }
                    }

                    inspeccion.FirstOrDefault().Insp_Ttotal = string.Format("{0} Dias, {1} Horas, {2} Minutos, {3} Segundos",
                           TiemInspTot.Days, TiemInspTot.Hours, TiemInspTot.Minutes, TiemInspTot.Seconds);
                    inspeccion.FirstOrDefault().Insp_Con_Cam = true;
                    inspeccion.FirstOrDefault().Insp_Fecha = inspeccion.FirstOrDefault().Insp_Fin;

                    asikViewModel.Ord_Trabajo = await _context.Ord_Trabajo.Where(w => w.Ord_Codotc == codOt).ToListAsync();
                    asikViewModel.Calendario = await _context.Calendario.Where(w => w.Codigo_Ot == codOt && w.Codi_Tec == cod_Usu).ToListAsync();
                    asikViewModel.Usuarios = await _context.Usuarios.Where(w => w.UsuIdenti == cod_Usu).FirstOrDefaultAsync();
                    asikViewModel.Clientes = await _context.Clientes.Where(w => w.CliIdenti == asikViewModel.Ord_Trabajo.FirstOrDefault().Ord_Codcli).ToListAsync();
                    asikViewModel.Deparcol = await _context.Deparcol.Where(w => w.Dep_Codigo == asikViewModel.Clientes.FirstOrDefault().DepCodigo).ToListAsync();
                    asikViewModel.Munidep = await _context.Munidep.Where(w => w.Ciu_Codigo == asikViewModel.Clientes.FirstOrDefault().CiuCodigo).ToListAsync();
                    var ord_trabajo = await _context.Ord_Trabajo.Where(w => w.Ord_Codotc == codOt).FirstOrDefaultAsync();
                    var dtec_Tipo = await (from tc in _context.Tecn_Direc
                                           join dt in _context.Dtec_Tipo on tc.Dtec_Codigo equals dt.Dtec_Codigo
                                           where tc.Usu_Identi == cod_Usu && dt.Dtec_Rdtipo == ord_trabajo.Ord_Alccod
                                           select dt).ToListAsync();
                    asikViewModel.LstUsuarios = await _context.Usuarios.Where(w => w.UsuIdenti == dtec_Tipo.FirstOrDefault().Dtec_IdUsua).ToListAsync();
                    ord_trabajo.Ord_Canvis_Rest--;

                    _context.Ord_Trabajo.Update(ord_trabajo).Property(p => p.Ord_Codigo).IsModified = false;
                }

                _context.Inspeccion.Update(inspeccion.FirstOrDefault()).Property(p => p.Insp_Codigo).IsModified = false;
                await _context.SaveChangesAsync();
                return asikViewModel;
            }
            catch (Exception ex)
            {
                return new AsikViewModel { errorMetodo = ex.InnerException.Message };
            }
        }
        public async Task<AsikViewModel> VisiTec_Pausar(int Insp_Codigo, bool pausar)
        {
            try
            {
                if (pausar)
                {
                    var tiem_Insps = await _context.Tiem_Insps.Where(w => w.TiemCod_Insp == Insp_Codigo && w.TiemFin == null).FirstOrDefaultAsync();
                    tiem_Insps.TiemFin = DateTime.Now;
                    TimeSpan diff = Convert.ToDateTime(tiem_Insps.TiemFin) - tiem_Insps.TiemIni;
                    tiem_Insps.Tiemtot = string.Format("{0} Dias, {1} Horas, {2} Minutos, {3} Segundos",
                           diff.Days, diff.Hours, diff.Minutes, diff.Seconds);
                    _context.Tiem_Insps.Update(tiem_Insps).Property(p => p.TiemCod).IsModified = false;
                    await _context.SaveChangesAsync();
                    return new AsikViewModel { successMetodo = "Visita tecnica Pausada" };
                }
                else
                {
                    try
                    {
                        Tiem_Insp Tiem_Insps = new Tiem_Insp
                        {
                            TiemCod_Insp = Insp_Codigo,
                            TiemIni = DateTime.Now,
                            TiemFin = null,
                            Tiemtot = null
                        };
                        await _context.Tiem_Insps.AddAsync(Tiem_Insps);
                        await _context.SaveChangesAsync();
                        return new AsikViewModel { successMetodo = "Visita tecnica Iniciada" };
                    }
                    catch (Exception ex)
                    {
                        return new AsikViewModel { errorMetodo = ex.InnerException.Message };
                    }
                }

            }
            catch (Exception ex)
            {
                return new AsikViewModel { errorMetodo = ex.InnerException.Message };
            }
        }
        public async Task<AsikViewModel> GetOT(int codOT)
        {
            try
            {
                var LstOrd_trabajo = await (from ot in _context.Ord_Trabajo
                                            join cli in _context.Clientes on ot.Ord_Codcli equals cli.CliIdenti
                                            join tp in _context.TipPago on ot.Ord_Tippag equals tp.TipCodigo
                                            join al in _context.Alcance on ot.Ord_Alccod equals al.AlcCodigo
                                            join tal in _context.Tip_alcance on ot.Ord_Talcod equals tal.Tip_alcodi
                                            where ot.Ord_Estado != 6 && ot.Ord_Estado != 7 && ot.Ord_Codotc == codOT
                                            orderby ot.Ord_Codotc descending
                                            select new { ot, cli, tp, al, tal }).ToListAsync();
                if (LstOrd_trabajo.Count > 0)
                    return new AsikViewModel
                    {
                        Ord_Trabajo = LstOrd_trabajo.Select(s => s.ot).ToList(),
                        Clientes = LstOrd_trabajo.Select(s => s.cli).ToList(),
                        TipPago = LstOrd_trabajo.Select(s => s.tp).ToList(),
                        Alcance = LstOrd_trabajo.Select(s => s.al).ToList(),
                        TipAlcance = LstOrd_trabajo.Select(s => s.tal).ToList(),
                        LstUsuarios = await GetUsuarios(7),
                        Usuarios = await _context.Usuarios.Where(w => w.UsuIdenti == _context.Rol_Usuario.Where(w => w.RolCodigo == 10).Select(s => s.UsuIdenti).FirstOrDefault()).FirstOrDefaultAsync(),
                        Env_Dictamen = await _context.Env_Dictamen.Where(
                            w => w.Env_Codot == LstOrd_trabajo.Select(s => s.ot).FirstOrDefault().Ord_Codotc
                            ).FirstOrDefaultAsync()
                    };
                return null;
            }
            catch (Exception ex)
            {
                return new AsikViewModel { errorMetodo = ex.Message };
            }
        }
        public async Task<AsikViewModel> VisiTec_OtLst(int cod_Usu)
        {
            try
            {
                var Rol_Usuario = await (from ru in _context.Rol_Usuario
                                         join r in _context.Rol on ru.RolCodigo equals r.RolCodigo
                                         where ru.UsuIdenti == cod_Usu
                                         select new { ru, r }).ToListAsync();
                if (Rol_Usuario.Count > 0)
                    return new AsikViewModel
                    {
                        Rol_Usuario = Rol_Usuario.Select(s => s.ru).ToList(),
                        LstRol = Rol_Usuario.Select(s => s.r).ToList(),
                    };
                return null;
            }
            catch (Exception ex)
            {
                return new AsikViewModel { errorMetodo = ex.Message };
            }
        }
        public async Task<AsikViewModel> Fac_Cont_Save(int codOt, int rol)
        {
            try
            {
                bool IsFact = false;
                var Fac_Cont = await _context.Fac_Cont.Where(w => w.Fac_OrdCod == codOt).FirstOrDefaultAsync();
                var OT = await _context.Ord_Trabajo.Where(w => w.Ord_Codotc == codOt).ToListAsync();

                if (Fac_Cont != null)
                {
                    string message = null;
                    switch (rol)
                    {
                        case 6:
                            if (Fac_Cont.Fac_FacVer == true && Fac_Cont.Fac_Fechfa != null)
                            {
                                Fac_Cont.Fac_Conver = true;
                                Fac_Cont.Fac_Feccon = DateTime.Now;
                                message = "Contabilizada";
                                IsFact = false;
                            }
                            break;
                        case 7:
                            if (Fac_Cont.Fac_FacVer == false && Fac_Cont.Fac_Fechfa == null)
                            {
                                Fac_Cont.Fac_FacVer = true;
                                Fac_Cont.Fac_Fechfa = DateTime.Now;
                                message = "facturada";
                                IsFact = true;
                            }
                            break;
                    }
                    _context.Fac_Cont.Update(Fac_Cont).Property(p => p.Fac_Codigo).IsModified = false;
                    OT.FirstOrDefault().Ord_Fecmod = DateTime.Now;
                    _context.Ord_Trabajo.Update(OT.FirstOrDefault()).Property(p => p.Ord_Codigo).IsModified = false;
                    await _context.SaveChangesAsync();
                    return new AsikViewModel
                    {
                        successMetodo = "Orden de trabajo " + message + " exitosamente",
                        IsFacturada = IsFact
                    };
                }
                else
                {
                    return new AsikViewModel { errorMetodo = "Programacion de inspeccion no encontrada o no existe" };
                }
            }
            catch (Exception ex)
            {
                return new AsikViewModel { errorMetodo = ex.Message };
            }
        }
        public async Task<AsikViewModel> DeleteProgEvent(int calendarId)
        {
            try
            {
                var CalendarEvent = await (from c in _context.Calendario
                                           where c.Cal_EventId == calendarId
                                           select c).SingleOrDefaultAsync();
                if (CalendarEvent != null)
                {
                    _context.Calendario.Remove(CalendarEvent);

                    var Inspeccion = await _context.Inspeccion.Where(w => w.Insp_Codot == CalendarEvent.Codigo_Ot && w.Insp_Codtec == CalendarEvent.Codi_Tec).FirstOrDefaultAsync();
                    if (Inspeccion != null)
                        _context.Inspeccion.Remove(Inspeccion);
                    await _context.SaveChangesAsync();
                    return new AsikViewModel { successMetodo = "Programacion eliminada exitosamente" };
                }
                else
                {
                    return new AsikViewModel { errorMetodo = "Programacion de inspeccion no encontrada o no existe" };
                }
            }
            catch (Exception ex)
            {
                return new AsikViewModel { errorMetodo = ex.Message };
            }
        }
        public async Task<bool> Est_Usuario(int codigo, int usuIdenti)
        {
            try
            {
                Usuarios usuarios = await _context.Usuarios.Where(w => w.UsuIdenti == usuIdenti).FirstOrDefaultAsync();
                usuarios.UsuEstad = codigo;
                _context.Usuarios.Update(usuarios).Property(p => p.UsuCodigo).IsModified = false;
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public async Task<AsikViewModel> LoadHerAsigtoTec(int codTec)
        {
            try
            {
                AsikViewModel asikViewModel = new AsikViewModel();
                asikViewModel.Herramientas = await (from hu in _context.Herramientas_Usuarios
                                                    join h in _context.Herramientas on hu.Hercodigo equals h.HerCodigo
                                                    where hu.Usu_identi == codTec
                                                    select h).ToListAsync();
                if (asikViewModel.Herramientas.Count() > 0)
                    return asikViewModel;
                return null;
            }
            catch (Exception ex)
            {
                return new AsikViewModel { errorMetodo = ex.Message };
            }
        }
        public async Task<AsikViewModel> prog_Ot_save(Prog_Ot prog_Ot)
        {
            try
            {
                prog_Ot.Prog_Fech = DateTime.Now;
                _context.Prog_Ot.Add(prog_Ot);

                //actualizar estado de OT a estado = 8
                var OT = await _context.Ord_Trabajo.Where(w => w.Ord_Codotc == prog_Ot.Prog_CodOt && w.Ord_Estado != 7).ToListAsync();
                OT.FirstOrDefault().Ord_Estado = 8;
                _context.Ord_Trabajo.Update(OT.FirstOrDefault()).Property(p => p.Ord_Codigo).IsModified = false;

                var cli = await _context.Clientes.Where(w => w.CliIdenti == OT.FirstOrDefault().Ord_Codcli).ToListAsync();
                await _context.SaveChangesAsync();
                return new AsikViewModel
                {
                    successMetodo = "Programacion agregada exitosamente",
                    Ord_Trabajo = OT,
                    Usuarios = await _context.Usuarios.Where(w => w.UsuIdenti == prog_Ot.Prog_CodTec).FirstOrDefaultAsync(),
                    Clientes = cli,
                    Calendario = await _context.Calendario.Where(w => w.Codigo_Ot == prog_Ot.Prog_CodOt).ToListAsync(),
                    Deparcol = await _context.Deparcol.Where(w => w.Dep_Codigo == cli.FirstOrDefault().DepCodigo).ToListAsync(),
                    Munidep = await _context.Munidep.Where(w => w.Ciu_Codigo == cli.FirstOrDefault().CiuCodigo).ToListAsync()
                };
            }
            catch (Exception ex)
            {
                return new AsikViewModel { errorMetodo = ex.Message };
            }
        }
        public async Task<List<Deparcol>> GetDepartamento()
        {
            var Lstdepartamento = await (from depart in _context.Deparcol
                                         select depart).ToListAsync();
            return Lstdepartamento;
        }
        public async Task<List<Sedes_Cli>> SedesCli(int Cli_Identi)
        {
            var Lstdepartamento = await (from sedes in _context.Sedes_Cli
                                         where sedes.SeCliIden == Cli_Identi
                                         select sedes).ToListAsync();
            return Lstdepartamento;
        }
        public async Task<List<Rol>> GetRol()
        {
            var LstRol = await (from r in _context.Rol
                                select r).ToListAsync();
            return LstRol;
        }
        public async Task<List<Menu>> GetMenu()
        {
            return await (from m in _context.Menu
                          select m).ToListAsync();
        }
        public async Task<List<Clientes>> VerifiNitCli(int nit)
        {
            return await (from u in _context.Clientes
                          where u.CliIdenti == nit
                          select u).ToListAsync();
        }
        public async Task<AsikViewModel> VerifiNitUsu(int nit)
        {
            try
            {
                var verificacion = await (from u in _context.Usuarios
                                          join ru in _context.Rol_Usuario on u.UsuIdenti equals ru.UsuIdenti
                                          where u.UsuIdenti == nit
                                          select new { u, ru }).ToListAsync();
                if (verificacion.Count > 0)
                    return new AsikViewModel
                    {
                        LstUsuarios = verificacion.Select(s => s.u).ToList(),
                        Rol_Usuario = verificacion.Select(s => s.ru).ToList()
                    };
                return null;
            }
            catch (Exception ex)
            {
                return new AsikViewModel
                {
                    errorMetodo = ex.Message
                };
            }
        }
        public async Task<AsikViewModel> SaveCliente(bool save, Clientes clientes)
        {
            string mensaje = "";
            try
            {
                if (clientes.CliCodigo == 0)
                {
                    mensaje = "agregado";
                    _context.Clientes.Add(clientes);
                }
                else
                {
                    mensaje = "modificado";
                    _context.Clientes.Update(clientes).Property(p => p.CliCodigo).IsModified = false;
                }

                await _context.SaveChangesAsync();
                return new AsikViewModel { successMetodo = "Cliente " + mensaje + " exitosamente" };
            }
            catch (Exception ex)
            {
                return new AsikViewModel { errorMetodo = ex.Message };
            }
        }
        public async Task<AsikViewModel> AddSede(bool save, Sedes_Cli sede)
        {
            string mensaje = "";
            try
            {
                if (save)
                {
                    mensaje = "agregada";
                    _context.Sedes_Cli.Add(sede);
                }
                else
                {
                    mensaje = "modificada";
                    _context.Sedes_Cli.Update(sede).Property(p => p.SeCodigo).IsModified = false;
                }

                await _context.SaveChangesAsync();
                return new AsikViewModel { successMetodo = "Sede " + mensaje + " exitosamente" };
            }
            catch (Exception ex)
            {
                return new AsikViewModel { errorMetodo = ex.Message };
            }
        }
        public async Task<AsikViewModel> SaveUsuario(Usuarios usuarios, List<Rol_Usuario> rol_usuario)
        {
            string mensaje = "";
            try
            {
                if (usuarios.UsuCodigo == 0)
                {
                    mensaje = "agregado";
                    _context.Usuarios.Add(usuarios);
                    await _context.SaveChangesAsync();
                    foreach (var ru in rol_usuario)
                    {
                        await _context.Rol_Usuario.AddRangeAsync(ru);
                    }
                }
                else
                {
                    mensaje = "modificado";
                    _context.Usuarios.Update(usuarios).Property(p => p.UsuCodigo).IsModified = false;
                    List<Rol_Usuario> Lst_rol_usuario = await _context.Rol_Usuario.Where(w => w.UsuIdenti == usuarios.UsuIdenti).ToListAsync();
                    _context.Rol_Usuario.RemoveRange(Lst_rol_usuario);
                    await _context.Rol_Usuario.AddRangeAsync(rol_usuario);
                }
                await _context.SaveChangesAsync();
                return new AsikViewModel { successMetodo = "Usuario " + mensaje + " exitosamente" };
            }
            catch (Exception ex)
            {
                return new AsikViewModel { errorMetodo = ex.Message };
            }
        }
        public async Task<AsikViewModel> DeleteFrmPago(int tipCodigo)
        {
            try
            {
                TipPago tipoPago = await (from tp in _context.TipPago
                                          where tp.TipCodigo == tipCodigo
                                          select tp).FirstOrDefaultAsync();
                tipoPago.TipEstado = 6;
                _context.Update(tipoPago);
                await _context.SaveChangesAsync();
                return new AsikViewModel { successMetodo = "Forma de pago eliminada exitosamente" };
            }
            catch (Exception ex)
            {
                return new AsikViewModel { errorMetodo = ex.Message };
            }
        }
        public async Task<AsikViewModel> AddOrUpdateTipag(TipPago tipPago, string save)
        {
            try
            {
                switch (save)
                {
                    case "agregada":
                        _context.TipPago.Add(tipPago);
                        break;
                    case "actualizada":
                        _context.TipPago.Update(tipPago).Property(p => p.TipCodigo).IsModified = false;
                        break;
                }
                await _context.SaveChangesAsync();
                return new AsikViewModel { successMetodo = "Forma de pago " + save + " exitosamente" };
            }
            catch (Exception ex)
            {
                return new AsikViewModel { errorMetodo = ex.Message };
            }
        }
        public async Task<List<Ord_Trabajo>> hundredtwentyDays()
        {
            var dateTime = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            List<Ord_Trabajo> OT = await _context.Ord_Trabajo.Where(w => w.Ord_Fecfin == dateTime).ToListAsync();
            foreach (var ot in OT)
            {
                ot.Ord_Estado = 6;
                _context.Ord_Trabajo.Update(ot).Property(p => p.Ord_Codigo).IsModified = false;
            }
            await _context.SaveChangesAsync();
            return OT;
        }
        public async Task<bool> Est_NoAprobado(int codOt)
        {
            try
            {
                var ot = await GetOT(codOt);
                ot.Ord_Trabajo.FirstOrDefault().Ord_Estado = 6;
                _context.Ord_Trabajo.Update(ot.Ord_Trabajo.FirstOrDefault()).Property(p => p.Ord_Codigo).IsModified = false;
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public async Task<List<Ord_Trabajo>> ninetyDays()
        {
            var dateTime = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            return await _context.Ord_Trabajo.Where(w => w.Ord_Fec90 == dateTime).ToListAsync();
        }
        public async Task<AsikViewModel> SaveHerramienta(Herramientas herramientas, List<Herramientas_Usuarios> herramientas_Usuarios)
        {
            string mensaje = "";
            try
            {
                if (herramientas.HerCodigo != 0)
                {
                    mensaje = "actualizada";
                    if (herramientas_Usuarios.Count == 0)
                        herramientas.HerObser = "OFICINA";
                    _context.Herramientas.Update(herramientas);
                    List<Herramientas_Usuarios> her_usu = await (from hu in _context.Herramientas_Usuarios
                                                                 where hu.Hercodigo == herramientas.HerCodigo
                                                                 select hu).ToListAsync();

                    _context.Herramientas_Usuarios.RemoveRange(her_usu);

                    if (herramientas_Usuarios.Count > 0)
                        _context.Herramientas_Usuarios.AddRange(herramientas_Usuarios);
                }
                else
                {
                    int herramiento_count = (from h in _context.Herramientas where h.HerNumser == herramientas.HerNumser select h).Count();
                    if (herramiento_count == 0)
                    {
                        mensaje = "agregada";
                        herramientas.HerCodigo = (from h in _context.Herramientas select h).Count() + 1;
                        _context.Herramientas.Add(herramientas);
                    }
                    else
                    {
                        return new AsikViewModel { errorMetodo = "Herramienta ya existe" };
                    }

                    foreach (var her_usu in herramientas_Usuarios)
                    {
                        her_usu.Hercodigo = herramientas.HerCodigo;
                    }

                    _context.Herramientas_Usuarios.AddRange(herramientas_Usuarios);
                }

                await _context.SaveChangesAsync();
                return new AsikViewModel { successMetodo = "Herramienta " + mensaje + " exitosamente" };
            }
            catch (Exception ex)
            {
                return new AsikViewModel { errorMetodo = ex.Message };
            }
        }
        public async Task<AsikViewModel> LstProgramacionxTecnico(int codigoOt, int codTec, int rol)
        {
            try
            {
                if (codigoOt == 0)
                {
                    AsikViewModel asikViewModel = new AsikViewModel();
                    //if (codTec == 55305529 && codTec == 72298035)
                    //{
                    //    if (rol == 4)
                    //    {
                    //        var LstProgramacion = await (from cal in _context.Calendario
                    //                                     join ins in _context.Inspeccion on cal.Codigo_Ot equals ins.Insp_Codot
                    //                                     join ot in _context.Ord_Trabajo on cal.Codigo_Ot equals ot.Ord_Codotc
                    //                                     join cli in _context.Clientes on ot.Ord_Codcli equals cli.CliIdenti
                    //                                     where cal.Finalizado != true && cal.Codi_Tec == codTec
                    //                                     select new { cal, ot, cli }).ToListAsync();

                    //        if (LstProgramacion.Count > 0)
                    //            return new AsikViewModel
                    //            {
                    //                Calendario = LstProgramacion.Select(s => s.cal).ToList(),
                    //                Ord_Trabajo = LstProgramacion.Select(s => s.ot).ToList(),
                    //                Clientes = LstProgramacion.Select(s => s.cli).ToList()
                    //            };
                    //    }
                    //    else
                    //    {
                    //        var LstProgramacion = await (from dt in _context.Dtec_Tipo
                    //                                     join td in _context.Tecn_Direc on dt.Dtec_Rdtipo equals td.Dtec_Codigo
                    //                                     join cal in _context.Calendario on td.Usu_Identi equals cal.Codi_Tec
                    //                                     join ins in _context.Inspeccion on cal.Codigo_Ot equals ins.Insp_Codot
                    //                                     join ot in _context.Ord_Trabajo on cal.Codigo_Ot equals ot.Ord_Codotc
                    //                                     join cli in _context.Clientes on ot.Ord_Codcli equals cli.CliIdenti
                    //                                     where dt.Dtec_IdUsua == codTec && cal.Finalizado != true &&
                    //                                       ot.Ord_Estado != 6 && ot.Ord_Estado != 7
                    //                                     select new { cal, ot, cli }).ToListAsync();
                    //        if (LstProgramacion.Count > 0)
                    //            return new AsikViewModel
                    //            {
                    //                Calendario = LstProgramacion.Select(s => s.cal).ToList(),
                    //                Ord_Trabajo = LstProgramacion.Select(s => s.ot).ToList(),
                    //                Clientes = LstProgramacion.Select(s => s.cli).ToList()
                    //            };
                    //    }

                    //}
                    //else
                    //{
                    if (rol == 4)
                    {
                        var LstProgramacion = await (from cal in _context.Calendario
                                                     join ot in _context.Ord_Trabajo on cal.Codigo_Ot equals ot.Ord_Codotc
                                                     join cli in _context.Clientes on ot.Ord_Codcli equals cli.CliIdenti
                                                     where cal.Finalizado != true && cal.Codi_Tec == codTec &&
                                                     ot.Ord_Estado != 6 && ot.Ord_Estado != 7
                                                     select new { cal, ot, cli }).ToListAsync();

                        if (LstProgramacion.Count > 0)
                            return new AsikViewModel
                            {
                                Calendario = LstProgramacion.Select(s => s.cal).ToList(),
                                Ord_Trabajo = LstProgramacion.Select(s => s.ot).ToList(),
                                Clientes = LstProgramacion.Select(s => s.cli).ToList()
                            };
                    }

                    if (rol == 5)
                    {
                        var LstProgramacion = await (from dt in _context.Dtec_Tipo
                                                     join td in _context.Tecn_Direc on dt.Dtec_Codigo equals td.Dtec_Codigo
                                                     join cal in _context.Calendario on td.Usu_Identi equals cal.Codi_Tec
                                                     join ot in _context.Ord_Trabajo on cal.Codigo_Ot equals ot.Ord_Codotc
                                                     join cli in _context.Clientes on ot.Ord_Codcli equals cli.CliIdenti
                                                     join ins in _context.Inspeccion on ot.Ord_Codotc equals ins.Insp_Codot
                                                     where dt.Dtec_Rdtipo == ot.Ord_Alccod && dt.Dtec_IdUsua == codTec
                                                     && ot.Ord_Estado != 6 && ot.Ord_Estado != 7 && ins.Insp_Dic_Fecha == null
                                                     && ins.Insp_Codtec == td.Usu_Identi
                                                     select new { cal, ot, cli }).ToListAsync();
                        if (LstProgramacion.Count > 0)
                            return new AsikViewModel
                            {
                                Calendario = LstProgramacion.Select(s => s.cal).ToList(),
                                Ord_Trabajo = LstProgramacion.Select(s => s.ot).ToList(),
                                Clientes = LstProgramacion.Select(s => s.cli).ToList()
                            };
                    }
                    //}
                    return null;
                }
                else
                {
                    var LstProgramacion = await (from cal in _context.Calendario
                                                 join ot in _context.Ord_Trabajo on cal.Codigo_Ot equals ot.Ord_Codotc
                                                 join cli in _context.Clientes on ot.Ord_Codcli equals cli.CliIdenti
                                                 join tec in _context.Usuarios on cal.Codi_Tec equals tec.UsuIdenti
                                                 where cal.Finalizado != true &&
                                                     ot.Ord_Estado != 6 && ot.Ord_Estado != 7
                                                 select new { cal, ot, cli, tec }).ToListAsync();
                    if (LstProgramacion.Count > 0)
                        return new AsikViewModel
                        {
                            Calendario = LstProgramacion.Select(s => s.cal).ToList(),
                            Ord_Trabajo = LstProgramacion.Select(s => s.ot).ToList(),
                            Clientes = LstProgramacion.Select(s => s.cli).ToList(),
                            LstUsuarios = LstProgramacion.Select(s => s.tec).ToList()
                        };
                    return null;
                }
            }
            catch (Exception ex)
            {
                return new AsikViewModel { errorMetodo = ex.Message };
            }
        }
        public async Task<AsikViewModel> Create_Prog_Tec(Calendario calendar)
        {
            try
            {
                if (calendar.Cal_EventId > 0)
                {
                    var obj_calendar = await _context.Calendario.AsNoTracking().Where(w => w.Cal_EventId == calendar.Cal_EventId).FirstOrDefaultAsync();
                    //int days = (obj_calendar.Inicio - obj_calendar.Fin).Days;
                    calendar.Inicio = calendar.Inicio;
                    //calendar.Inicio = Convert.ToDateTime(calendar.Inicio);
                    calendar.Fin = calendar.Fin;
                    //calendar.Fin = Convert.ToDateTime(calendar.Fin);
                    _context.Calendario.Update(calendar).Property(p => p.Cal_EventId).IsModified = false;
                }
                else
                {
                    var ObjCalendario = await _context.Calendario.Where(w => w.Codigo_Ot == calendar.Codigo_Ot && w.Codi_Tec == calendar.Codi_Tec && w.Finalizado != true).ToListAsync();
                    if (ObjCalendario.Count() > 0)
                    {
                        return new AsikViewModel { errorMetodo = "El tecnico ya posee una programacion asignada a esta orden de trabajo" };
                    }
                    else
                    {
                        //calendar.Inicio = Convert.ToDateTime(calendar.Inicio.ToString("D", new CultureInfo("en-US")));
                        //calendar.Fin = Convert.ToDateTime(calendar.Fin.ToString("D", new CultureInfo("en-US")));
                        calendar.Inicio = calendar.Inicio;
                        calendar.Fin = calendar.Fin;
                        calendar.Finalizado = false;
                        if (calendar.Tod_Dia == true)
                            calendar.Fin = calendar.Inicio;
                        _context.Calendario.Add(calendar);
                        _context.Inspeccion.Add(new Inspeccion
                        {
                            Insp_Codot = calendar.Codigo_Ot,
                            Insp_Codtec = calendar.Codi_Tec,
                            Insp_Acept = false,
                            Insp_Inici = null,
                            Insp_Fin = null,
                            Insp_Ttotal = null,
                            Insp_Con_Cam = false,
                            Insp_Fecha = null,
                            Insp_Final = false,
                            Insp_Fefin = null,
                            Insp_Dic_Dictec = false,
                            Insp_Dic_Fecha = null
                        });
                    }
                }
                _context.SaveChanges();
                int cod_cal = await _context.Calendario.Where(w => w.Codigo_Ot == calendar.Codigo_Ot && w.Codi_Tec == calendar.Codi_Tec).Select(s => s.Cal_EventId).FirstOrDefaultAsync();
                return new AsikViewModel { successMetodo = "Programacion asignada correctamente -" + cod_cal };
            }
            catch (Exception ex)
            {
                return new AsikViewModel { errorMetodo = ex.InnerException.Message };
            }
        }
        public async Task<string> GetEstado(int estado)
        {
            var Estado = await (from u in _context.Estados
                                where u.EstCodigo == estado
                                select u.EstNombre).FirstOrDefaultAsync();
            return Estado;
        }
        public async Task<AsikViewModel> GetLstOT(bool rev_doc)
        {
            try
            {
                var LstOrd_trabajo = await (from ot in _context.Ord_Trabajo
                                            join cli in _context.Clientes on ot.Ord_Codcli equals cli.CliIdenti
                                            join est in _context.Estados on ot.Ord_Estado equals est.EstCodigo
                                            where ot.Ord_Estado != 6 && ot.Ord_Estado != 7
                                            orderby ot.Ord_Codotc descending
                                            select new { ot, cli, est }).ToListAsync();
                if (LstOrd_trabajo.Count > 0)
                {
                    if (rev_doc)
                    {
                        return new AsikViewModel
                        {
                            Ord_Trabajo = LstOrd_trabajo.Select(s => s.ot).ToList(),
                            Clientes = LstOrd_trabajo.Select(s => s.cli).ToList(),
                            Estados = LstOrd_trabajo.Select(s => s.est).ToList(),
                            Fac_Cont = await _context.Fac_Cont.ToListAsync(),
                            Rev_DocOt = await _context.Rev_DocOt.ToListAsync()
                        };
                    }
                    return new AsikViewModel
                    {
                        Ord_Trabajo = LstOrd_trabajo.Select(s => s.ot).ToList(),
                        Clientes = LstOrd_trabajo.Select(s => s.cli).ToList(),
                        Estados = LstOrd_trabajo.Select(s => s.est).ToList(),
                        Fac_Cont = await _context.Fac_Cont.ToListAsync()
                    };
                }
                return null;
            }
            catch (Exception ex)
            {
                return new AsikViewModel { errorMetodo = ex.Message };
            }
        }
        public async Task<int> GetConsecutivo()
        {
            try
            {
                //int Consecutivo = (from u in _context.Ord_Trabajo
                //                   select u).Count() + 1;
                //if (Consecutivo != 0)
                //    return Consecutivo;
                //return 1;
                Random random = new Random();
                int firts_4digit = random.Next(0, 9999);
                int last_4digit = random.Next(0, 9999);
                int count = await _context.Ord_Trabajo.Where(
                    w => w.Ord_Codotc == Convert.ToInt32(firts_4digit.ToString() + last_4digit.ToString())).CountAsync();
                if (count == 0)
                    return Convert.ToInt32(firts_4digit.ToString() + last_4digit.ToString());
                await GetConsecutivo();
                return 0;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public async Task<bool> Save_RevDocOt(int codOt, string observa)
        {
            try
            {
                Rev_DocOt rev_DocOt = new Rev_DocOt();
                rev_DocOt.Rev_CodOt = codOt;
                rev_DocOt.Rev_Observ = observa;
                rev_DocOt.Rev_FecCre = DateTime.Now;

                _context.Rev_DocOt.Add(rev_DocOt);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public async Task<AsikViewModel> ValidateSaveOT(Ord_Trabajo oT)
        {
            try
            {
                await _context.Ord_Trabajo.AddAsync(oT);
                await _context.Fac_Cont.AddAsync(new Fac_Cont
                {
                    Fac_OrdCod = oT.Ord_Codotc,
                    Fac_FacVer = false,
                    Fac_Fechfa = null,
                    Fac_Conver = false,
                    Fac_Feccon = null
                });

                if (oT.Ord_Alccod == 3)
                {
                    await Save_RevDocOt(oT.Ord_Codotc, "NP");
                }
                else
                {
                    if (await SaveRevDocItem(oT.Ord_Talcod, oT.Ord_Codotc))
                    {
                        await _context.SaveChangesAsync();
                    }
                    else
                    {
                        return new AsikViewModel { errorMetodo = "Ha ocurrido un error al guardar la orden de trabajo" };
                    }
                }

                var cli = await _context.Clientes.Where(w => w.CliIdenti == oT.Ord_Codcli).ToListAsync();
                return new AsikViewModel
                {
                    rev_DocItems = await _context.Rev_DocItem.Where(w => w.Rev_CodOt == oT.Ord_Codotc && w.Rev_Estado == false).ToListAsync(),
                    LstUsuarios = await GetUsuarios(2),
                    Clientes = cli,
                    Deparcol = await _context.Deparcol.Where(w => w.Dep_Codigo == cli.FirstOrDefault().DepCodigo).ToListAsync(),
                    Munidep = await _context.Munidep.Where(w => w.Ciu_Codigo == cli.FirstOrDefault().CiuCodigo).ToListAsync(),
                    Alcance = await _context.Alcance.ToListAsync(),
                    TipAlcance = await _context.Tip_alcance.ToListAsync(),
                    successMetodo = "Orden de trabajo guardada exitosamente"
                };
            }
            catch (Exception ex)
            {
                return new AsikViewModel
                {
                    errorMetodo = ex.Message
                };
            }
        }
        public async Task<bool> SaveRevDocItem(int TalCod, int CodOt)
        {
            try
            {
                var Rev_Documental = await _context.Rev_Documentals.Where(w => w.Rev_Tipalcod == TalCod).ToListAsync();
                foreach (var item in Rev_Documental)
                {
                    await _context.Rev_DocItem.AddAsync(new Rev_DocItem
                    {
                        Rev_CodDocItem = item.Rev_Codigo,
                        Rev_TipAlcodi = item.Rev_Tipalcod,
                        Rev_Item = item.Rev_Item,
                        Rev_LisCheck = item.Rev_LisCheck,
                        Rev_DocCheck = item.Rev_DocCheck,
                        Rev_Estado = false,
                        Rev_CodOt = CodOt
                    });
                }
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public async Task<List<Alcance>> GetAlcance()
        {
            try
            {
                var LstAlcance = await (from u in _context.Alcance
                                        select u).ToListAsync();
                if (LstAlcance.Count > 0)
                    return LstAlcance;
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public async Task<List<TipPago>> GetTipPago()
        {
            try
            {
                var TipPago = await (from tp in _context.TipPago
                                     where tp.TipEstado == 5
                                     select tp).ToListAsync();
                if (TipPago.Count > 0)
                    return TipPago;
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public async Task<TipPago> SearchTipago(int rolCodigo)
        {
            try
            {
                var TipPago = await (from tp in _context.TipPago
                                     where tp.TipEstado == 5 && tp.TipCodigo == rolCodigo
                                     select tp).FirstOrDefaultAsync();
                if (TipPago != null)
                    return TipPago;
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public async Task<List<Tip_alcance>> GetLstTipAlcance(int tip_Alcodi)
        {
            try
            {
                var LstTipAlcance = await (from u in _context.Tip_alcance
                                           where u.Alc_codigo == tip_Alcodi
                                           orderby u.Alc_codigo descending
                                           select u).ToListAsync();
                if (LstTipAlcance.Count > 0)
                    return LstTipAlcance;
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public async Task<List<Munidep>> GetLstCidades(int Dep_Codigo)
        {
            try
            {
                var Lstciudades = await (from ciu in _context.Munidep
                                         where ciu.Ciu_Coddep == Dep_Codigo
                                         orderby ciu.Ciu_Codigo descending
                                         select ciu).ToListAsync();
                if (Lstciudades.Count > 0)
                    return Lstciudades;
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public async Task<AsikViewModel> GetLstCliDepCiu()
        {
            try
            {
                var LstClientes = await (from cli in _context.Clientes
                                         join ciu in _context.Munidep on cli.CiuCodigo equals ciu.Ciu_Codigo
                                         join dep in _context.Deparcol on cli.DepCodigo equals dep.Dep_Codigo
                                         select new { cli, ciu, dep }).ToListAsync();
                if (LstClientes.Count > 0)
                    return new AsikViewModel
                    {
                        Clientes = LstClientes.Select(s => s.cli).ToList(),
                        Munidep = LstClientes.Select(s => s.ciu).ToList(),
                        Deparcol = LstClientes.Select(s => s.dep).ToList()
                    };
                return null;
            }
            catch (Exception ex)
            {
                return new AsikViewModel { errorMetodo = ex.Message };
            }
        }
        public async Task<AsikViewModel> SearchOT(int ord_codotc, int opt, int _cod_usu)
        {
            try
            {
                switch (opt)
                {
                    case 4:
                        var inspeccion = await _context.Inspeccion.Where(w => w.Insp_Codot == ord_codotc).ToListAsync();
                        var OTList_Tec = await (from ot in _context.Ord_Trabajo
                                                join cli in _context.Clientes on ot.Ord_Codcli equals cli.CliIdenti
                                                where ot.Ord_Codotc == inspeccion.FirstOrDefault().Insp_Codot
                                                select new { ot, cli }).ToListAsync();
                        if (OTList_Tec.Count > 0)
                            return new AsikViewModel
                            {
                                Ord_Trabajo = OTList_Tec.Select(s => s.ot).ToList(),
                                Clientes = OTList_Tec.Select(s => s.cli).ToList(),
                                Rol_Usuario = await _context.Rol_Usuario.Where(w => w.RolCodigo == _cod_usu).ToListAsync(),
                                Usuarios = await _context.Usuarios.Where(w => w.UsuIdenti == inspeccion.FirstOrDefault().Insp_Codtec).FirstOrDefaultAsync(),
                                inspeccion = inspeccion,
                                Tiem_Insps = await _context.Tiem_Insps.Where(w => w.TiemCod_Insp == inspeccion.FirstOrDefault().Insp_Codigo).ToListAsync()
                            };
                        break;
                    default:
                        var OTList = await (from ot in _context.Ord_Trabajo
                                            join cli in _context.Clientes on ot.Ord_Codcli equals cli.CliIdenti
                                            join alc in _context.Alcance on ot.Ord_Alccod equals alc.AlcCodigo
                                            join talc in _context.Tip_alcance on ot.Ord_Talcod equals talc.Tip_alcodi
                                            where ot.Ord_Codotc == ord_codotc
                                            orderby ot.Ord_Codotc descending
                                            select new { ot, cli, alc, talc }).ToListAsync();
                        if (OTList.Count > 0)
                            return new AsikViewModel
                            {
                                Ord_Trabajo = OTList.Select(s => s.ot).ToList(),
                                Clientes = OTList.Select(s => s.cli).ToList(),
                                LstUsuarios = await GetUsuarios(4),
                                Alcance = OTList.Select(s => s.alc).ToList(),
                                TipAlcance = OTList.Select(s => s.talc).ToList()
                            };
                        break;
                }
                return null;
            }
            catch (Exception ex)
            {
                return new AsikViewModel { errorMetodo = ex.Message };
            }
        }
        public async Task<AsikViewModel> SearchOTTimeLine(int ord_codotc)
        {
            try
            {
                var OTList = await _context.Ord_Trabajo.Where(w => w.Ord_Codotc == ord_codotc).ToListAsync();
                if (OTList.Count() > 0)
                {
                    AsikViewModel asikViewModel = new AsikViewModel
                    {
                        Ord_Trabajo = OTList,
                        Alcance = await _context.Alcance.Where(w => w.AlcCodigo == OTList.FirstOrDefault().Ord_Alccod).ToListAsync(),
                        TipAlcance = await _context.Tip_alcance.Where(w => w.Tip_alcodi == OTList.FirstOrDefault().Ord_Talcod).ToListAsync(),
                        Prog_Ot = await _context.Prog_Ot.Where(w => w.Prog_CodOt == ord_codotc).FirstOrDefaultAsync(),
                        Estados = await _context.Estados.Where(w => w.EstCodigo == OTList.FirstOrDefault().Ord_Estado).ToListAsync(),
                        Rev_DocOt = await _context.Rev_DocOt.Where(w => w.Rev_CodOt == ord_codotc).ToListAsync(),
                    };
                    if (asikViewModel.Prog_Ot != null)
                    {
                        asikViewModel.Calendario = await _context.Calendario.Where(w => w.Codigo_Ot == ord_codotc && w.Codi_Tec == asikViewModel.Prog_Ot.Prog_CodTec).ToListAsync();
                        asikViewModel.Usuarios = await _context.Usuarios.Where(w => w.UsuIdenti == asikViewModel.Prog_Ot.Prog_CodTec).FirstOrDefaultAsync();
                        asikViewModel.inspeccion = await _context.Inspeccion.Where(w => w.Insp_Dic_Dictec == true && w.Insp_Codot == ord_codotc).ToListAsync();
                        asikViewModel.Fac_Cont = await _context.Fac_Cont.Where(w => w.Fac_OrdCod == ord_codotc).ToListAsync();
                        asikViewModel.Env_Dictamen = await _context.Env_Dictamen.Where(w => w.Env_Codot == ord_codotc).FirstOrDefaultAsync();
                    }

                    return asikViewModel;
                }
                return null;
            }
            catch (Exception ex)
            {
                return new AsikViewModel { errorMetodo = ex.Message };
            }
        }
        public async Task<List<Clientes>> Getclientes()
        {
            return await (from u in _context.Clientes
                          orderby u.CliCodigo descending
                          select u).ToListAsync();
        }
        public async Task<List<Sedes_Cli>> GetSedes(int codcli)
        {
            return await (from s in _context.Sedes_Cli
                          where s.SeCliIden == codcli
                          orderby s.SeCodigo descending
                          select s).ToListAsync();
        }
        public async Task<AsikViewModel> Lst_GetUsuarios()
        {
            AsikViewModel asikViewModel = new AsikViewModel();
            asikViewModel.LstUsuarios = await _context.Usuarios.ToListAsync();

            return asikViewModel;
        }
        public async Task<List<Munidep>> GetCiudad()
        {
            return await (from ciu in _context.Munidep
                          orderby ciu.Ciu_Codigo descending
                          select ciu).ToListAsync();
        }
        public async Task<AsikViewModel> GetHerramientas(int herCodigo)
        {
            try
            {
                AsikViewModel asikViewModel = new AsikViewModel();
                if (herCodigo == 0)
                {
                    asikViewModel.Herramientas = await (from h in _context.Herramientas
                                                        orderby h.HerCodigo descending
                                                        select h).ToListAsync();
                }
                else
                {
                    asikViewModel.Herramientas = await (from h in _context.Herramientas
                                                        where h.HerCodigo == herCodigo
                                                        orderby h.HerCodigo descending
                                                        select h).ToListAsync();

                    asikViewModel.herramientas_Usuarios = await (from hu in _context.Herramientas_Usuarios
                                                                 where hu.Hercodigo == herCodigo
                                                                 orderby hu.Hercodigo descending
                                                                 select hu).ToListAsync();

                    asikViewModel.LstUsuarios = await GetUsuarios(4);
                }
                return asikViewModel;
            }
            catch (Exception ex)
            {
                return new AsikViewModel { errorMetodo = ex.Message };
            }
        }
        public async Task<List<Usuarios>> GetUsuarios(int tip_usu)
        {
            if (tip_usu > 0)
                return await (from ru in _context.Rol_Usuario
                              join u in _context.Usuarios on ru.UsuIdenti equals u.UsuIdenti
                              where ru.RolCodigo == tip_usu
                              orderby u.UsuCodigo descending
                              select u).ToListAsync();

            return await (from usu in _context.Usuarios
                          orderby usu.UsuCodigo descending
                          select usu).ToListAsync();
        }
        public async Task<AsikViewModel> ViewEditUsuario(int usu_identi)
        {
            try
            {
                var Obj_Usuario = await (from usu in _context.Usuarios
                                         join ru in _context.Rol_Usuario on usu.UsuIdenti equals ru.UsuIdenti
                                         where usu.UsuIdenti == usu_identi
                                         orderby usu.UsuCodigo descending
                                         select new { usu, ru }).ToListAsync();
                if (Obj_Usuario.Count > 0)
                    return new AsikViewModel
                    {
                        Usuarios = Obj_Usuario.Select(s => s.usu).FirstOrDefault(),
                        Rol_Usuario = Obj_Usuario.Select(s => s.ru).ToList(),
                        LstRol = await GetRol()
                    };
                return null;
            }
            catch (Exception ex)
            {
                return new AsikViewModel { errorMetodo = ex.Message };
            }
        }
        public async Task<AsikViewModel> Fac_Cont_Ot(int Ord_codotc)
        {
            try
            {
                var OTList = await (from ot in _context.Ord_Trabajo
                                    join cli in _context.Clientes on ot.Ord_Codcli equals cli.CliIdenti
                                    join cal in _context.Calendario on ot.Ord_Codotc equals cal.Codigo_Ot
                                    join usu in _context.Usuarios on cal.Codi_Tec equals usu.UsuIdenti
                                    join tp in _context.TipPago on ot.Ord_Tippag equals tp.TipCodigo
                                    join ta in _context.Tip_alcance on ot.Ord_Talcod equals ta.Tip_alcodi
                                    where ot.Ord_Codotc == Ord_codotc
                                    orderby ot.Ord_Codotc descending
                                    select new { ot, cli, usu, tp, ta }).ToListAsync();
                if (OTList.Count > 0)
                    return new AsikViewModel
                    {
                        Ord_Trabajo = OTList.Select(s => s.ot).ToList(),
                        Clientes = OTList.Select(s => s.cli).ToList(),
                        Usuarios = OTList.Select(s => s.usu).FirstOrDefault(),
                        TipPago = OTList.Select(s => s.tp).ToList(),
                        TipAlcance = OTList.Select(s => s.ta).ToList(),
                        Fac_Cont = await _context.Fac_Cont.Where(w => w.Fac_OrdCod == OTList.FirstOrDefault().ot.Ord_Codotc).ToListAsync()
                    };
                return null;
            }
            catch (Exception ex)
            {
                return new AsikViewModel { errorMetodo = ex.Message };
            }
        }
        public async Task<Clientes> GetCliente(int Cli_Identi)
        {
            return await _context.Clientes.Where(w => w.CliIdenti == Cli_Identi).FirstOrDefaultAsync();
        }
        public async Task<bool> GetAtestacion(int codOT)
        {
            try
            {
                Ord_Trabajo ord_trabajo = await (from ot in _context.Ord_Trabajo
                                                 join rv in _context.Rev_DocOt on ot.Ord_Codotc equals rv.Rev_CodOt
                                                 join i in _context.Inspeccion on ot.Ord_Codotc equals i.Insp_Codot
                                                 where ot.Ord_Codotc == codOT && i.Insp_Dic_Dictec != false
                                                 select ot).FirstOrDefaultAsync();
                if (ord_trabajo != null)
                {
                    ord_trabajo.Ord_Estado = 9;
                    _context.Ord_Trabajo.Update(ord_trabajo).Property(p => p.Ord_Codigo).IsModified = false;
                    await _context.SaveChangesAsync();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public async Task<Usuarios> GetTecnico(int codOT)
        {
            return await _context.Usuarios.Where(
                w => w.UsuIdenti == _context.Calendario.Where(w => w.Codigo_Ot == codOT).Select(s => s.Codi_Tec).FirstOrDefault()
                ).FirstOrDefaultAsync();
        }
        public async Task<AsikViewModel> Env_DictSave(Env_Dictamen env_Dictamen)
        {
            try
            {
                env_Dictamen.Env_Fecha = DateTime.Now;
                await _context.Env_Dictamen.AddAsync(env_Dictamen);

                var OT = await _context.Ord_Trabajo.Where(w => w.Ord_Codotc == env_Dictamen.Env_Codot).FirstOrDefaultAsync();
                OT.Ord_Estado = 7;

                await _context.SaveChangesAsync();
                return new AsikViewModel { successMetodo = "Dictamen emitido exitosamente" };
            }
            catch (Exception ex)
            {
                return new AsikViewModel { errorMetodo = ex.InnerException.Message };
            }
        }
    }
}