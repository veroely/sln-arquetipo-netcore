using arquetipo.Domain.Dto.Vehiculo;
using arquetipo.Domain.Interfaces;
using arquetipo.Entity.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace arquetipo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiculosController : ControllerBase
    {
        private readonly IVehiculoService _vehiculoService;
        public VehiculosController(IVehiculoService vehiculoService)
        {
            _vehiculoService = vehiculoService;
        }

        [HttpPost]
        public async Task<IActionResult> Add(CrearVehiculoDto vehiculoDto)
        {
            try
            {
                await _vehiculoService.Add(vehiculoDto);
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
            List<Vehiculo> lista = await _vehiculoService.GetAll();
            return Ok(lista);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            Vehiculo item = await _vehiculoService.Get(id);
            return Ok(item);
        }

        [HttpPut]
        public async Task<IActionResult> Update(Vehiculo vehiculo)
        {
            try
            {
                int result = await _vehiculoService.Update(vehiculo);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(400, ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                int result = await _vehiculoService.Delete(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(400, ex.Message);
            }
        }

        [HttpGet("{marca}/{modelo}")]
        public async Task<IActionResult> GetByMarcaModelo(string marca, string modelo)
        {
            List<Vehiculo> item = await _vehiculoService.GetByMarcaModelo(marca, modelo,"");
            return Ok(item);
        }
    }
}
