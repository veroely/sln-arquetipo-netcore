using arquetipo.Domain.Dto.PatioVehicular;
using arquetipo.Domain.Interfaces;
using arquetipo.Entity.Models;
using Microsoft.AspNetCore.Mvc;

namespace arquetipo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatiosVehicularesController : ControllerBase
    {
        private readonly IPatioVehicularService _patioVehicularService;
        public PatiosVehicularesController(IPatioVehicularService patioVehicularService)
        {
            _patioVehicularService = patioVehicularService;
        }

        [HttpPost]
        public async Task<IActionResult> Add(CrearPatioVehicularDto patioDto)
        {
            try
            {
                await _patioVehicularService.Add(patioDto);
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
            List<PatioVehicular> lista = await _patioVehicularService.GetAll();
            return Ok(lista);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            PatioVehicular item = await _patioVehicularService.Get(id);
            return Ok(item);
        }

        [HttpPut]
        public async Task<IActionResult> Update(PatioVehicular patio)
        {
            try
            {
                int result = await _patioVehicularService.Update(patio);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(400, ex.Message);
            }
        }
    }
}
