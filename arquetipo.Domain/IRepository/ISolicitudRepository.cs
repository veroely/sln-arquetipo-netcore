using arquetipo.Entity.Models;

namespace arquetipo.Domain.IRepository
{
    public interface ISolicitudRepository
    {
        Task<Solicitud> GetByClienteyFecha(int idCliente, DateTime fechaCreacion);
        Task<Solicitud> GetByIdVehiculo(int idVehiculo);
    }
}
