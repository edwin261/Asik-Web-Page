using System;
using System.Collections.Generic;
using System.Text;

namespace AsikWeb.Models.Entidades
{
    public partial class Sedes_Cli
    {
        public int SeCodigo { get; set; }
        public int SeCliIden { get; set; }
        public int SeNumIden { get; set; }
        public int SeDigver { get; set; }
        public string SeNomSed { get; set; }
        public string SeNumTel { get; set; }
        public string SeDirecc { get; set; }
        public int? SeDepart { get; set; }
        public int? SeCiudad { get; set; }
    }
}
