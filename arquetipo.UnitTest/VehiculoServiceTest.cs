using arquetipo.Domain.Interfaces;
using arquetipo.Domain.IRepository;
using arquetipo.Domain.Services;
using arquetipo.Entity.Models;
using arquetipo.UnitTest.MockRepository;
using Moq;
using System;
using Xunit;

namespace arquetipo.UnitTest
{
    public class VehiculoServiceTest
    {
        private IVehiculoService _vehiculoService; 
        public VehiculoServiceTest()
        {
            Mock<IGenericRepository<Vehiculo>> genericRepositoryVehiculo = new GenericRepositoryVehiculoMock()._genericRepositoryVehiculo;
            Mock<IVehiculoRepository> vehiculoRepository = new Mock<IVehiculoRepository>();
            Mock<ISolicitudRepository> solicitudRepository = new SolicitudRepositoryMock()._solicitudRepository;
            _vehiculoService = new VehiculoService(genericRepositoryVehiculo.Object
                                                    , vehiculoRepository.Object
                                                    , solicitudRepository.Object);
        }

        [Fact]
        public void DeleteVehiculo_CuandoNoExisteId_RetornarExcepcion()
        {
            int idVehiculo = 2;
            var excepcion = Assert.ThrowsAsync<Exception>(() => _vehiculoService.Delete(idVehiculo));
            Assert.NotNull(excepcion.Result.Message);

        }

        [Fact]
        public void DeleteVehiculo_CuandoTieneSolicitudes_RetornarExcepcion()
        {
            int idVehiculo = 1;
            var excepcion = Assert.ThrowsAsync<Exception>(() => _vehiculoService.Delete(idVehiculo));
            Assert.Equal("No es posible eliminar el vehículo porque existe datos asociados", excepcion.Result.Message);
        }
    }
}
