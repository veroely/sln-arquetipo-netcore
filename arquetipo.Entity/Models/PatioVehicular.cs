namespace arquetipo.Entity.Models
{
    public partial class PatioVehicular
    {
        public PatioVehicular()
        {
            ClientePatioVehiculars = new HashSet<ClientePatioVehicular>();
            Ejecutivos = new HashSet<Ejecutivo>();
        }

        public int IdPatioVehicular { get; set; }
        public string Nombre { get; set; } = null!;
        public string Direccion { get; set; } = null!;
        public string Telefono { get; set; } = null!;
        public int NumeroPuntoVenta { get; set; }

        public virtual ICollection<ClientePatioVehicular> ClientePatioVehiculars { get; set; }
        public virtual ICollection<Ejecutivo> Ejecutivos { get; set; }
    }
}
