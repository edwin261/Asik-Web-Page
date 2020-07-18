using System;

namespace AsikWeb.Models.Entidades
{
    public partial class CalCalendario
    {
        public int CalCodigo { get; set; }
        public int? CalTarcod { get; set; }
        public DateTime? CalFeccre { get; set; }
        public string CalObser { get; set; }
        public DateTime? CalFecprog { get; set; }
        public DateTime? CalFecven { get; set; }
        public bool? CalReprog { get; set; }
        public DateTime? CalFecreprog { get; set; }
        public DateTime? CalFecreal { get; set; }
        public string CalRutarc { get; set; }
        public string CalColor { get; set; }

        public virtual Tareas CalTarcodNavigation { get; set; }
    }
}
