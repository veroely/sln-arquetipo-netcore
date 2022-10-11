using arquetipo.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace arquetipo.Repository.Configuration
{
    internal class ConyugeConfiguracion : IEntityTypeConfiguration<Conyuge>
    {
        public void Configure(EntityTypeBuilder<Conyuge> builder)
        {
            builder.HasKey(e => e.IdConyuge);

            builder.Property(e => e.Identificacion)
                .IsRequired()
                .HasMaxLength(16)
                .IsUnicode(false);

            builder.Property(e => e.Nombre)
                .IsRequired()
                .HasMaxLength(528)
                .IsUnicode(false);
        }
    }
}
