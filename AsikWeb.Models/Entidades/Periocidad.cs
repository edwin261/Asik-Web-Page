using System.Collections.Generic;

namespace AsikWeb.Models.Entidades
{
    public partial class Periocidad
    {
        public Periocidad()
        {
            Tareas = new HashSet<Tareas>();
        }

        public int PerCodigo { get; set; }
        public string PerNombre { get; set; }

        public virtual ICollection<Tareas> Tareas { get; set; }
    }
}
