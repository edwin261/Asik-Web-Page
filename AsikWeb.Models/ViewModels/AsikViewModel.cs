using AsikWeb.Models.Entidades;
using AsikWeb.Models.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace AsikWeb.Models.ViewModels
{
    public class AsikViewModel
    {

        public Usuarios Usuarios { get; set; }
        public List<Usuarios> LstUsuarios { get; set; }
        public Rol Rol { get; set; }
        public List<Rol> LstRol { get; set; }
        public List<Rol_Usuario> Rol_Usuario { get; set; }
        public List<TipPago> TipPago { get; set; }
        public List<Alcance> Alcance { get; set; }
        public List<Tip_alcance> TipAlcance { get; set; }
        public List<Ord_Trabajo> Ord_Trabajo { get; set; }
        public List<Clientes> Clientes { get; set; }
        public List<Estados> Estados { get; set; }
        public List<Calendario> Calendario { get; set; }
        public List<Deparcol> Deparcol { get; set; }
        public List<Munidep> Munidep { get; set; }
        public List<Herramientas> Herramientas { get; set; }
        public List<Herramientas_Usuarios> herramientas_Usuarios { get; set; }
        public List<Menu> Menu { get; set; }
        public Prog_Ot Prog_Ot { get; set; }
        public List<Fac_Cont> Fac_Cont { get; set; }
        public List<Inspeccion> inspeccion { get; set; }
        public List<Rev_DocItem> rev_DocItems { get; set; }
        public List<Rev_Documental> Rev_Documentals { get; set; }
        public List<Rev_DocOt> Rev_DocOt { get; set; }
        public Env_Dictamen Env_Dictamen { get; set; }
        public List<Dtec_Tipo> dtec_Tipo { get; set; }
        public List<Rol_Direct> rol_Direct { get; set; }
        public List<Tecn_Direc> Tecn_Direc { get; set; }
        public List<Rev_Noaprov> Rev_Noaprov { get; set; }
        public List<Sedes_Cli> Sedes_Cli { get; set; }
        public List<Tiem_Insp> Tiem_Insps { get; set; }
        public List<Proceso> Procesos { get; set; }
        public List<Actividad> Actividades { get; set; }
        public List<Tareas> Tareas { get; set; }
        public List<CalCalendario> calCalendarios { get; set; }
        public Periocidad Periocidad { get; set; }

        #region mensajes de validacion
        public string errorMetodo { get; set; }
        public string successMetodo { get; set; }
        public bool IsFacturada { get; set; }
        #endregion
    }
}
