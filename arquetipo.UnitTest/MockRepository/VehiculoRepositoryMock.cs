using arquetipo.Domain.IRepository;
using arquetipo.Entity.Models;
using Moq;
using System.Collections.Generic;

namespace arquetipo.UnitTest.MockRepository
{
    public class VehiculoRepositoryMock
    {
        public Mock<IVehiculoRepository> _vehiculoRepository;
        public VehiculoRepositoryMock()
        {
            _vehiculoRepository = new Mock<IVehiculoRepository>();
            _vehiculoRepository.Setup(s => s.GetByMarcaModelo("", "", "")).ReturnsAsync(new List<Vehiculo>());
        }
    }
}
