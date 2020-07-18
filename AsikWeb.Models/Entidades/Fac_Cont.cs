using System;
using System.Collections.Generic;
using System.Text;

namespace AsikWeb.Models.Entidades
{
    public partial class Fac_Cont
    {
        public int Fac_Codigo { get; set; }
        public int Fac_OrdCod { get; set; }
        public bool Fac_FacVer { get; set; }
        public DateTime? Fac_Fechfa { get; set; }
        public bool Fac_Conver { get; set; }
        public DateTime? Fac_Feccon { get; set; }
    }
}
