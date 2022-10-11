using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace arquetipo.Repository.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Conyuges",
                columns: table => new
                {
                    IdConyuge = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Identificacion = table.Column<string>(type: "varchar(16)", unicode: false, maxLength: 16, nullable: false),
                    Nombre = table.Column<string>(type: "varchar(528)", unicode: false, maxLength: 528, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conyuges", x => x.IdConyuge);
                });

            migrationBuilder.CreateTable(
                name: "EstadoCivils",
                columns: table => new
                {
                    IdEstadoCivil = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "varchar(64)", unicode: false, maxLength: 64, nullable: false),
                    EsActivo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoCivils", x => x.IdEstadoCivil);
                });

            migrationBuilder.CreateTable(
                name: "EstadoSolicituds",
                columns: table => new
                {
                    IdEstadoSolicitud = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "varchar(64)", unicode: false, maxLength: 64, nullable: false),
                    EsActivo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoSolicituds", x => x.IdEstadoSolicitud);
                });

            migrationBuilder.CreateTable(
                name: "MarcaVehiculars",
                columns: table => new
                {
                    IdMarcaVehicular = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false),
                    EsActivo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarcaVehiculars", x => x.IdMarcaVehicular);
                });

            migrationBuilder.CreateTable(
                name: "PatioVehiculars",
                columns: table => new
                {
                    IdPatioVehicular = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    Direccion = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false),
                    Telefono = table.Column<string>(type: "varchar(16)", unicode: false, maxLength: 16, nullable: false),
                    NumeroPuntoVenta = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatioVehiculars", x => x.IdPatioVehicular);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    IdCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Identificacion = table.Column<string>(type: "varchar(16)", unicode: false, maxLength: 16, nullable: false),
                    Nombres = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    Apellidos = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "date", nullable: false),
                    Direccion = table.Column<string>(type: "varchar(528)", unicode: false, maxLength: 528, nullable: true),
                    Telefono = table.Column<string>(type: "varchar(16)", unicode: false, maxLength: 16, nullable: true),
                    IdEstadoCivil = table.Column<int>(type: "int", nullable: false),
                    IdConyuge = table.Column<int>(type: "int", nullable: true),
                    SujetoCredito = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.IdCliente);
                    table.ForeignKey(
                        name: "FK_Cliente_EstadoCivil",
                        column: x => x.IdEstadoCivil,
                        principalTable: "EstadoCivils",
                        principalColumn: "IdEstadoCivil");
                });

            migrationBuilder.CreateTable(
                name: "Vehiculos",
                columns: table => new
                {
                    IdVehiculo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Placa = table.Column<string>(type: "varchar(64)", unicode: false, maxLength: 64, nullable: false),
                    Modelo = table.Column<string>(type: "varchar(64)", unicode: false, maxLength: 64, nullable: false),
                    NumeroChasis = table.Column<string>(type: "varchar(32)", unicode: false, maxLength: 32, nullable: false),
                    IdMarcaVehicular = table.Column<int>(type: "int", nullable: false),
                    Tipo = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true),
                    Cilindraje = table.Column<int>(type: "int", nullable: false),
                    Avaluo = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculos", x => x.IdVehiculo);
                    table.ForeignKey(
                        name: "FK_Vehiculo_MarcaVehicular",
                        column: x => x.IdMarcaVehicular,
                        principalTable: "MarcaVehiculars",
                        principalColumn: "IdMarcaVehicular");
                });

            migrationBuilder.CreateTable(
                name: "Ejecutivos",
                columns: table => new
                {
                    IdEjecutivo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Identificacion = table.Column<string>(type: "varchar(16)", unicode: false, maxLength: 16, nullable: false),
                    Nombres = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    Apellidos = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "date", nullable: false),
                    Direccion = table.Column<string>(type: "varchar(528)", unicode: false, maxLength: 528, nullable: true),
                    Telefono = table.Column<string>(type: "varchar(16)", unicode: false, maxLength: 16, nullable: true),
                    Celular = table.Column<string>(type: "varchar(16)", unicode: false, maxLength: 16, nullable: true),
                    IdPatioVehicular = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ejecutivos", x => x.IdEjecutivo);
                    table.ForeignKey(
                        name: "FK_Ejecutivo_PatioVehicular",
                        column: x => x.IdPatioVehicular,
                        principalTable: "PatioVehiculars",
                        principalColumn: "IdPatioVehicular");
                });

            migrationBuilder.CreateTable(
                name: "ClientePatioVehiculars",
                columns: table => new
                {
                    IdClientePatioVehicular = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCliente = table.Column<int>(type: "int", nullable: false),
                    IdPatioVehicular = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientePatioVehiculars", x => x.IdClientePatioVehicular);
                    table.ForeignKey(
                        name: "FK_ClientePatioVehicular_PatioVehicular",
                        column: x => x.IdPatioVehicular,
                        principalTable: "PatioVehiculars",
                        principalColumn: "IdPatioVehicular");
                    table.ForeignKey(
                        name: "FK_ClientePatioVehiculars_Clientes_IdCliente",
                        column: x => x.IdCliente,
                        principalTable: "Clientes",
                        principalColumn: "IdCliente");
                });

            migrationBuilder.CreateTable(
                name: "Solicituds",
                columns: table => new
                {
                    IdSolicitud = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCliente = table.Column<int>(type: "int", nullable: false),
                    IdVehiculo = table.Column<int>(type: "int", nullable: false),
                    IdPatioVehicular = table.Column<int>(type: "int", nullable: false),
                    PlazoMeses = table.Column<int>(type: "int", nullable: false),
                    Cuotas = table.Column<int>(type: "int", nullable: false),
                    Entrada = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IdEjecutivo = table.Column<int>(type: "int", nullable: false),
                    Observacion = table.Column<string>(type: "varchar(1024)", unicode: false, maxLength: 1024, nullable: true),
                    IdEstadoSolicitud = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Solicituds", x => x.IdSolicitud);
                    table.ForeignKey(
                        name: "FK_Solicitud_Cliente",
                        column: x => x.IdCliente,
                        principalTable: "Clientes",
                        principalColumn: "IdCliente");
                    table.ForeignKey(
                        name: "FK_Solicitud_Ejecutivo",
                        column: x => x.IdEjecutivo,
                        principalTable: "Ejecutivos",
                        principalColumn: "IdEjecutivo");
                    table.ForeignKey(
                        name: "FK_Solicitud_EstadoSolicitud",
                        column: x => x.IdEstadoSolicitud,
                        principalTable: "EstadoSolicituds",
                        principalColumn: "IdEstadoSolicitud");
                    table.ForeignKey(
                        name: "FK_Solicitud_Vehiculo",
                        column: x => x.IdVehiculo,
                        principalTable: "Vehiculos",
                        principalColumn: "IdVehiculo");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClientePatioVehiculars_IdCliente",
                table: "ClientePatioVehiculars",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_ClientePatioVehiculars_IdPatioVehicular",
                table: "ClientePatioVehiculars",
                column: "IdPatioVehicular");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_IdEstadoCivil",
                table: "Clientes",
                column: "IdEstadoCivil");

            migrationBuilder.CreateIndex(
                name: "IX_Ejecutivos_IdPatioVehicular",
                table: "Ejecutivos",
                column: "IdPatioVehicular");

            migrationBuilder.CreateIndex(
                name: "IX_Solicituds_IdCliente",
                table: "Solicituds",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Solicituds_IdEjecutivo",
                table: "Solicituds",
                column: "IdEjecutivo");

            migrationBuilder.CreateIndex(
                name: "IX_Solicituds_IdEstadoSolicitud",
                table: "Solicituds",
                column: "IdEstadoSolicitud");

            migrationBuilder.CreateIndex(
                name: "IX_Solicituds_IdVehiculo",
                table: "Solicituds",
                column: "IdVehiculo");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_IdMarcaVehicular",
                table: "Vehiculos",
                column: "IdMarcaVehicular");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientePatioVehiculars");

            migrationBuilder.DropTable(
                name: "Conyuges");

            migrationBuilder.DropTable(
                name: "Solicituds");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Ejecutivos");

            migrationBuilder.DropTable(
                name: "EstadoSolicituds");

            migrationBuilder.DropTable(
                name: "Vehiculos");

            migrationBuilder.DropTable(
                name: "EstadoCivils");

            migrationBuilder.DropTable(
                name: "PatioVehiculars");

            migrationBuilder.DropTable(
                name: "MarcaVehiculars");
        }
    }
}
