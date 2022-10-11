using arquetipo.Domain.IRepository;
using arquetipo.Entity.Models;
using arquetipo.UnitTest.Stubs;
using Moq;

namespace arquetipo.UnitTest.MockRepository
{
    public class GenericRepositoryVehiculoMock
    {
        public Mock<IGenericRepository<Vehiculo>> _genericRepositoryVehiculo;
        public GenericRepositoryVehiculoMock()
        {
            _genericRepositoryVehiculo = new Mock<IGenericRepository<Vehiculo>>();
            _genericRepositoryVehiculo.Setup(s => s.Get(1)).ReturnsAsync(StubData.vehiculo1);
            _genericRepositoryVehiculo.Setup(s => s.Delete(5)).ReturnsAsync(0);
        }
    }
}
