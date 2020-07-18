using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AsikWeb.Models.Helpers;

namespace AsikWeb.Models.Helpers
{
    public class AsikWebHelpers
    {
        #region Estado validacion de metodos
        public string Message { get; set; }
        public bool Status { get; set; }
        #endregion

        #region Rol de usuario
        public int User_Rol { get; set; }
        #endregion
    }
}
