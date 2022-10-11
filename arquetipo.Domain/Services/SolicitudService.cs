using arquetipo.Domain.Dto.Solicitud;
using arquetipo.Domain.Interfaces;
using arquetipo.Domain.IRepository;
using arquetipo.Entity.Models;
using System.Transactions;

namespace arquetipo.Domain.Services
{
    public class SolicitudService : ISolicitudService
    {
        private readonly IGenericRepository<Solicitud> _genericRepositorySolicitud;
        private readonly IGenericRepository<ClientePatioVehicular> _genericRepositoryClietePatioVehicular;
        private readonly IEstadoSolicitudRepository _estadoSolicitud;
        private readonly ISolicitudRepository _solicitudRepository;
        public SolicitudService(IGenericRepository<Solicitud> genericRepositorySolicitud
                                , IEstadoSolicitudRepository estadoSolicitud
                                , ISolicitudRepository solicitudRepository
                                , IGenericRepository<ClientePatioVehicular> genericRepositoryClietePatioVehicular)
        {
            _genericRepositorySolicitud = genericRepositorySolicitud;
            _estadoSolicitud = estadoSolicitud;
            _solicitudRepository = solicitudRepository;
            _genericRepositoryClietePatioVehicular = genericRepositoryClietePatioVehicular;
        }
        public async Task<int> Add(CrearSolicitudDto solicitudDto)
        {
            EstadoSolicitud estadoRegistrada = await _estadoSolicitud.GetByDescripcion("Registrada");
           
            //buscar si ya existe una solicitud el mismo día
            DateTime fechaHoy = DateTime.Today;
            Solicitud solicitudExistente = await _solicitudRepository.GetByClienteyFecha(solicitudDto.IdCliente, fechaHoy);
            if (solicitudExistente != null && solicitudExistente.IdEstadoSolicitud == estadoRegistrada.IdEstadoSolicitud)
            {
                throw new Exception("El Cliente ya tiene una solicitud registrada.");
            }

            ClientePatioVehicular clientePatioVehicular = new ClientePatioVehicular()
            {
                IdCliente = solicitudDto.IdCliente,
                IdPatioVehicular = solicitudDto.IdPatioVehicular,
                FechaCreacion = DateTime.Today
            };

            int respuesta = 0;
            using (TransactionScope scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                // Do Operation 1
                int resp = await _genericRepositoryClietePatioVehicular.Add(clientePatioVehicular);
                if (resp > 0 )
                {
                    //mappear los datos a la entidad
                    Solicitud solicitud = new Solicitud()
                    {
                        IdCliente = solicitudDto.IdCliente,
                        IdPatioVehicular = solicitudDto.IdPatioVehicular,
                        IdEjecutivo = solicitudDto.IdEjecutivo,
                        IdVehiculo = solicitudDto.IdVehiculo,
                        Cuotas = solicitudDto.Cuotas,
                        PlazoMeses = solicitudDto.PlazoMeses,
                        Entrada = solicitudDto.Entrada,
                        Observacion = solicitudDto.Observacion,
                        IdEstadoSolicitud = estadoRegistrada.IdEstadoSolicitud,
                        FechaCreacion = fechaHoy
                    };

                    // Do Operation 2
                    respuesta = await _genericRepositorySolicitud.Add(solicitud);
                }

                // if all the coperations complete successfully, this would be called and commit the trabsaction. 
                // In case of an exception, it wont be called and transaction is rolled back
                scope.Complete();
            }

            return respuesta;
        }

        public async Task<int> Update(Solicitud solicitud)
        {
            Solicitud solicitudExistente = await _genericRepositorySolicitud.Get(solicitud.IdSolicitud);
            if (solicitudExistente != null)
            {
                solicitudExistente.IdCliente = solicitud.IdCliente;
                solicitudExistente.IdVehiculo = solicitud.IdVehiculo;
                solicitudExistente.IdEstadoSolicitud = solicitud.IdSolicitud;

                return await _genericRepositorySolicitud.Update(solicitudExistente);
            }
            else 
            {
                throw new Exception("La solicitud no existe");
            }
        }

        public async Task<Solicitud> Get(int id)
        {
            Solicitud  solicitud = await _genericRepositorySolicitud.Get(id);
            return solicitud;
        }
    }
}
