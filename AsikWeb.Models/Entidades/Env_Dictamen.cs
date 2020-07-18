using System;
using System.Collections.Generic;
using System.Text;

namespace AsikWeb.Models.Entidades
{
    public partial class Env_Dictamen
    {
        public int Env_Codigo { get; set; }
        public string Env_Nombre { get; set; }
        public string Env_Observa { get; set; }
        public int Env_Codot { get; set; }
        public string Env_NGuia { get; set; }
        public DateTime? Env_Fecha { get; set; }
    }
}
