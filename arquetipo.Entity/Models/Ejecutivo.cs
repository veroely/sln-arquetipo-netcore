namespace arquetipo.Entity.Models
{
    public partial class Ejecutivo
    {
        public Ejecutivo()
        {
            Solicituds = new HashSet<Solicitud>();
        }

        public int IdEjecutivo { get; set; }
        public string Identificacion { get; set; } = null!;
        public string Nombres { get; set; } = null!;
        public string Apellidos { get; set; } = null!;
        public DateTime FechaNacimiento { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
        public string? Celular { get; set; }
        public int IdPatioVehicular { get; set; }

        public virtual PatioVehicular PatioVehicular { get; set; } = null!;
        public virtual ICollection<Solicitud> Solicituds { get; set; }
    }
}
