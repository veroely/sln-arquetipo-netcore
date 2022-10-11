using arquetipo.Domain.IRepository;
using arquetipo.Entity.Models;
using arquetipo.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace arquetipo.Infrastructure.Services
{
    public class EstadoSolicitudRepository : IEstadoSolicitudRepository
    {
        private readonly db_creditoautoContext _context;
        public EstadoSolicitudRepository(db_creditoautoContext context)
        {
            _context = context;
        }
        public async Task<EstadoSolicitud> GetByDescripcion(string descripcion)
        {
            EstadoSolicitud estadoSolicitud = await _context.EstadoSolicituds.Where(s => s.Descripcion == descripcion).FirstOrDefaultAsync();
            return estadoSolicitud;
        }
    }
}
