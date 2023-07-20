using marsev.Initializer;
using marsev.Models;
using Microsoft.EntityFrameworkCore;

namespace marsev.Context
{
    public class MMDbContext : DbContext
    {

        public MMDbContext(DbContextOptions<MMDbContext> options) : base(options)
        {
            
        }

       protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            DataInitializer.Seed(modelBuilder);
            //modelBuilder.Entity<OrderDetail>().Ignore("ID");
            //modelBuilder.Entity<OrderDetail>().HasKey("OrderID","ProductID");
        }

        public DbSet<Etkinlik> Etkinlikler { get; set; }
        public DbSet<Kitap> Kitaplar { get; set; }

        public DbSet<AppUser> Users { get; set; }

        public DbSet<Kayit> Kayitlar { get; set; }  
        public DbSet<FormModel> İletisimFormu { get; set; }
        public DbSet<KitapTalepModel> KitapTalepleri { get;set; }

    }
}
