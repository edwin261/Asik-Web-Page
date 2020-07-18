using System;
using System.Collections.Generic;
using System.Text;

namespace AsikWeb.Models.Entidades
{
    public partial class Tiem_Insp
    {
        public int TiemCod { get; set; }
        public int TiemCod_Insp { get; set; }
        public DateTime TiemIni { get; set; }
        public DateTime? TiemFin { get; set; }
        public string Tiemtot { get; set; }
    }
}
