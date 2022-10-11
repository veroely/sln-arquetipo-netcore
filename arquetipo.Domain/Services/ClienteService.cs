using arquetipo.Domain.Dto.Cliente;
using arquetipo.Domain.Interfaces;
using arquetipo.Domain.IRepository;
using arquetipo.Entity.Models;

namespace arquetipo.Domain.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IGenericRepository<Cliente> _genericRepositoryCliente;

        public ClienteService(IGenericRepository<Cliente> genericRepositoryCliente)
        {
            _genericRepositoryCliente = genericRepositoryCliente;
        }

        public async Task<int> Add(CrearClienteDto clienteDto)
        {
            Cliente cliente = new Cliente()
            {
                Identificacion = clienteDto.Identificacion,
                Nombres = clienteDto.Nombres,
                Apellidos = clienteDto.Apellidos,
                FechaNacimiento = clienteDto.FechaNacimiento,
                Direccion = clienteDto.Direccion,
                Telefono = clienteDto.Telefono,
                IdEstadoCivil = clienteDto.IdEstadoCivil,
                SujetoCredito = clienteDto.SujetoCredito
            };

            return await _genericRepositoryCliente.Add(cliente);
        }

        public async Task<int> AddRange(List<CrearClienteDto> clientesDto)
        {
            List<Cliente> clientes = clientesDto.Select(s => new Cliente
            {
                Identificacion = s.Identificacion,
                Nombres = s.Nombres,
                Apellidos = s.Apellidos,
                FechaNacimiento = s.FechaNacimiento,
                Direccion = s.Direccion,
                Telefono = s.Telefono,
                IdEstadoCivil = s.IdEstadoCivil,
                SujetoCredito = s.SujetoCredito

            }).ToList();

            return await _genericRepositoryCliente.AddRange(clientes);
        }

        public async Task<int> Delete(int id)
        {
            return await _genericRepositoryCliente.Delete(id);
        }

        public async Task<Cliente> Get(int id)
        {
            return await _genericRepositoryCliente.Get(id);
        }

        public async Task<List<Cliente>> GetAll()
        {
            return await _genericRepositoryCliente.GetAll();
        }

        public async Task<int> Update(Cliente cliente)
        {
            return await _genericRepositoryCliente.Update(cliente);
        }
    }
}
