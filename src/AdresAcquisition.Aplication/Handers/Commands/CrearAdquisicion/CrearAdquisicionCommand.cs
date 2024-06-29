using AdresAdquisition.Domain.Entities;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace AdresAcquisition.Aplication.Handers.Commands.CrearAdquisicion
{
    public class CrearAdquisicionCommand : IRequest<Adquisicion>
    {
        [Required]
        public decimal Presupuesto { get; private set; }
        [Required]
        public string Unidad { get; private set; }
        [Required]
        public string TipoBien { get; private set; }
        [Required]
        public int Cantidad { get; private set; }
        [Required]
        public decimal ValorUnitario { get; private set; }
        [Required]
        public DateTime FechaAdquisicion { get; private set; }
        [Required]
        public string Proveedor { get; private set; }
        [Required]
        public string Documentacion { get; private set; }
    }
}
