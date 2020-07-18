using System;
using System.Collections.Generic;
using System.Text;

namespace AsikWeb.Models.Entidades
{
    public partial class Tareas
    {
        public int Tar_Codigo { get; set; }
        public int Tar_ActCod { get; set; }
        public string Tar_Nombre { get; set; }
        public string Tar_Period { get; set; }
        public string Tar_Respon { get; set; }
        public string Tar_Regist { get; set; }
    }
}
