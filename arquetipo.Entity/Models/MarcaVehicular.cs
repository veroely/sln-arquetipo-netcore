namespace arquetipo.Entity.Models
{
    public partial class MarcaVehicular
    {
        public MarcaVehicular()
        {
            Vehiculos = new HashSet<Vehiculo>();
        }

        public int IdMarcaVehicular { get; set; }
        public string Descripcion { get; set; } = null!;
        public bool EsActivo { get; set; }

        public virtual ICollection<Vehiculo> Vehiculos { get; set; }
    }
}
