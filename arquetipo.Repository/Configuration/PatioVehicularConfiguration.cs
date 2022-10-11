using arquetipo.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace arquetipo.Repository.Configuration
{
    internal class PatioVehicularConfiguration : IEntityTypeConfiguration<PatioVehicular>
    {
        public void Configure(EntityTypeBuilder<PatioVehicular> builder)
        {
            builder.HasKey(e => e.IdPatioVehicular);

            builder.Property(e => e.Direccion)
                .IsRequired()
                .HasMaxLength(256)
                .IsUnicode(false);

            builder.Property(e => e.Nombre)
                .IsRequired()
                .HasMaxLength(128)
                .IsUnicode(false);

            builder.Property(e => e.Telefono)
                .IsRequired()
                .HasMaxLength(16)
                .IsUnicode(false);
        }
    }
}
