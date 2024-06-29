using AdresAdquisition.Domain.Entities;
using MediatR;

namespace AdresAcquisition.Aplication.Handers.Commands.ActualizarAdquisicion
{
    public class ActualizarAdquisicionCommand : IRequest<Adquisicion>
    {
        public int Id { get; set; }

        public decimal Presupuesto { get; set; }

        public string? Unidad { get; set; }

        public string? TipoBien { get; set; }

        public int Cantidad { get; set; }

        public decimal ValorUnitario { get; set; }

        public DateTime FechaAdquisicion { get; set; }

        public string? Proveedor { get; set; }

        public string? Documentacion { get; set; }
    }
}
