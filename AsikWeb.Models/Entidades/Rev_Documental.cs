using System;
using System.Collections.Generic;
using System.Text;

namespace AsikWeb.Models.Entidades
{
    public partial class Rev_Documental
    {
        public int Rev_Codigo { get; set; }
        public int Rev_Tipalcod { get; set; }
        public int Rev_Item { get; set; }
        public string Rev_LisCheck { get; set; }
        public string Rev_DocCheck { get; set; }
    }
}
