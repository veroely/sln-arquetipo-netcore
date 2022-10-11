using arquetipo.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace arquetipo.Repository.Configuration
{
    internal class EstadoCivilConfiguration : IEntityTypeConfiguration<EstadoCivil>
    {
        public void Configure(EntityTypeBuilder<EstadoCivil> builder)
        {
            builder.HasKey(e => e.IdEstadoCivil);

            builder.Property(e => e.Descripcion)
                .IsRequired()
                .HasMaxLength(64)
                .IsUnicode(false);
        }
    }
}
