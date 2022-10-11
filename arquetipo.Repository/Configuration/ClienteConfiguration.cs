using arquetipo.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace arquetipo.Repository.Configuration
{
    internal class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(e => e.IdCliente);

            builder.Property(e => e.Apellidos)
                .IsRequired()
                .HasMaxLength(128)
                .IsUnicode(false);

            builder.Property(e => e.Direccion)
                .HasMaxLength(528)
                .IsUnicode(false);

            builder.Property(e => e.FechaNacimiento).HasColumnType("date");

            builder.Property(e => e.Identificacion)
                .IsRequired()
                .HasMaxLength(16)
                .IsUnicode(false);

            builder.Property(e => e.Nombres)
                .IsRequired()
                .HasMaxLength(128)
                .IsUnicode(false);

            builder.Property(e => e.Telefono)
                .HasMaxLength(16)
                .IsUnicode(false);

            builder.HasOne(d => d.EstadoCivil)
                .WithMany(p => p.Clientes)
                .HasForeignKey(d => d.IdEstadoCivil)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Cliente_EstadoCivil");
        }
    }
}
