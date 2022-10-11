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

        [HttpPut]
        public async Task<IActionResult> Update(Solicitud solicitud)
        {
            try
            {
                int result = await _solicitudService.Update(solicitud);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(400, ex.Message);
            }
        }
    }
}
