namespace arquetipo.Domain.Dto.PatioVehicular
{
    public class CrearPatioVehicularDto
    {
        public string Nombre { get; set; } = null!;
        public string Direccion { get; set; } = null!;
        public string Telefono { get; set; } = null!;
        public int NumeroPuntoVenta { get; set; }
    }
}
