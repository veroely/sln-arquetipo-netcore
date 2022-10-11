using arquetipo.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace arquetipo.Repository.Configuration
{
    public class ClientePatioVehicularConfiguration : IEntityTypeConfiguration<ClientePatioVehicular>
    {
        public void Configure(EntityTypeBuilder<ClientePatioVehicular> builder)
        {
            builder.HasKey(e => e.IdClientePatioVehicular);

            builder.Property(e => e.FechaCreacion).HasColumnType("datetime");
            builder.HasOne(e => e.PatioVehicular)
                .WithMany().HasForeignKey(bd => bd.IdPatioVehicular)
                .OnDelete(DeleteBehavior.ClientSetNull);

            builder.HasOne(e => e.Cliente)
                .WithMany().HasForeignKey(bd => bd.IdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull);

            builder.HasOne(d => d.PatioVehicular)
                .WithMany(p => p.ClientePatioVehiculars)
                .HasForeignKey(d => d.IdPatioVehicular)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ClientePatioVehicular_PatioVehicular");
        }
    }
}
