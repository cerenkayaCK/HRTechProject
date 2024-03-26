using HRTechProject.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Config
{
    public class PersonelConfiguration : IEntityTypeConfiguration<Personel>
    {
        public void Configure(EntityTypeBuilder<Personel> builder)
        {
            builder.Property(x => x.Ad).HasMaxLength(100);
            builder.Property(x => x.Soyad).HasMaxLength(100);
            builder.Property(x => x.TcNo).HasMaxLength(11);
            builder.Property(x => x.Maas).HasPrecision(18, 2);
        }
    }
}
