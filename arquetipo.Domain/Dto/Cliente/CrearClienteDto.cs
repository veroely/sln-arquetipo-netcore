namespace arquetipo.Domain.Dto.Cliente
{
    public class CrearClienteDto
    {
        public string Identificacion { get; set; } = null!;
        public string Nombres { get; set; } = null!;
        public string Apellidos { get; set; } = null!;
        public DateTime FechaNacimiento { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
        public int IdEstadoCivil { get; set; }
        public bool SujetoCredito { get; set; }
    }
}
