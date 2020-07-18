using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AsikWeb.Models.Entidades
{
   public partial class Herramientas_Usuarios
    {
        public int HerId { get; set; }
        public int Hercodigo { get; set; }
        public int Usu_identi { get; set; }
    }
}
