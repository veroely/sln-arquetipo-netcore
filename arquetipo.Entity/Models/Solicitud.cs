namespace arquetipo.Entity.Models
{
    public partial class Solicitud
    {
        public int IdSolicitud { get; set; }
        public int IdCliente { get; set; }
        public int IdVehiculo { get; set; }
        public int IdPatioVehicular { get; set; }
        public int PlazoMeses { get; set; }
        public int Cuotas { get; set; }
        public decimal Entrada { get; set; }
        public int IdEjecutivo { get; set; }
        public string? Observacion { get; set; }
        public int IdEstadoSolicitud { get; set; }
        public DateTime FechaCreacion { get; set; }

        public virtual Cliente Cliente { get; set; } = null!;
        public virtual Ejecutivo Ejecutivo { get; set; } = null!;
        public virtual EstadoSolicitud EstadoSolicitud { get; set; } = null!;
        public virtual Vehiculo Vehiculo { get; set; } = null!;
    }
}
