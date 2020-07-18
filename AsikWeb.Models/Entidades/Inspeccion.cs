using System;
using System.Collections.Generic;
using System.Text;

namespace AsikWeb.Models.Entidades
{
    public partial class Inspeccion
    {
        public int Insp_Codigo { get; set; }
        public int Insp_Codot { get; set; }
        public int Insp_Codtec { get; set; }
        public bool Insp_Acept { get; set; }
        public DateTime? Insp_Inici { get; set; }
        public DateTime? Insp_Fin { get; set; }
        public string Insp_Ttotal { get; set; }
        public bool Insp_Con_Cam { get; set; }
        public DateTime? Insp_Fecha { get; set; }
        public bool Insp_Final { get; set; }
        public DateTime? Insp_Fefin { get; set; }
        public bool Insp_Dic_Dictec { get; set; }
        public DateTime? Insp_Dic_Fecha { get; set; }
        public string Insp_Observa { get; set; }
    }
}
