using arquetipo.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace arquetipo.Repository.Configuration
{
    internal class SolicitudConfiguration : IEntityTypeConfiguration<Solicitud>
    {
        public void Configure(EntityTypeBuilder<Solicitud> builder)
        {
            builder.HasKey(e => e.IdSolicitud);

            builder.Property(e => e.Entrada).HasColumnType("decimal(18, 2)");

            builder.Property(e => e.FechaCreacion).HasColumnType("datetime");

            builder.Property(e => e.Observacion)
                .HasMaxLength(1024)
                .IsUnicode(false);

            builder.HasOne(d => d.Cliente)
                .WithMany(p => p.Solicituds)
                .HasForeignKey(d => d.IdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Solicitud_Cliente");

            builder.HasOne(d => d.Ejecutivo)
                .WithMany(p => p.Solicituds)
                .HasForeignKey(d => d.IdEjecutivo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Solicitud_Ejecutivo");

            builder.HasOne(d => d.EstadoSolicitud)
                .WithMany(p => p.Solicituds)
                .HasForeignKey(d => d.IdEstadoSolicitud)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Solicitud_EstadoSolicitud");

            builder.HasOne(d => d.Vehiculo)
                .WithMany(p => p.Solicituds)
                .HasForeignKey(d => d.IdVehiculo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Solicitud_Vehiculo");
        }
    }
}
