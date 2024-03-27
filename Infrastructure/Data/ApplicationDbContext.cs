using HRTechProject.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HRTechProject.Data
{
    public class ApplicationDbContext : IdentityDbContext<Personel>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Sirket> Sirketler { get; set; }
        public DbSet<Meslek> Meslekler { get; set; }
        public DbSet<Departman> Departmanlar { get; set; }
        public DbSet<Adres> Adresler { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
 
            builder.Entity<Personel>()
              .Property(p => p.Maas)
              .HasColumnType("decimal(18,2)");
        }
    }
}
