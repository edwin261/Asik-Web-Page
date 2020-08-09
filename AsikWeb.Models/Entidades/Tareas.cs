using System;
using System.Collections.Generic;

namespace AsikWeb.Models.Entidades
{
    public partial class Tareas
    {
        public Tareas()
        {
            CalCalendario = new HashSet<CalCalendario>();
        }

        public int TarCodigo { get; set; }
        public int? TarActcod { get; set; }
        public string TarNombre { get; set; }
        public int? TarPeriod { get; set; }
        public int? TarFechini { get; set; }
        public int? TarFechfin { get; set; }

        public virtual Actividad TarActcodNavigation { get; set; }
        public virtual Periocidad TarPeriodNavigation { get; set; }
        public virtual ICollection<CalCalendario> CalCalendario { get; set; }
    }
}
