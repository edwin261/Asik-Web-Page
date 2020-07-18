using System;
using System.Collections.Generic;
using System.Text;

namespace AsikWeb.Models.Entidades
{
    public partial class Proceso
    {
        public Proceso()
        {
            Actividad = new HashSet<Actividad>();
        }

        public int ProCodigo { get; set; }
        public string ProNombre { get; set; }

        public virtual ICollection<Actividad> Actividad { get; set; }
    }
}
