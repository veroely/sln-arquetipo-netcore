namespace arquetipo.Entity.Models
{
    public partial class ClientePatioVehicular
    {
        public int IdClientePatioVehicular { get; set; }
        public int IdCliente { get; set; }
        public int IdPatioVehicular { get; set; }
        public DateTime FechaCreacion { get; set; }

        public PatioVehicular PatioVehicular { get; set; } = null!;
        public Cliente Cliente { get; set; } = null!;
    }
}
