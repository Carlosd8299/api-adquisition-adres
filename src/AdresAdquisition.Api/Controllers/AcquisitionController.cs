using AdresAcquisition.Aplication.Handers.Commands.CrearAdquisicion;
using AdresAdquisition.Domain.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AdresAdquisition.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AcquisitionController : ControllerBase
    {
        private readonly IAdquisicionRepository _iAdquisicionRepository;
        private readonly IMediator _mediator;

        public AcquisitionController(IAdquisicionRepository iAdquisicionRepository, IMediator mediator)
        {
            _iAdquisicionRepository = iAdquisicionRepository;
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
        public async Task<ActionResult> GetById([FromRouteAttribute] int id)
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


        [HttpPost("{id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> Create([FromRouteAttribute] int id, [FromBody] ActualizarAdquisicionCommand command)
        {
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

    }
}
