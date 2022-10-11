using arquetipo.Domain.IRepository;
using arquetipo.Entity.Models;
using arquetipo.UnitTest.Stubs;
using Moq;

namespace arquetipo.UnitTest.MockRepository
{
    public class GenericRepositoryClientePatioVehicularMock
    {
        public Mock<IGenericRepository<ClientePatioVehicular>> _genericRepositoryClientePatioVehicular;
        public GenericRepositoryClientePatioVehicularMock()
        {
            _genericRepositoryClientePatioVehicular = new Mock<IGenericRepository<ClientePatioVehicular>>();
            _genericRepositoryClientePatioVehicular.Setup(s => s.Add(StubData.clientepPatioVehicular)).ReturnsAsync(1);
        }
    }
}
