using arquetipo.Domain.IRepository;
using arquetipo.UnitTest.Stubs;
using Moq;
using System;

namespace arquetipo.UnitTest.MockRepository
{
    public class SolicitudRepositoryMock
    {
        public Mock<ISolicitudRepository> _solicitudRepository { get; set; }

        public SolicitudRepositoryMock()
        {
            _solicitudRepository = new Mock<ISolicitudRepository>();
            _solicitudRepository.Setup((x) => x.GetByClienteyFecha(1, DateTime.Today)).ReturnsAsync(StubData.solicitud1);
            _solicitudRepository.Setup((x) => x.GetByClienteyFecha(2, DateTime.Today)).ReturnsAsync(StubData.solicitudNUll);
            _solicitudRepository.Setup(x => x.GetByIdVehiculo(1)).ReturnsAsync(StubData.solicitud);
        }
    }
}
