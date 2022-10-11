using arquetipo.Domain.IRepository;
using arquetipo.Entity.Models;
using arquetipo.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace arquetipo.Infrastructure.Services
{
    public class SolicitudRepository : ISolicitudRepository
    {
        private readonly db_creditoautoContext _context;
        public SolicitudRepository(db_creditoautoContext context)
        {
            _context = context;
        }
        public async Task<Solicitud> GetByClienteyFecha(int idCliente, DateTime fechaCreacion)
        {
            Solicitud solicitud = await _context.Solicituds.Where(w => w.IdCliente == idCliente
                                                            && w.FechaCreacion.Date == fechaCreacion.Date).FirstOrDefaultAsync();
            return solicitud;
        }

        public async Task<Solicitud> GetByIdVehiculo(int idVehiculo)
        {
            Solicitud solicitud = await _context.Solicituds.Where(w => w.IdVehiculo == idVehiculo).FirstOrDefaultAsync();
            return solicitud;
        }
    }
}
