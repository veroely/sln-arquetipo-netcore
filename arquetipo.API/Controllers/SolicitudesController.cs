using arquetipo.Domain.Dto.Solicitud;
using arquetipo.Domain.Interfaces;
using arquetipo.Entity.Models;
using Microsoft.AspNetCore.Mvc;

namespace arquetipo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SolicitudesController : ControllerBase
    {
        private readonly ISolicitudService _solicitudService;
        public SolicitudesController(ISolicitudService solicitudService)
        {
            _solicitudService = solicitudService;
        }

        [HttpPost("Generar")]
        public async Task<IActionResult> Add(CrearSolicitudDto solicitud)
        {
            try
            {
                await _solicitudService.Add(solicitud);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(400, ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            Solicitud respuesta =await _solicitudService.Get(id);
            return Ok(respuesta);
        }
    }
}
