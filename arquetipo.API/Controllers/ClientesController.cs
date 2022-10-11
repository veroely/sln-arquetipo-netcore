using arquetipo.Domain.Dto.Cliente;
using arquetipo.Domain.Interfaces;
using arquetipo.Entity.Models;
using Microsoft.AspNetCore.Mvc;

namespace arquetipo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly IClienteService _clienteService;
        public ClientesController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpPost]
        public async Task<IActionResult> Add(CrearClienteDto clienteDto)
        {
            try
            {
                await _clienteService.Add(clienteDto);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(400, ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            List<Cliente> lista = await _clienteService.GetAll();
            return Ok(lista);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            Cliente item = await _clienteService.Get(id);
            return Ok(item);
        }

        [HttpPut]
        public async Task<IActionResult> Update(Cliente cliente)
        {
            try
            {
                int result = await _clienteService.Update(cliente);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(400, ex.Message);
            }
        }
    }
}
