namespace arquetipo.Entity.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            Solicituds = new HashSet<Solicitud>();
        }

        public int IdCliente { get; set; }
        public string Identificacion { get; set; } = null!;
        public string Nombres { get; set; } = null!;
        public string Apellidos { get; set; } = null!;
        public DateTime FechaNacimiento { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
        public int IdEstadoCivil { get; set; }
        public int? IdConyuge { get; set; }
        public bool SujetoCredito { get; set; }
        public virtual EstadoCivil EstadoCivil { get; set; } = null!;
        public virtual ICollection<Solicitud> Solicituds { get; set; }
    }
}
