using arquetipo.Entity.Models;

namespace arquetipo.Domain.IRepository
{
    public interface IEjecutivoRepository
    {
        Task<List<Ejecutivo>> GetByIdPatio(int idPatio);
    }
}
