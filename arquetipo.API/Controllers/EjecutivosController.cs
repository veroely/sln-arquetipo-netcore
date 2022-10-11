using arquetipo.Domain.Interfaces;
using arquetipo.Entity.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace arquetipo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EjecutivosController : ControllerBase
    {
        private readonly IEjecutivoService _ejecutivoService;

        public EjecutivosController(IEjecutivoService ejecutivoService)
        {
            _ejecutivoService = ejecutivoService;
        }

        [HttpGet("ConsultarPorIdPatio/{idPatioVehicular}")]
        public async Task<IActionResult> ConsultarPorIdPatio(int idPatioVehicular) 
        {
            List<Ejecutivo> ejecutivos = await _ejecutivoService.GetByIdPatio(idPatioVehicular);
            return Ok(ejecutivos);
        }
    }
}
