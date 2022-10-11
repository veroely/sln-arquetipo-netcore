using arquetipo.Domain.Dto.Solicitud;
using arquetipo.Entity.Models;

namespace arquetipo.Domain.Interfaces
{
    public interface ISolicitudService
    {
        Task<int> Add(CrearSolicitudDto solicitud);
        Task<int> Update(Solicitud solicitud);
        Task<Solicitud> Get(int id);
    }
}
