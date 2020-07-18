using System;
using System.Collections.Generic;
using System.Text;

namespace AsikWeb.Models.ViewModels
{
    public class LoginViewModel
    {
        public static int Cod_Usu { get; set; }
        public static string Nom_Usu { get; set; }
        public static List<string> Rol_Nom { get; set; }
        public static List<int> Rol_Cod { get; set; }
    }
}
