namespace arquetipo.Entity.Models
{
    public partial class Vehiculo
    {
        public Vehiculo()
        {
            Solicituds = new HashSet<Solicitud>();
        }

        public int IdVehiculo { get; set; }
        public string Placa { get; set; } = null!;
        public string Modelo { get; set; } = null!;
        public string NumeroChasis { get; set; } = null!;
        public int IdMarcaVehicular { get; set; }
        public string? Tipo { get; set; }
        public int Cilindraje { get; set; }
        public decimal Avaluo { get; set; }

        public virtual MarcaVehicular MarcaVehicular { get; set; } = null!;
        public virtual ICollection<Solicitud> Solicituds { get; set; }
    }
}
