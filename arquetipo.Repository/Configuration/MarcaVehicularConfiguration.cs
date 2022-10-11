using arquetipo.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace arquetipo.Repository.Configuration
{
    internal class MarcaVehicularConfiguration : IEntityTypeConfiguration<MarcaVehicular>
    {
        public void Configure(EntityTypeBuilder<MarcaVehicular> builder)
        {
            builder.HasKey(e => e.IdMarcaVehicular);

            builder.Property(e => e.Descripcion)
                .IsRequired()
                .HasMaxLength(256)
                .IsUnicode(false);
        }
    }
}
