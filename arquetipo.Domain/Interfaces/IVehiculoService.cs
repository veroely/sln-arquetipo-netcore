using arquetipo.Domain.Dto.Vehiculo;
using arquetipo.Entity.Models;

namespace arquetipo.Domain.Interfaces
{
    public interface IVehiculoService
    {
        Task<int> Add(CrearVehiculoDto vehiculoDto);
        Task<Vehiculo> Get(int id);
        Task<List<Vehiculo>> GetAll();
        Task<int> Update(Vehiculo vehiculo);
        Task<int> Delete(int id);
        Task<List<Vehiculo>> GetByMarcaModelo(string marca, string modelo, string anio);
    }
}
