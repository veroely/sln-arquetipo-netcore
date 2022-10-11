using arquetipo.Entity.Models;

namespace arquetipo.Domain.Interfaces
{
    public interface IEjecutivoService
    {
        Task<List<Ejecutivo>> GetByIdPatio(int idPatio);
    }
}
