using arquetipo.Domain.Dto.PatioVehicular;
using arquetipo.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arquetipo.Domain.Interfaces
{
    public interface IPatioVehicularService
    {
        Task<int> Add(CrearPatioVehicularDto patioDto);
        Task<int> AddRange(List<PatioVehicular> patios);
        Task<PatioVehicular> Get(int id);
        Task<List<PatioVehicular>> GetAll();
        Task<int> Update(PatioVehicular patio);
        Task<int> Delete(int id);
    }
}
