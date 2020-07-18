using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AsikWeb.Models.Entidades
{
    public partial class Calendario
    {
        public int Cal_EventId { get; set; }
        public string Subjec { get; set; }
        public string Descripcion { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Inicio { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Fin { get; set; }
        public bool Tod_Dia { get; set; }
        public int Codigo_Ot { get; set; }
        public int Codi_Tec { get; set; }
        public string ThemeColor { get; set; }
        public bool Finalizado { get; set; }
    }
}
