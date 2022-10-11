using arquetipo.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace arquetipo.Repository.Configuration
{
    internal class VehiculoConfiguration : IEntityTypeConfiguration<Vehiculo>
    {
        public void Configure(EntityTypeBuilder<Vehiculo> builder)
        {
            builder.HasKey(e => e.IdVehiculo);

            builder.Property(e => e.Avaluo).HasColumnType("decimal(18, 2)");

            builder.Property(e => e.Modelo)
                .IsRequired()
                .HasMaxLength(64)
                .IsUnicode(false);

            builder.Property(e => e.NumeroChasis)
                .IsRequired()
                .HasMaxLength(32)
                .IsUnicode(false);

            builder.Property(e => e.Placa)
                .IsRequired()
                .HasMaxLength(64)
                .IsUnicode(false);

            builder.Property(e => e.Tipo)
                .HasMaxLength(128)
                .IsUnicode(false);

            builder.HasOne(d => d.MarcaVehicular)
                .WithMany(p => p.Vehiculos)
                .HasForeignKey(d => d.IdMarcaVehicular)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Vehiculo_MarcaVehicular");
        }
    }
}
