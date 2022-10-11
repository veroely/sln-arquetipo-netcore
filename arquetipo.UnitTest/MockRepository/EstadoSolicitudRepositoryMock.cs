using arquetipo.Domain.IRepository;
using arquetipo.UnitTest.Stubs;
using Moq;

namespace arquetipo.UnitTest.MockRepository
{
    public class EstadoSolicitudRepositoryMock
    {
        public Mock<IEstadoSolicitudRepository> _estadoSolicitudRepository { get; set; }

        public EstadoSolicitudRepositoryMock()
        {
            _estadoSolicitudRepository = new Mock<IEstadoSolicitudRepository>();
            _estadoSolicitudRepository.Setup((x) => x.GetByDescripcion("Registrada")).ReturnsAsync(StubData.solicitudRegistrada);
            _estadoSolicitudRepository.Setup((x) => x.GetByDescripcion("Despachada")).ReturnsAsync(StubData.solicitudDespachada);
            _estadoSolicitudRepository.Setup((x) => x.GetByDescripcion("Cancelada")).ReturnsAsync(StubData.solicitudCancelada);
        }
    }
}
