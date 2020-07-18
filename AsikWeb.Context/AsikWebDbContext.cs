using Microsoft.EntityFrameworkCore;

namespace AsikWeb.Context
{
    public class AsikWebDbContext : DbContext
    {
        public AsikWebDbContext(DbContextOptions<AsikWebDbContext> options) : base(options)
        {

        }
        //Code First 
        //public DbSet<LoginViewModel> LoginViewModel { get; set; }
    }
}
