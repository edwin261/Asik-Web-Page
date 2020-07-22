using System;
using System.Collections.Generic;
using System.Text;

namespace AsikWeb.Models.Entidades
{
    public partial class Rol_Direct
    {
        public int Rd_Codigo { get; set; }
        public int Rd_tipo { get; set; }
        public string Rd_Nombre { get; set; }

        public virtual Rol RdCodigoNavigation { get; set; }
    }
}
