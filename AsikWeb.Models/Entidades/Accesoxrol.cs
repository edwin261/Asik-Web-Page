
namespace AsikWeb.Models.Entidades
{
    public partial class Accesoxrol
    {
        public int AccCodigo { get; set; }
        public string AccNomunic { get; set; }
        public int? AccCodunic { get; set; }
        public int? AccCodpag { get; set; }
        public int? AccCodrol { get; set; }

        public virtual Rol AccCodrolNavigation { get; set; }
    }
}
