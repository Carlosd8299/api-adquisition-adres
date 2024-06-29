using AdresAcquisition.Aplication.Handers.Commands.CrearAdquisicion;
using AdresAdquisition.Domain.Interfaces;
using AdresAdquisition.Infraestructure.Interfaces;
using AdresAdquisition.Infraestructure.Models;
using AdresAdquisition.Infraestructure.Models.Enums;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace AdresAdquisition.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AcquisitionController : ControllerBase
    {
        private readonly IAdquisicionRepository _iAdquisicionRepository;
        private readonly ILogHistoricoRepository _logHistoricoRepository;
        private readonly IMediator _mediator;

        public AcquisitionController(IAdquisicionRepository iAdquisicionRepository, ILogHistoricoRepository logHistoricoRepository, IMediator mediator)
        {
            _iAdquisicionRepository = iAdquisicionRepository;
            _logHistoricoRepository = logHistoricoRepository;
            _mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> GetAll()
        {
            var result = await _iAdquisicionRepository.ObtenerTodo();

            if (result is not null)
            {
                return StatusCode(StatusCodes.Status200OK, result);
            }
            else
            {
                return StatusCode(StatusCodes.Status204NoContent);
            }
        }


        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> GetById([FromRoute] int id)
        {
            var result = await _iAdquisicionRepository.ObtenerPorId(id);

            if (result is not null)
            {
                return StatusCode(StatusCodes.Status200OK, result);
            }
            else
            {
                return StatusCode(StatusCodes.Status204NoContent);
            }
        }


        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> Create([FromBody] CrearAdquisicionCommand command)
        {
            await Log(command, Events.Crear);

            var result = await _mediator.Send(command);

            if (result is not null)
            {
                return StatusCode(StatusCodes.Status201Created, result);
            }
            else
            {
                return StatusCode(StatusCodes.Status400BadRequest);
            }
        }


        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> Update([FromRoute] int id, [FromBody] ActualizarAdquisicionCommand command)
        {
            await Log(command, Events.Actualizar);
            command.Id = id;
            var result = await _mediator.Send(command);

            if (result is not null)
            {
                return StatusCode(StatusCodes.Status201Created, result);
            }
            else
            {
                return StatusCode(StatusCodes.Status400BadRequest);
            }
        }


        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> Delete([FromRoute] int id)
        {
            await Log(id, Events.Desactivar);
            var result = await _iAdquisicionRepository.Desactivar(id);

            if (result)
                return StatusCode(StatusCodes.Status200OK);
            return StatusCode(StatusCodes.Status404NotFound);
        }


        [NonAction]
        public async Task Log(object command, Events evento)
        {
            await _logHistoricoRepository.Crear(new LogHistorico(JsonSerializer.Serialize(command), "Client", evento));
        }
    }
}
