namespace arquetipo.Domain.Dto.Vehiculo
{
    public class CrearVehiculoDto
    {
        public string Placa { get; set; } = null!;
        public string Modelo { get; set; } = null!;
        public string NumeroChasis { get; set; } = null!;
        public int IdMarcaVehicular { get; set; }
        public string? Tipo { get; set; }
        public int Cilindraje { get; set; }
        public decimal Avaluo { get; set; }
    }
}
