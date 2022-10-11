using arquetipo.Entity.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace arquetipo.Repository.Context
{
    public class db_creditoautoContext : DbContext
    {
        public db_creditoautoContext()
        {
        }
        public db_creditoautoContext(DbContextOptions<db_creditoautoContext> options)
            : base(options)
        {

        }

        public virtual DbSet<Cliente> Clientes { get; set; } = null!;
        public virtual DbSet<ClientePatioVehicular> ClientePatioVehiculars { get; set; } = null!;
        public virtual DbSet<Conyuge> Conyuges { get; set; } = null!;
        public virtual DbSet<Ejecutivo> Ejecutivos { get; set; } = null!;
        public virtual DbSet<EstadoCivil> EstadoCivils { get; set; } = null!;
        public virtual DbSet<EstadoSolicitud> EstadoSolicituds { get; set; } = null!;
        public virtual DbSet<MarcaVehicular> MarcaVehiculars { get; set; } = null!;
        public virtual DbSet<PatioVehicular> PatioVehiculars { get; set; } = null!;
        public virtual DbSet<Solicitud> Solicituds { get; set; } = null!;
        public virtual DbSet<Vehiculo> Vehiculos { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
