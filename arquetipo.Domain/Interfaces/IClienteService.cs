using arquetipo.Domain.Dto.Cliente;
using arquetipo.Entity.Models;

namespace arquetipo.Domain.Interfaces
{
    public interface IClienteService
    {
        Task<int> Add(CrearClienteDto clienteDto);
        Task<int> AddRange(List<CrearClienteDto> clientesDto);
        Task<Cliente> Get(int id);
        Task<List<Cliente>> GetAll();
        Task<int> Update(Cliente cliente);
        Task<int> Delete(int id);
    }
}
