using Microsoft.EntityFrameworkCore;

namespace AsikWeb.Models.Entidades
{
    public partial class ASIK_PGWEB_Context : DbContext
    {
        public ASIK_PGWEB_Context()
        {
        }
        public ASIK_PGWEB_Context(DbContextOptions<ASIK_PGWEB_Context> options)
            : base(options)
        {
        }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<Alcance> Alcance { get; set; }
        public virtual DbSet<Munidep> Munidep { get; set; }
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<Deparcol> Deparcol { get; set; }
        public virtual DbSet<Estados> Estados { get; set; }
        public virtual DbSet<Herramientas> Herramientas { get; set; }
        public virtual DbSet<Herramientas_Usuarios> Herramientas_Usuarios { get; set; }
        public virtual DbSet<Ord_Trabajo> Ord_Trabajo { get; set; }
        public virtual DbSet<Rol> Rol { get; set; }
        public virtual DbSet<Rol_Usuario> Rol_Usuario { get; set; }
        public virtual DbSet<Tip_alcance> Tip_alcance { get; set; }
        public virtual DbSet<TipPago> TipPago { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<Calendario> Calendario { get; set; }
        public virtual DbSet<Prog_Ot> Prog_Ot { get; set; }
        public virtual DbSet<Fac_Cont> Fac_Cont { get; set; }
        public virtual DbSet<Inspeccion> Inspeccion { get; set; }
        public virtual DbSet<Rev_DocItem> Rev_DocItem { get; set; }
        public virtual DbSet<Rev_Documental> Rev_Documentals { get; set; }
        public virtual DbSet<Rev_DocOt> Rev_DocOt { get; set; }
        public virtual DbSet<Env_Dictamen> Env_Dictamen { get; set; }
        public virtual DbSet<Dtec_Tipo> Dtec_Tipo { get; set; }
        public virtual DbSet<Rol_Direct> Rol_Direct { get; set; }
        public virtual DbSet<Tecn_Direc> Tecn_Direc { get; set; }
        public virtual DbSet<Rev_Noaprov> Rev_Noaprov { get; set; }
        public virtual DbSet<Sedes_Cli> Sedes_Cli { get; set; }
        public virtual DbSet<Tiem_Insp> Tiem_Insps { get; set; }
        public virtual DbSet<Actividad> Actividad { get; set; }
        public virtual DbSet<CalCalendario> CalCalendario { get; set; }
        public virtual DbSet<Periocidad> Periocidad { get; set; }
        public virtual DbSet<Proceso> Proceso { get; set; }
        public virtual DbSet<Tareas> Tareas { get; set; }
        public virtual DbSet<Accesoxrol> Accesoxrol { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity<Prog_Ot>(entity =>
            {
                entity.HasKey(e => e.Prog_Cod);

                entity.ToTable("PROG_OT");

                entity.Property(e => e.Prog_CodOt).HasColumnName("PROG_CODOT");

                entity.Property(e => e.Prog_CodTec).HasColumnName("PROG_CODTEC");

                entity.Property(e => e.Pro_Plan_Imp).HasColumnName("PRO_PLAN_IMP");

                entity.Property(e => e.Prog_Fech).HasColumnName("PROG_FECH");

            });

            modelBuilder.Entity<Dtec_Tipo>(entity =>
            {
                entity.HasKey(e => e.Dtec_Codigo);

                entity.ToTable("DTEC_TIPO");

                entity.Property(e => e.Dtec_Codigo).HasColumnName("DTEC_CODIGO");

                entity.Property(e => e.Dtec_IdUsua).HasColumnName("DTEC_IDUSUA");

                entity.Property(e => e.Dtec_Rdtipo).HasColumnName("DTEC_RDTIPO");
            });

            modelBuilder.Entity<Rol_Direct>(entity =>
            {
                entity.HasKey(e => e.Rd_Codigo);

                entity.ToTable("ROL_DIRECT");

                entity.Property(e => e.Rd_Codigo).HasColumnName("RD_CODIGO");

                entity.Property(e => e.Rd_Nombre).HasColumnName("RD_NOMBRE");

                entity.Property(e => e.Rd_tipo).HasColumnName("RD_TIPO");
            });

            modelBuilder.Entity<Tecn_Direc>(entity =>
            {
                entity.HasKey(e => e.Tecn_Codigo);

                entity.ToTable("TECN_DIREC");

                entity.Property(e => e.Tecn_Codigo).HasColumnName("TECN_CODIGO");

                entity.Property(e => e.Usu_Identi).HasColumnName("USU_IDENTI");

                entity.Property(e => e.Dtec_Codigo).HasColumnName("DTEC_CODIGO");
            });

            modelBuilder.Entity<Env_Dictamen>(entity =>
            {
                entity.HasKey(e => e.Env_Codigo);

                entity.ToTable("ENV_DICTAMEN");

                entity.Property(e => e.Env_Codigo).HasColumnName("ENV_CODIGO");

                entity.Property(e => e.Env_Nombre).HasColumnName("ENV_NOMBRE");

                entity.Property(e => e.Env_Observa).HasColumnName("ENV_OBSERVA");

                entity.Property(e => e.Env_Codot).HasColumnName("ENV_CODOT");

                entity.Property(e => e.Env_NGuia).HasColumnName("ENV_NGUIA");

                entity.Property(e => e.Env_Fecha).HasColumnName("ENV_FECHA");
            });

            modelBuilder.Entity<Rev_DocOt>(entity =>
            {
                entity.HasKey(e => e.Rev_Codigo);

                entity.ToTable("REV_DOCOT");

                entity.Property(e => e.Rev_Codigo)
                    .HasColumnName("REV_CODIGO")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Rev_CodOt).HasColumnName("REV_COD_OT");

                entity.Property(e => e.Rev_Observ).HasColumnName("REV_OBSERV");

                entity.Property(e => e.Rev_FecCre).HasColumnName("REV_FECRE");
            });

            modelBuilder.Entity<Rev_DocItem>(entity =>
            {
                entity.HasKey(e => e.Rev_Codigo);

                entity.ToTable("REV_DOCITEM");

                entity.Property(e => e.Rev_Codigo).HasColumnName("REV_CODIGO");

                entity.Property(e => e.Rev_CodDocItem).HasColumnName("REV_CODDOCITEM");

                entity.Property(e => e.Rev_TipAlcodi).HasColumnName("REV_TIPALCODI");

                entity.Property(e => e.Rev_Item).HasColumnName("REV_ITEM");

                entity.Property(e => e.Rev_LisCheck).HasColumnName("REV_LISCHECK");

                entity.Property(e => e.Rev_DocCheck).HasColumnName("REV_DOCCHECK");

                entity.Property(e => e.Rev_Estado).HasColumnName("REV_ESTADO");

                entity.Property(e => e.Rev_CodOt).HasColumnName("REV_CODOT");

                entity.Property(e => e.Rev_Descrip).HasColumnName("REV_DESCRIP");

            });

            modelBuilder.Entity<Rev_Noaprov>(entity =>
            {
                entity.HasKey(e => e.Rev_Codigo);

                entity.ToTable("REV_NOAPRO");

                entity.Property(e => e.Rev_Codigo).HasColumnName("REV_CODIGO");

                entity.Property(e => e.Rev_CodOt).HasColumnName("REV_CODOT");

                entity.Property(e => e.Rev_TipAlcodi).HasColumnName("REV_TIPALCODI");

                entity.Property(e => e.Rev_DocCheck).HasColumnName("REV_DOCCHECK");

                entity.Property(e => e.Rev_Numrev).HasColumnName("REV_NUMREV");

            });

            modelBuilder.Entity<Rev_Documental>(entity =>
            {
                entity.HasKey(e => e.Rev_Codigo);

                entity.ToTable("REV_DOCUMENTAL");

                entity.Property(e => e.Rev_Codigo).HasColumnName("REV_CODIGO");

                entity.Property(e => e.Rev_Tipalcod).HasColumnName("REV_TIPALCOD");

                entity.Property(e => e.Rev_Item).HasColumnName("REV_ITEM");

                entity.Property(e => e.Rev_LisCheck).HasColumnName("REV_LISCHECK");

                entity.Property(e => e.Rev_DocCheck).HasColumnName("REV_DOCCHECK");

            });

            modelBuilder.Entity<Alcance>(entity =>
            {
                entity.HasKey(e => e.AlcCodigo)
                    .HasName("PK__ALCANCE__9242A0AB01AFBA6A");

                entity.ToTable("ALCANCE");

                entity.Property(e => e.AlcCodigo).HasColumnName("ALC_CODIGO");

                entity.Property(e => e.AlcNombre)
                    .HasColumnName("ALC_NOMBRE")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Munidep>(entity =>
            {
                entity.HasKey(e => e.Ciu_Codigo);

                entity.ToTable("MUNIDEP");

                entity.Property(e => e.Ciu_Codigo).HasColumnName("CIU_CODIGO");

                entity.Property(e => e.Ciu_Coddep).HasColumnName("CIU_CODDEP");

                entity.Property(e => e.Ciu_Id).HasColumnName("CIU_ID");

                entity.Property(e => e.Ciu_Nombre).HasColumnName("CIU_NOMBRE");
            });

            modelBuilder.Entity<Clientes>(entity =>
            {
                entity.HasKey(e => e.CliIdenti)
                    .HasName("PK__CLIENTES__B535665A80506BBF");

                entity.ToTable("CLIENTES");

                entity.Property(e => e.CliIdenti)
                    .HasColumnName("CLI_IDENTI")
                    .ValueGeneratedNever();

                entity.Property(e => e.CiuCodigo).HasColumnName("CIU_CODIGO");

                entity.Property(e => e.CliCodigo)
                    .HasColumnName("CLI_CODIGO")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CliDirecc)
                    .HasColumnName("CLI_DIRECC")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CliDverif).HasColumnName("CLI_DVERIF");

                entity.Property(e => e.CliNombre)
                    .HasColumnName("CLI_NOMBRE")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CliTelefo).HasColumnName("CLI_TELEFO");

                entity.Property(e => e.DepCodigo).HasColumnName("DEP_CODIGO");
            });

            modelBuilder.Entity<Sedes_Cli>(entity =>
            {
                entity.HasKey(e => e.SeCodigo);

                entity.ToTable("SEDES_CLI");

                entity.Property(e => e.SeCodigo)
                    .HasColumnName("SECODIGO")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SeCliIden)
                    .HasColumnName("SECLIIDEN");

                entity.Property(e => e.SeNumIden).HasColumnName("SENUMIDEN");

                entity.Property(e => e.SeDigver)
                    .HasColumnName("SEDIGVER");

                entity.Property(e => e.SeNomSed)
                    .HasColumnName("SENOMSED");

                entity.Property(e => e.SeNumTel)
                    .HasColumnName("SENUMTEL");

                entity.Property(e => e.SeDirecc)
                    .HasColumnName("SEDIRECC");

                entity.Property(e => e.SeDepart).HasColumnName("SEDEPART");

                entity.Property(e => e.SeCiudad).HasColumnName("SECIUDAD");
            });

            modelBuilder.Entity<Deparcol>(entity =>
            {
                entity.HasKey(e => e.Dep_Codigo);

                entity.ToTable("DEPARCOL");

                entity.Property(e => e.Dep_Codigo).HasColumnName("DEP_CODIGO");

                entity.Property(e => e.Dep_Id).HasColumnName("DEP_ID");

                entity.Property(e => e.Dep_Nombre).HasColumnName("DEP_NOMBRE");
            });

            modelBuilder.Entity<Estados>(entity =>
            {
                entity.HasKey(e => e.EstCodigo)
                    .HasName("PK__ESTADOS__6FBFC200AA334B56");

                entity.ToTable("ESTADOS");

                entity.Property(e => e.EstCodigo).HasColumnName("EST_CODIGO");

                entity.Property(e => e.EstNombre)
                    .HasColumnName("EST_NOMBRE")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Herramientas>(entity =>
            {
                entity.HasKey(e => e.HerCodigo)
                    .HasName("PK__HERRAMIE__79A3AD1FE11DE412");

                entity.ToTable("HERRAMIENTAS");

                entity.Property(e => e.HerCodigo).HasColumnName("HER_CODIGO");

                entity.Property(e => e.HerMarca)
                    .HasColumnName("HER_MARCA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HerNombre)
                    .HasColumnName("HER_NOMBRE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HerNumser)
                    .HasColumnName("HER_NUMSER")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HerObser)
                    .HasColumnName("HER_OBSER")
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Rol>(entity =>
            {
                entity.HasKey(e => e.RolCodigo)
                    .HasName("PK__ROL__6A87FB9BD38B2FAA");

                entity.ToTable("ROL");

                entity.Property(e => e.RolCodigo).HasColumnName("ROL_CODIGO");

                entity.Property(e => e.RolNombre)
                    .HasColumnName("ROL_NOMBRE")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Rol_Usuario>(entity =>
            {
                entity.HasKey(e => e.RolId);

                entity.ToTable("ROL_USUARIOS");

                entity.Property(e => e.RolId).HasColumnName("ROL_ID");

                entity.Property(e => e.RolCodigo).HasColumnName("ROL_CODIGO");

                entity.Property(e => e.UsuIdenti).HasColumnName("USU_IDENTI");

                entity.Property(e => e.MenCodigo).HasColumnName("MEN_CODIGO");
            });

            modelBuilder.Entity<Herramientas_Usuarios>(entity =>
            {
                entity.HasKey(e => e.HerId);

                entity.ToTable("HERRAMIENTAS_USUARIOS");

                entity.Property(e => e.HerId).HasColumnName("HER_ID");

                entity.Property(e => e.Hercodigo).HasColumnName("HER_CODIGO");

                entity.Property(e => e.Usu_identi).HasColumnName("USU_IDENTI");
            });

            modelBuilder.Entity<TipPago>(entity =>
            {
                entity.HasKey(e => e.TipCodigo)
                    .HasName("PK__TIP_PAGO__D19A5E689AC745DB");

                entity.ToTable("TIP_PAGO");

                entity.Property(e => e.TipCodigo).HasColumnName("TIP_CODIGO");

                entity.Property(e => e.TipEstado).HasColumnName("TIP_ESTADO");

                entity.Property(e => e.TipNombre)
                    .HasColumnName("TIP_NOMBRE")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.HasKey(e => e.UsuIdenti)
                    .HasName("PK__USUARIOS__69270547DF080C9D");

                entity.ToTable("USUARIOS");

                entity.Property(e => e.UsuIdenti)
                    .HasColumnName("USU_IDENTI")
                    .ValueGeneratedNever();

                entity.Property(e => e.UsuApelli)
                    .IsRequired()
                    .HasColumnName("USU_APELLI")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.UsuCodigo)
                    .HasColumnName("USU_CODIGO")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.UsuContra)
                    .IsRequired()
                    .HasColumnName("USU_CONTRA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuNombre)
                   .IsRequired()
                   .HasColumnName("USU_NOMBRE")
                   .HasMaxLength(70)
                   .IsUnicode(false);

                entity.Property(e => e.UsuEmail)
                    .HasColumnName("USU_EMAIL");

                entity.Property(e => e.UsuEstad)
                    .HasColumnName("USU_ESTAD");
            });

            modelBuilder.Entity<Tip_alcance>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TIP_ALCANCE");

                entity.Property(e => e.Tip_alcodi)
                    .HasColumnName("TIP_ALCODI");

                entity.Property(e => e.Alc_codigo)
                    .HasColumnName("ALC_CODIGO");

                entity.Property(e => e.Tip_alnomb)
                    .HasColumnName("TIP_ALNOMB");

                entity.Property(e => e.Tip_alcant)
                    .HasColumnName("TIP_ALCANT");
            });

            modelBuilder.Entity<Calendario>(entity =>
            {
                entity.HasKey(e => e.Cal_EventId);

                entity.ToTable("CALENDARIO");

                entity.Property(e => e.Cal_EventId).HasColumnName("CAL_EVENTID");

                entity.Property(e => e.Subjec)
                    .HasColumnName("SUBJEC");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION");

                entity.Property(e => e.Inicio)
                    .HasColumnName("INICIO")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fin)
                    .HasColumnName("FIN")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tod_Dia)
                    .HasColumnName("TOD_DIA");

                entity.Property(e => e.Codigo_Ot)
                    .HasColumnName("CODIGO_OT");

                entity.Property(e => e.Codi_Tec)
                    .HasColumnName("CODI_TEC");

                entity.Property(e => e.ThemeColor)
                    .HasColumnName("THEMECOLOR");

                entity.Property(e => e.Finalizado)
                    .HasColumnName("FINALIZADO");
            });

            modelBuilder.Entity<Ord_Trabajo>(entity =>
            {
                entity.ToTable("ORD_TRABAJO");
                entity.HasKey(x => new { x.Ord_Codigo });

                entity.Property(e => e.Ord_Codigo)
                    .HasColumnName("ORD_CODIGO");

                entity.Property(e => e.Ord_Prefot)
                    .HasColumnName("ORD_PREFOT");

                entity.Property(e => e.Ord_Codotc)
                    .HasColumnName("ORD_CODOTC");

                entity.Property(e => e.Ord_Nomproy)
                    .HasColumnName("ORD_NOMPROY");

                entity.Property(e => e.Ord_Tippag)
                    .HasColumnName("ORD_TIPPAG");

                entity.Property(e => e.Ord_Canvis)
                    .HasColumnName("ORD_CANVIS");

                entity.Property(e => e.Ord_Revdoc)
                    .HasColumnName("ORD_REVDOC");

                entity.Property(e => e.Ord_Alccod)
                    .HasColumnName("ORD_ALCCOD");

                entity.Property(e => e.Ord_Talcod)
                    .HasColumnName("ORD_TALCOD");

                entity.Property(e => e.Ord_Codcli)
                    .HasColumnName("ORD_CODCLI");

                entity.Property(e => e.Ord_Nomcad)
                    .HasColumnName("ORD_NOMCAD");

                entity.Property(e => e.Ord_Telcad)
                    .HasColumnName("ORD_TELCAD");

                entity.Property(e => e.Ord_Emacad)
                    .HasColumnName("ORD_EMACAD");

                entity.Property(e => e.Ord_Feccre)
                    .HasColumnName("ORD_FECCRE");

                entity.Property(e => e.Ord_Usucre)
                    .HasColumnName("ORD_USUCRE");

                entity.Property(e => e.Ord_Fecmod)
                    .HasColumnName("ORD_FECMOD");

                entity.Property(e => e.Ord_Usumod)
                    .HasColumnName("ORD_USUMOD");

                entity.Property(e => e.Ord_Fecfin)
                    .HasColumnName("ORD_FECFIN");

                entity.Property(e => e.Ord_Estado)
                    .HasColumnName("ORD_ESTADO");

                entity.Property(e => e.Ord_Fec90)
                    .HasColumnName("ORD_FEC90");

                entity.Property(e => e.Ord_Celcad)
                    .HasColumnName("ORD_CELCAD");

                entity.Property(e => e.Ord_Canvis_Rest)
                    .HasColumnName("ORD_CANVIS_REST");

                entity.Property(e => e.Ord_RevDoc_Rest)
                    .HasColumnName("ORD_REVDOC_REST");

                entity.Property(e => e.Ord_Cantalc)
                    .HasColumnName("ORD_CANTALC");

                entity.Property(e => e.Ord_Codsed)
                    .HasColumnName("ORD_CODSED");
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.HasKey(e => e.Men_Codigo);

                entity.ToTable("MENU");

                entity.Property(e => e.Men_Codigo).HasColumnName("MEN_CODIGO");

                entity.Property(e => e.Men_Nombre).HasColumnName("MEN_NOMBRE");

                entity.Property(e => e.Men_Url).HasColumnName("MEN_URL");

                entity.Property(e => e.Men_Img).HasColumnName("MEN_IMG");
            });

            modelBuilder.Entity<Fac_Cont>(entity =>
            {
                entity.HasKey(e => e.Fac_Codigo);

                entity.ToTable("FAC_CONT");

                entity.Property(e => e.Fac_Codigo).HasColumnName("FAC_CODIGO");

                entity.Property(e => e.Fac_OrdCod).HasColumnName("FAC_ORDCOD");

                entity.Property(e => e.Fac_FacVer).HasColumnName("FAC_FACVER");

                entity.Property(e => e.Fac_Fechfa).HasColumnName("FAC_FECHFA");

                entity.Property(e => e.Fac_Conver).HasColumnName("FAC_CONVER");

                entity.Property(e => e.Fac_Feccon).HasColumnName("FAC_FECCON");
            });

            modelBuilder.Entity<Inspeccion>(entity =>
            {
                entity.HasKey(e => e.Insp_Codigo);

                entity.ToTable("INSPECCION");

                entity.Property(e => e.Insp_Codigo).HasColumnName("INSP_CODIGO");

                entity.Property(e => e.Insp_Codot).HasColumnName("INSP_CODOT");

                entity.Property(e => e.Insp_Codtec).HasColumnName("INSP_CODTEC");

                entity.Property(e => e.Insp_Acept).HasColumnName("INSP_ACEPT");

                entity.Property(e => e.Insp_Inici).HasColumnName("INSP_INICI");

                entity.Property(e => e.Insp_Fin).HasColumnName("INSP_FIN");

                entity.Property(e => e.Insp_Ttotal).HasColumnName("INSP_TTOTAL");

                entity.Property(e => e.Insp_Con_Cam).HasColumnName("INSP_CON_CAM");

                entity.Property(e => e.Insp_Fecha).HasColumnName("INSP_FECHA");

                entity.Property(e => e.Insp_Final).HasColumnName("INSP_FINAL");

                entity.Property(e => e.Insp_Fefin).HasColumnName("INSP_FEFIN");

                entity.Property(e => e.Insp_Dic_Dictec).HasColumnName("INSP_DIC_DICTEC");

                entity.Property(e => e.Insp_Dic_Fecha).HasColumnName("INSP_DIC_FECHA");

                entity.Property(e => e.Insp_Observa).HasColumnName("INSP_OBSERVA");
            });

            modelBuilder.Entity<Tiem_Insp>(entity =>
            {
                entity.HasKey(e => e.TiemCod);

                entity.ToTable("TIEM_INSP");

                entity.Property(e => e.TiemCod).HasColumnName("TIEMCOD");

                entity.Property(e => e.TiemCod_Insp).HasColumnName("TIEMCOD_INSP");

                entity.Property(e => e.TiemIni).HasColumnName("TIEMINI");

                entity.Property(e => e.TiemFin).HasColumnName("TIEMFIN");

                entity.Property(e => e.Tiemtot).HasColumnName("TIEMTOT");

            });

            modelBuilder.Entity<Actividad>(entity =>
            {
                entity.HasKey(e => e.ActCodigo)
                    .HasName("PK__ACTIVIDA__A18C4B145CF999CA");

                entity.ToTable("ACTIVIDAD");

                entity.Property(e => e.ActCodigo).HasColumnName("ACT_CODIGO");

                entity.Property(e => e.ActNombre)
                    .HasColumnName("ACT_NOMBRE")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ActProcod).HasColumnName("ACT_PROCOD");

                entity.HasOne(d => d.ActProcodNavigation)
                    .WithMany(p => p.Actividad)
                    .HasForeignKey(d => d.ActProcod)
                    .HasConstraintName("FK__ACTIVIDAD__ACT_P__31B762FC");
            });

            modelBuilder.Entity<CalCalendario>(entity =>
            {
                entity.HasKey(e => e.CalCodigo);

                entity.ToTable("CAL_CALENDARIO");

                entity.Property(e => e.CalCodigo).HasColumnName("CAL_CODIGO");

                entity.Property(e => e.CalColor)
                    .HasColumnName("CAL_COLOR")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CalFeccre)
                    .HasColumnName("CAL_FECCRE")
                    .HasColumnType("datetime");

                entity.Property(e => e.CalFecprog)
                    .HasColumnName("CAL_FECPROG")
                    .HasColumnType("datetime");

                entity.Property(e => e.CalFecreal)
                    .HasColumnName("CAL_FECREAL")
                    .HasColumnType("datetime");

                entity.Property(e => e.CalFecreprog)
                    .HasColumnName("CAL_FECREPROG")
                    .HasColumnType("datetime");

                entity.Property(e => e.CalFecven)
                    .HasColumnName("CAL_FECVEN")
                    .HasColumnType("datetime");

                entity.Property(e => e.CalObser)
                    .HasColumnName("CAL_OBSER")
                    .HasMaxLength(300);

                entity.Property(e => e.CalReprog).HasColumnName("CAL_REPROG");

                entity.Property(e => e.CalRutarc)
                    .HasColumnName("CAL_RUTARC")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CalTarcod).HasColumnName("CAL_TARCOD");

                entity.HasOne(d => d.CalTarcodNavigation)
                    .WithMany(p => p.CalCalendario)
                    .HasForeignKey(d => d.CalTarcod)
                    .HasConstraintName("FK__CAL_CALEN__CAL_T__5E8A0973");
            });

            modelBuilder.Entity<Proceso>(entity =>
            {
                entity.HasKey(e => e.ProCodigo)
                    .HasName("PK__PROCESO__A78C2E8902605051");

                entity.ToTable("PROCESO");

                entity.Property(e => e.ProCodigo).HasColumnName("PRO_CODIGO");

                entity.Property(e => e.ProNombre)
                    .HasColumnName("PRO_NOMBRE")
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tareas>(entity =>
            {
                entity.HasKey(e => e.TarCodigo)
                    .HasName("PK__TAREAS__CE6AB93285BA450B");

                entity.ToTable("TAREAS");

                entity.Property(e => e.TarCodigo).HasColumnName("TAR_CODIGO");

                entity.Property(e => e.TarActcod).HasColumnName("TAR_ACTCOD");

                entity.Property(e => e.TarNombre)
                    .HasColumnName("TAR_NOMBRE")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.TarPeriod).HasColumnName("TAR_PERIOD");

                entity.Property(e => e.TarFechini).HasColumnName("TAR_FECHINI");

                entity.Property(e => e.TarFechfin).HasColumnName("TAR_FECHFIN");

                entity.HasOne(d => d.TarActcodNavigation)
                    .WithMany(p => p.Tareas)
                    .HasForeignKey(d => d.TarActcod)
                    .HasConstraintName("FK__TAREAS__TAR_ACTC__756D6ECB");

                entity.HasOne(d => d.TarPeriodNavigation)
                    .WithMany(p => p.Tareas)
                    .HasForeignKey(d => d.TarPeriod)
                    .HasConstraintName("FK__TAREAS__TAR_PERI__76619304");
            });

            modelBuilder.Entity<Periocidad>(entity =>
            {
                entity.HasKey(e => e.PerCodigo)
                    .HasName("PK__PERIOCID__AA2E668D5D2B2C34");

                entity.ToTable("PERIOCIDAD");

                entity.Property(e => e.PerCodigo).HasColumnName("PER_CODIGO");

                entity.Property(e => e.PerNombre)
                    .HasColumnName("PER_NOMBRE")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Accesoxrol>(entity =>
            {
                entity.HasKey(e => e.AccCodigo)
                    .HasName("PK__ACCESOXR__804E6CEB031CBCD6");

                entity.ToTable("ACCESOXROL");

                entity.Property(e => e.AccCodigo).HasColumnName("ACC_CODIGO");

                entity.Property(e => e.AccCodpag).HasColumnName("ACC_CODPAG");

                entity.Property(e => e.AccCodrol).HasColumnName("ACC_CODROL");

                entity.Property(e => e.AccCodunic).HasColumnName("ACC_CODUNIC");

                entity.Property(e => e.AccNomunic)
                    .HasColumnName("ACC_NOMUNIC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.AccCodrolNavigation)
                    .WithMany(p => p.Accesoxrol)
                    .HasForeignKey(d => d.AccCodrol)
                    .HasConstraintName("FK__ACCESOXRO__ACC_C__0880433F");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}