using arquetipo.Domain.Dto.Vehiculo;
using arquetipo.Domain.Interfaces;
using arquetipo.Domain.IRepository;
using arquetipo.Entity.Models;

namespace arquetipo.Domain.Services
{
    public class VehiculoService : IVehiculoService
    {
        private readonly IGenericRepository<Vehiculo> _genericRepositoryVehiculo;
        private readonly IVehiculoRepository _vehiculoRepository;
        private readonly ISolicitudRepository _solicitudRepository;

        public VehiculoService(IGenericRepository<Vehiculo> genericRepositoryVehiculo
                            ,IVehiculoRepository vehiculoRepository
                            ,ISolicitudRepository solicitudRepository)
        {
            _genericRepositoryVehiculo = genericRepositoryVehiculo;
            _vehiculoRepository = vehiculoRepository;
            _solicitudRepository = solicitudRepository;
        }

        public async Task<int> Add(CrearVehiculoDto vehiculoDto)
        {
            //consultar si ya existe un vehiculo con la misma placa
            Vehiculo vehiculoExistente = await _vehiculoRepository.GetByPlaca(vehiculoDto.Placa);
            if (vehiculoExistente != null)
            {
                throw new Exception("La existe un vehículo registrado con el número de placa" + vehiculoDto.Placa);
            }

            Vehiculo vehiculo = new Vehiculo()
            {
                Placa = vehiculoDto.Placa,
                Modelo = vehiculoDto.Modelo,
                NumeroChasis = vehiculoDto.NumeroChasis,
                IdMarcaVehicular = vehiculoDto.IdMarcaVehicular,
                Tipo = vehiculoDto.Tipo,
                Cilindraje = vehiculoDto.Cilindraje,
                Avaluo = vehiculoDto.Avaluo
            };

            return await _genericRepositoryVehiculo.Add(vehiculo);
        }

        public async Task<int> Delete(int id)
        {
            //buscar si existe el vehículo
            Vehiculo vehiculo = await _genericRepositoryVehiculo.Get(id);
            if(vehiculo == null)
            {
                throw new Exception("El vehículo no existe");
            }

            //verificar que el vehicul no este asociado a una soliciud
            Solicitud solicitud = await _solicitudRepository.GetByIdVehiculo(id);
            if(solicitud != null)
            {
                throw new Exception("No es posible eliminar el vehículo porque existe datos asociados");
            }

            return await _genericRepositoryVehiculo.Delete(id);
        }

        public async Task<Vehiculo> Get(int id)
        {
            return await _genericRepositoryVehiculo.Get(id);
        }

        public async Task<List<Vehiculo>> GetAll()
        {
            return await _genericRepositoryVehiculo.GetAll();
        }

        public async Task<int> Update(Vehiculo vehiculo)
        {
            return await _genericRepositoryVehiculo.Update(vehiculo);
        }
        public async Task<List<Vehiculo>> GetByMarcaModelo(string marca, string modelo, string anio)
        {
            return await _vehiculoRepository.GetByMarcaModelo(marca, modelo, anio);
        }
    }
}
