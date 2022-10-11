using arquetipo.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace arquetipo.Repository.Configuration
{
    internal class EstadoSolicitudConfiguration : IEntityTypeConfiguration<EstadoSolicitud>
    {
        public void Configure(EntityTypeBuilder<EstadoSolicitud> builder)
        {
            builder.HasKey(e => e.IdEstadoSolicitud);

            builder.Property(e => e.Descripcion)
                .IsRequired()
                .HasMaxLength(64)
                .IsUnicode(false);
        }
    }
}
