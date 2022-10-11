using arquetipo.Domain.Dto.PatioVehicular;
using arquetipo.Domain.Interfaces;
using arquetipo.Domain.IRepository;
using arquetipo.Entity.Models;

namespace arquetipo.Domain.Services
{
    public class PatioVehicularService : IPatioVehicularService
    {
        private readonly IGenericRepository<PatioVehicular> _genericRepositryPatioVehicular;
        public PatioVehicularService(IGenericRepository<PatioVehicular> genericRepositryPatioVehicular)
        {
            _genericRepositryPatioVehicular = genericRepositryPatioVehicular;
        }

        public async Task<int> Add(CrearPatioVehicularDto patioDto)
        {
            PatioVehicular patio = new PatioVehicular()
            {
                Nombre = patioDto.Nombre,
                Direccion = patioDto.Direccion,
                Telefono = patioDto.Telefono,
                NumeroPuntoVenta = patioDto.NumeroPuntoVenta
            };
            return await _genericRepositryPatioVehicular.Add(patio);
        }

        public async Task<int> AddRange(List<PatioVehicular> patios)
        {
            return await _genericRepositryPatioVehicular.AddRange(patios);
        }

        public async Task<int> Delete(int id)
        {
            return await _genericRepositryPatioVehicular.Delete(id);
        }

        public async Task<PatioVehicular> Get(int id)
        {
            return await _genericRepositryPatioVehicular.Get(id);
        }

        public async Task<List<PatioVehicular>> GetAll()
        {
            return await _genericRepositryPatioVehicular.GetAll();
        }

        public async Task<int> Update(PatioVehicular patio)
        {
            return await _genericRepositryPatioVehicular.Update(patio);
        }
    }
}
