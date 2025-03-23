using Microsoft.EntityFrameworkCore;
using web.Models;



namespace WebApplication1.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=ABDRAKCIT;Initial Catalog=WebApp1;Integrated Security=True;Encrypt=False");
            
        }

        public Context(DbContextOptions<Context> options) : base(options) { }


        public DbSet<AcilModel> AcilModels { get; set; }
        public DbSet<AsistanModel> AsistanModels { get; set; }
        public DbSet<BolumModel> BolumModels { get; set; }
        public DbSet<NobetModel> NobetModels { get; set; }
        public DbSet<OgretimModel> OgretimModels { get; set; }
        public DbSet<RandevuModel> RandevuModels { get; set; }
        public DbSet<IndexModel> IndexModels { get; set; }
        public DbSet<GirisModel> GirisModels { get; set; }

    }
}
