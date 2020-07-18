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
        public string TarPeriod { get; set; }
        public int? TarRespon { get; set; }
        public string TarRegist { get; set; }

        public virtual Actividad TarActcodNavigation { get; set; }
        public virtual ICollection<CalCalendario> CalCalendario { get; set; }
    }
}
