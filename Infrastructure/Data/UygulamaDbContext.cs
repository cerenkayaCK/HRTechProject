using HRTechProject.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Infrastructure.Data
{
    public class UygulamaDbContext : DbContext
    {
        public UygulamaDbContext(DbContextOptions<UygulamaDbContext> options) : base(options)
        {
        }
        public DbSet<Personel> Personeller { get; set; }
        public DbSet<Adres> Adresler { get; set; }
        public DbSet<Departman> Departmanlar { get; set; }
        public DbSet<Meslek> Meslekler { get; set; }
        public DbSet<Sirket> Sirketler { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
