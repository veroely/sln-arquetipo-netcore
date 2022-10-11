namespace arquetipo.Domain.Dto.Solicitud
{
    public class CrearSolicitudDto
    {
        public int IdCliente { get; set; }
        public int IdVehiculo { get; set; }
        public int IdPatioVehicular { get; set; }
        public int PlazoMeses { get; set; }
        public int Cuotas { get; set; }
        public decimal Entrada { get; set; }
        public int IdEjecutivo { get; set; }
        public string? Observacion { get; set; }
    }
}
