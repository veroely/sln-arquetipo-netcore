using arquetipo.Domain.IRepository;
using arquetipo.Entity.Models;
using arquetipo.UnitTest.Stubs;
using Moq;

namespace arquetipo.UnitTest.MockRepository
{
    public class GenericRepositorySolicitudMock
    {
        public Mock<IGenericRepository<Solicitud>> _genericRepositorySolicitud;
        public GenericRepositorySolicitudMock()
        {
            _genericRepositorySolicitud = new Mock<IGenericRepository<Solicitud>>();
            _genericRepositorySolicitud.Setup(s => s.Get(1)).ReturnsAsync(StubData.solicitud1);
            _genericRepositorySolicitud.Setup(s => s.Add(StubData.solicitudMismoCliente)).ReturnsAsync(1);
            _genericRepositorySolicitud.Setup(s => s.Add(StubData.solicitud)).ReturnsAsync(1);
        }
    }
}
