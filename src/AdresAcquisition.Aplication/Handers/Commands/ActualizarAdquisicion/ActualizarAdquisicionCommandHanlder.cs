using AdresAcquisition.Aplication.Handers.Commands.CrearAdquisicion;
using AdresAdquisition.Domain.Entities;
using AdresAdquisition.Domain.Interfaces;
using MediatR;

namespace AdresAcquisition.Aplication.Handers.Commands
{
    public class ActualizarAdquisicionCommandHanlder : IRequestHandler<ActualizarAdquisicionCommand, Adquisicion>
    {
        private readonly IAdquisicionRepository _adquisicionRepository;

        public ActualizarAdquisicionCommandHanlder(IAdquisicionRepository adquisicionRepository)
        {
            _adquisicionRepository = adquisicionRepository;
        }

        public async Task<Adquisicion> Handle(ActualizarAdquisicionCommand request, CancellationToken cancellationToken)
        {
            Adquisicion adquisicion = await _adquisicionRepository.ObtenerPorId(request.Id);

            if (adquisicion is not null)
            {
                Adquisicion updatedProduct = adquisicion.ActualizarProducto(adquisicion, request.Presupuesto, request.Unidad, request.TipoBien, request.Cantidad, request.ValorUnitario, request.FechaAdquisicion, request.Proveedor, request.Documentacion);
                return await _adquisicionRepository.Actualizar(updatedProduct);
            }
            else
            {
                return null;
            }
        }
    }
}
