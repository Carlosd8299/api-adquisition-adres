using AdresAdquisition.Infraestructure.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AdresAcquisition.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogController : ControllerBase
    {
        private readonly ILogHistoricoRepository _logHistoricoRepository;

        public LogController(ILogHistoricoRepository logHistoricoRepository)
        {
            _logHistoricoRepository = logHistoricoRepository;
        }

        [HttpGet("{date}")]
        public async Task<ActionResult> Get([FromRoute] DateTime date)
        {
            return StatusCode(StatusCodes.Status200OK, await _logHistoricoRepository.Consultar(date));
        }


    }
}
