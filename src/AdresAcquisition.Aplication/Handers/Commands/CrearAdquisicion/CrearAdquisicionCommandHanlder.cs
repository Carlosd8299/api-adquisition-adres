using AdresAdquisition.Domain.Entities;
using AdresAdquisition.Domain.Interfaces;
using MediatR;

namespace AdresAcquisition.Aplication.Handers.Commands.CrearAdquisicion
{
    public class CrearAdquisicionCommandHanlder : IRequestHandler<CrearAdquisicionCommand, Adquisicion>
    {
        private readonly IAdquisicionRepository _adquisicionRepository;

        public CrearAdquisicionCommandHanlder(IAdquisicionRepository adquisicionRepository)
        {
            _adquisicionRepository = adquisicionRepository;
        }

        public async Task<Adquisicion> Handle(CrearAdquisicionCommand request, CancellationToken cancellationToken)
        {
            Adquisicion adquisicion = new Adquisicion(request.Presupuesto, request.Unidad, request.TipoBien, request.Cantidad, request.ValorUnitario, request.FechaAdquisicion, request.Proveedor, request.Documentacion);
            var response = await _adquisicionRepository.Crear(adquisicion);
            return response;
        }
    }
}
