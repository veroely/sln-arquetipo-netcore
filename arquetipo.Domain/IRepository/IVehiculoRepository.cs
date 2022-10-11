using arquetipo.Entity.Models;

namespace arquetipo.Domain.IRepository
{
    public interface IVehiculoRepository
    {
        Task<Vehiculo> GetByPlaca(string placa);
        Task<List<Vehiculo>> GetByMarcaModelo(string marca, string modelo, string anio);
    }
}
