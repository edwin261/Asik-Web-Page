using System.Collections.Generic;

namespace AsikWeb.Models.Entidades
{
    public partial class Actividad
    {
        public Actividad()
        {
            Tareas = new HashSet<Tareas>();
        }

        public int ActCodigo { get; set; }
        public int? ActProcod { get; set; }
        public string ActNombre { get; set; }

        public virtual Proceso ActProcodNavigation { get; set; }
        public virtual ICollection<Tareas> Tareas { get; set; }
    }
}
