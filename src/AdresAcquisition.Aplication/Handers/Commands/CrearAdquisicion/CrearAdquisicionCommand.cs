using AdresAdquisition.Domain.Entities;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace AdresAcquisition.Aplication.Handers.Commands.CrearAdquisicion
{
    public class CrearAdquisicionCommand: IRequest<Adquisicion>
    {
        [Required]
        public decimal Presupuesto { get;  set; }
        [Required]
        public string Unidad { get;  set; }
        [Required]
        public string TipoBien { get;  set; }
        [Required]
        public int Cantidad { get;  set; }
        [Required]
        public decimal ValorUnitario { get;  set; }
        [Required]
        public DateTime FechaAdquisicion { get;  set; }
        [Required]
        public string Proveedor { get;  set; }
        [Required]
        public string Documentacion { get;  set; }
    }
}
