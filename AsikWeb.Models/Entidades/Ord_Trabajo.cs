using System;
using System.Collections.Generic;
using System.Text;

namespace AsikWeb.Models.Entidades
{
    public partial class Ord_Trabajo
    {
        public int Ord_Codigo { get; set; }
        public string Ord_Prefot { get; set; }
        public int Ord_Codotc { get; set; }
        public string Ord_Nomproy { get; set; }
        public int Ord_Tippag { get; set; }
        public int Ord_Canvis { get; set; }
        public int Ord_Revdoc { get; set; }
        public int Ord_Alccod { get; set; }
        public int Ord_Talcod { get; set; }
        public int Ord_Codcli { get; set; }
        public string Ord_Nomcad { get; set; }
        public int Ord_Telcad { get; set; }
        public string Ord_Emacad { get; set; }
        public DateTime Ord_Feccre { get; set; }
        public int Ord_Usucre { get; set; }
        public DateTime? Ord_Fecmod { get; set; }
        public int Ord_Usumod { get; set; }
        public DateTime Ord_Fecfin { get; set; }
        public int Ord_Estado { get; set; }
        public DateTime Ord_Fec90 { get; set; }
        public string Ord_Celcad { get; set; }
        public int Ord_Canvis_Rest { get; set; }
        public int Ord_RevDoc_Rest { get; set; }
        public int Ord_Cantalc { get; set; }
        public int Ord_Codsed { get; set; }
    }
}
