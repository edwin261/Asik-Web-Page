using System;
using System.Collections.Generic;
using System.Text;

namespace AsikWeb.Models.Entidades
{
    public partial class Rev_Noaprov
    {
        public int Rev_Codigo { get; set; }
        public int Rev_CodOt { get; set; }
        public int Rev_TipAlcodi { get; set; }
        public string Rev_DocCheck { get; set; }
        public int Rev_Numrev { get; set; }
    }
}