using arquetipo.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arquetipo.Repository.Configuration
{
    internal class EjecutivoConfiguration : IEntityTypeConfiguration<Ejecutivo>
    {
        public void Configure(EntityTypeBuilder<Ejecutivo> builder)
        {
            builder.HasKey(e => e.IdEjecutivo);

            builder.Property(e => e.Apellidos)
                .IsRequired()
                .HasMaxLength(128)
                .IsUnicode(false);

            builder.Property(e => e.Celular)
                .HasMaxLength(16)
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

            builder.HasOne(d => d.PatioVehicular)
                .WithMany(p => p.Ejecutivos)
                .HasForeignKey(d => d.IdPatioVehicular)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Ejecutivo_PatioVehicular");
        }
    }
}
