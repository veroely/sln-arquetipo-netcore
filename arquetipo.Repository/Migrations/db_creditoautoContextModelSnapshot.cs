﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using arquetipo.Repository.Context;

#nullable disable

namespace arquetipo.Repository.Migrations
{
    [DbContext(typeof(db_creditoautoContext))]
    partial class db_creditoautoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("arquetipo.Entity.Models.Cliente", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCliente"), 1L, 1);

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasMaxLength(128)
                        .IsUnicode(false)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Direccion")
                        .HasMaxLength(528)
                        .IsUnicode(false)
                        .HasColumnType("varchar(528)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("date");

                    b.Property<int?>("IdConyuge")
                        .HasColumnType("int");

                    b.Property<int>("IdEstadoCivil")
                        .HasColumnType("int");

                    b.Property<string>("Identificacion")
                        .IsRequired()
                        .HasMaxLength(16)
                        .IsUnicode(false)
                        .HasColumnType("varchar(16)");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasMaxLength(128)
                        .IsUnicode(false)
                        .HasColumnType("varchar(128)");

                    b.Property<bool>("SujetoCredito")
                        .HasColumnType("bit");

                    b.Property<string>("Telefono")
                        .HasMaxLength(16)
                        .IsUnicode(false)
                        .HasColumnType("varchar(16)");

                    b.HasKey("IdCliente");

                    b.HasIndex("IdEstadoCivil");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("arquetipo.Entity.Models.ClientePatioVehicular", b =>
                {
                    b.Property<int>("IdClientePatioVehicular")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdClientePatioVehicular"), 1L, 1);

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime");

                    b.Property<int>("IdCliente")
                        .HasColumnType("int");

                    b.Property<int>("IdPatioVehicular")
                        .HasColumnType("int");

                    b.HasKey("IdClientePatioVehicular");

                    b.HasIndex("IdCliente");

                    b.HasIndex("IdPatioVehicular");

                    b.ToTable("ClientePatioVehiculars");
                });

            modelBuilder.Entity("arquetipo.Entity.Models.Conyuge", b =>
                {
                    b.Property<int>("IdConyuge")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdConyuge"), 1L, 1);

                    b.Property<string>("Identificacion")
                        .IsRequired()
                        .HasMaxLength(16)
                        .IsUnicode(false)
                        .HasColumnType("varchar(16)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(528)
                        .IsUnicode(false)
                        .HasColumnType("varchar(528)");

                    b.HasKey("IdConyuge");

                    b.ToTable("Conyuges");
                });

            modelBuilder.Entity("arquetipo.Entity.Models.Ejecutivo", b =>
                {
                    b.Property<int>("IdEjecutivo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEjecutivo"), 1L, 1);

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasMaxLength(128)
                        .IsUnicode(false)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Celular")
                        .HasMaxLength(16)
                        .IsUnicode(false)
                        .HasColumnType("varchar(16)");

                    b.Property<string>("Direccion")
                        .HasMaxLength(528)
                        .IsUnicode(false)
                        .HasColumnType("varchar(528)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("date");

                    b.Property<int>("IdPatioVehicular")
                        .HasColumnType("int");

                    b.Property<string>("Identificacion")
                        .IsRequired()
                        .HasMaxLength(16)
                        .IsUnicode(false)
                        .HasColumnType("varchar(16)");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasMaxLength(128)
                        .IsUnicode(false)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Telefono")
                        .HasMaxLength(16)
                        .IsUnicode(false)
                        .HasColumnType("varchar(16)");

                    b.HasKey("IdEjecutivo");

                    b.HasIndex("IdPatioVehicular");

                    b.ToTable("Ejecutivos");
                });

            modelBuilder.Entity("arquetipo.Entity.Models.EstadoCivil", b =>
                {
                    b.Property<int>("IdEstadoCivil")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEstadoCivil"), 1L, 1);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(64)
                        .IsUnicode(false)
                        .HasColumnType("varchar(64)");

                    b.Property<bool>("EsActivo")
                        .HasColumnType("bit");

                    b.HasKey("IdEstadoCivil");

                    b.ToTable("EstadoCivils");
                });

            modelBuilder.Entity("arquetipo.Entity.Models.EstadoSolicitud", b =>
                {
                    b.Property<int>("IdEstadoSolicitud")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEstadoSolicitud"), 1L, 1);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(64)
                        .IsUnicode(false)
                        .HasColumnType("varchar(64)");

                    b.Property<bool>("EsActivo")
                        .HasColumnType("bit");

                    b.HasKey("IdEstadoSolicitud");

                    b.ToTable("EstadoSolicituds");
                });

            modelBuilder.Entity("arquetipo.Entity.Models.MarcaVehicular", b =>
                {
                    b.Property<int>("IdMarcaVehicular")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdMarcaVehicular"), 1L, 1);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(256)
                        .IsUnicode(false)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EsActivo")
                        .HasColumnType("bit");

                    b.HasKey("IdMarcaVehicular");

                    b.ToTable("MarcaVehiculars");
                });

            modelBuilder.Entity("arquetipo.Entity.Models.PatioVehicular", b =>
                {
                    b.Property<int>("IdPatioVehicular")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPatioVehicular"), 1L, 1);

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(256)
                        .IsUnicode(false)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(128)
                        .IsUnicode(false)
                        .HasColumnType("varchar(128)");

                    b.Property<int>("NumeroPuntoVenta")
                        .HasColumnType("int");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(16)
                        .IsUnicode(false)
                        .HasColumnType("varchar(16)");

                    b.HasKey("IdPatioVehicular");

                    b.ToTable("PatioVehiculars");
                });

            modelBuilder.Entity("arquetipo.Entity.Models.Solicitud", b =>
                {
                    b.Property<int>("IdSolicitud")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdSolicitud"), 1L, 1);

                    b.Property<int>("Cuotas")
                        .HasColumnType("int");

                    b.Property<decimal>("Entrada")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime");

                    b.Property<int>("IdCliente")
                        .HasColumnType("int");

                    b.Property<int>("IdEjecutivo")
                        .HasColumnType("int");

                    b.Property<int>("IdEstadoSolicitud")
                        .HasColumnType("int");

                    b.Property<int>("IdPatioVehicular")
                        .HasColumnType("int");

                    b.Property<int>("IdVehiculo")
                        .HasColumnType("int");

                    b.Property<string>("Observacion")
                        .HasMaxLength(1024)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1024)");

                    b.Property<int>("PlazoMeses")
                        .HasColumnType("int");

                    b.HasKey("IdSolicitud");

                    b.HasIndex("IdCliente");

                    b.HasIndex("IdEjecutivo");

                    b.HasIndex("IdEstadoSolicitud");

                    b.HasIndex("IdVehiculo");

                    b.ToTable("Solicituds");
                });

            modelBuilder.Entity("arquetipo.Entity.Models.Vehiculo", b =>
                {
                    b.Property<int>("IdVehiculo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdVehiculo"), 1L, 1);

                    b.Property<decimal>("Avaluo")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Cilindraje")
                        .HasColumnType("int");

                    b.Property<int>("IdMarcaVehicular")
                        .HasColumnType("int");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasMaxLength(64)
                        .IsUnicode(false)
                        .HasColumnType("varchar(64)");

                    b.Property<string>("NumeroChasis")
                        .IsRequired()
                        .HasMaxLength(32)
                        .IsUnicode(false)
                        .HasColumnType("varchar(32)");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasMaxLength(64)
                        .IsUnicode(false)
                        .HasColumnType("varchar(64)");

                    b.Property<string>("Tipo")
                        .HasMaxLength(128)
                        .IsUnicode(false)
                        .HasColumnType("varchar(128)");

                    b.HasKey("IdVehiculo");

                    b.HasIndex("IdMarcaVehicular");

                    b.ToTable("Vehiculos");
                });

            modelBuilder.Entity("arquetipo.Entity.Models.Cliente", b =>
                {
                    b.HasOne("arquetipo.Entity.Models.EstadoCivil", "EstadoCivil")
                        .WithMany("Clientes")
                        .HasForeignKey("IdEstadoCivil")
                        .IsRequired()
                        .HasConstraintName("FK_Cliente_EstadoCivil");

                    b.Navigation("EstadoCivil");
                });

            modelBuilder.Entity("arquetipo.Entity.Models.ClientePatioVehicular", b =>
                {
                    b.HasOne("arquetipo.Entity.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("IdCliente")
                        .IsRequired();

                    b.HasOne("arquetipo.Entity.Models.PatioVehicular", "PatioVehicular")
                        .WithMany("ClientePatioVehiculars")
                        .HasForeignKey("IdPatioVehicular")
                        .IsRequired()
                        .HasConstraintName("FK_ClientePatioVehicular_PatioVehicular");

                    b.Navigation("Cliente");

                    b.Navigation("PatioVehicular");
                });

            modelBuilder.Entity("arquetipo.Entity.Models.Ejecutivo", b =>
                {
                    b.HasOne("arquetipo.Entity.Models.PatioVehicular", "PatioVehicular")
                        .WithMany("Ejecutivos")
                        .HasForeignKey("IdPatioVehicular")
                        .IsRequired()
                        .HasConstraintName("FK_Ejecutivo_PatioVehicular");

                    b.Navigation("PatioVehicular");
                });

            modelBuilder.Entity("arquetipo.Entity.Models.Solicitud", b =>
                {
                    b.HasOne("arquetipo.Entity.Models.Cliente", "Cliente")
                        .WithMany("Solicituds")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_Solicitud_Cliente");

                    b.HasOne("arquetipo.Entity.Models.Ejecutivo", "Ejecutivo")
                        .WithMany("Solicituds")
                        .HasForeignKey("IdEjecutivo")
                        .IsRequired()
                        .HasConstraintName("FK_Solicitud_Ejecutivo");

                    b.HasOne("arquetipo.Entity.Models.EstadoSolicitud", "EstadoSolicitud")
                        .WithMany("Solicituds")
                        .HasForeignKey("IdEstadoSolicitud")
                        .IsRequired()
                        .HasConstraintName("FK_Solicitud_EstadoSolicitud");

                    b.HasOne("arquetipo.Entity.Models.Vehiculo", "Vehiculo")
                        .WithMany("Solicituds")
                        .HasForeignKey("IdVehiculo")
                        .IsRequired()
                        .HasConstraintName("FK_Solicitud_Vehiculo");

                    b.Navigation("Cliente");

                    b.Navigation("Ejecutivo");

                    b.Navigation("EstadoSolicitud");

                    b.Navigation("Vehiculo");
                });

            modelBuilder.Entity("arquetipo.Entity.Models.Vehiculo", b =>
                {
                    b.HasOne("arquetipo.Entity.Models.MarcaVehicular", "MarcaVehicular")
                        .WithMany("Vehiculos")
                        .HasForeignKey("IdMarcaVehicular")
                        .IsRequired()
                        .HasConstraintName("FK_Vehiculo_MarcaVehicular");

                    b.Navigation("MarcaVehicular");
                });

            modelBuilder.Entity("arquetipo.Entity.Models.Cliente", b =>
                {
                    b.Navigation("Solicituds");
                });

            modelBuilder.Entity("arquetipo.Entity.Models.Ejecutivo", b =>
                {
                    b.Navigation("Solicituds");
                });

            modelBuilder.Entity("arquetipo.Entity.Models.EstadoCivil", b =>
                {
                    b.Navigation("Clientes");
                });

            modelBuilder.Entity("arquetipo.Entity.Models.EstadoSolicitud", b =>
                {
                    b.Navigation("Solicituds");
                });

            modelBuilder.Entity("arquetipo.Entity.Models.MarcaVehicular", b =>
                {
                    b.Navigation("Vehiculos");
                });

            modelBuilder.Entity("arquetipo.Entity.Models.PatioVehicular", b =>
                {
                    b.Navigation("ClientePatioVehiculars");

                    b.Navigation("Ejecutivos");
                });

            modelBuilder.Entity("arquetipo.Entity.Models.Vehiculo", b =>
                {
                    b.Navigation("Solicituds");
                });
#pragma warning restore 612, 618
        }
    }
}
