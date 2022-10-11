using arquetipo.Domain.Interfaces;
using arquetipo.Domain.IRepository;
using arquetipo.Entity.Models;

namespace arquetipo.Domain.Services
{
    public class EjecutivoService : IEjecutivoService
    {
        private readonly IEjecutivoRepository _ejecutivoRepossitory;

        public EjecutivoService(IEjecutivoRepository ejecutivoRepossitory)
        {
            _ejecutivoRepossitory = ejecutivoRepossitory;
        }

        public async Task<List<Ejecutivo>> GetByIdPatio(int idPatio)
        {
            List<Ejecutivo> lista = await _ejecutivoRepossitory.GetByIdPatio(idPatio);
            return lista;
        }
    }
}
