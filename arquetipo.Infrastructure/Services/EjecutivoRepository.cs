using arquetipo.Domain.IRepository;
using arquetipo.Entity.Models;
using arquetipo.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace arquetipo.Infrastructure.Services
{
    public class EjecutivoRepository : IEjecutivoRepository
    {
        private readonly db_creditoautoContext _context;
        public EjecutivoRepository(db_creditoautoContext context)
        {
            _context = context;
        }
        public async Task<List<Ejecutivo>> GetByIdPatio(int idPatio)
        {
            List<Ejecutivo> ejecutivos = await _context.Ejecutivos.Where(w => w.IdPatioVehicular == idPatio).ToListAsync();
            return ejecutivos;
        }
    }
}
