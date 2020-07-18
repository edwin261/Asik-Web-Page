using System;
using System.Collections.Generic;
using System.Text;

namespace AsikWeb.Models.Entidades
{
    public partial class Rev_DocItem
    {
        public int Rev_Codigo { get; set; }
        public int Rev_CodDocItem { get; set; }
        public int Rev_TipAlcodi { get; set; }
        public int Rev_Item { get; set; }
        public string Rev_LisCheck { get; set; }
        public string Rev_DocCheck { get; set; }
        public bool Rev_Estado { get; set; }
        public int Rev_CodOt { get; set; }
        public string Rev_Descrip { get; set; }
    }
}
