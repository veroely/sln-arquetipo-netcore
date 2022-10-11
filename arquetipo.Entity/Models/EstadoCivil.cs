namespace arquetipo.Entity.Models
{
    public partial class EstadoCivil
    {
        public EstadoCivil()
        {
            Clientes = new HashSet<Cliente>();
        }

        public int IdEstadoCivil { get; set; }
        public string Descripcion { get; set; } = null!;
        public bool EsActivo { get; set; }

        public virtual ICollection<Cliente> Clientes { get; set; }
    }
}
