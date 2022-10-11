using arquetipo.Domain.Dto.Solicitud;
using arquetipo.Domain.Interfaces;
using arquetipo.Domain.IRepository;
using arquetipo.Domain.Services;
using arquetipo.Entity.Models;
using arquetipo.UnitTest.MockRepository;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;

namespace arquetipo.UnitTest
{
    public class SolicitudServiceTest
    {
        private readonly ISolicitudService _solicitudService;
        public SolicitudServiceTest()
        {
            Mock<IGenericRepository<Solicitud>> genericRepositorySolicitud = new GenericRepositorySolicitudMock()._genericRepositorySolicitud;
            Mock<IEstadoSolicitudRepository> estadoSolicitudRepository = new EstadoSolicitudRepositoryMock()._estadoSolicitudRepository;
            Mock<ISolicitudRepository> solicitudRepository = new SolicitudRepositoryMock()._solicitudRepository;
            _solicitudService = new SolicitudService(genericRepositorySolicitud.Object,
                                                        estadoSolicitudRepository.Object,
                                                        solicitudRepository.Object);
        }

        [Fact]
        public void GenerarSolicitud_MismoClienteYDia_EstadoRegistrada_RetornarExcepcion()
        {
           CrearSolicitudDto crearSolicitudDto = new CrearSolicitudDto()
            {
                IdCliente = 1,
                IdPatioVehicular = 1,
                IdEjecutivo = 1,
                IdVehiculo = 1,
                Cuotas = 5,
                PlazoMeses = 10,
                Observacion = "Ninguna",
                Entrada = 455
            };

            var exception = Assert.ThrowsAsync<Exception>(() => _solicitudService.Add(crearSolicitudDto));
            Assert.Equal("El Cliente ya tiene una solicitud registrada.", exception.Result.Message);
        }

        [Fact]
        public async Task GetSolicitud_DadounIdSolicitudExistente_RetornarSolicitudId1()
        {
            int idSolicitud = 1;
            Solicitud respuesta = await _solicitudService.Get(idSolicitud);

            Assert.NotNull(respuesta);
        }

        //[Fact]
        //public async Task GenerarSolicitud_Nuevoliente()
        //{
        //    CrearSolicitudDto crearSolicitudDto = new CrearSolicitudDto()
        //    {
        //        IdCliente = 2,
        //        IdPatioVehicular = 1,
        //        IdEjecutivo = 1,
        //        IdVehiculo = 1,
        //        Cuotas = 12,
        //        PlazoMeses = 12,
        //        Observacion = "Ninguna",
        //        Entrada = 200
        //    };

        //    var exception = await _solicitudService.Add(crearSolicitudDto);
        //}
    }
}
