using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdresAdquisition.Domain.Entities
{
    public class Adquisicion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; private set; }
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

        public decimal ValorTotal { get; private set; }
        [Required]
        public DateTime FechaAdquisicion { get; private set; }
        [Required]
        public string Proveedor { get; private set; }
        [Required]
        public string Documentacion { get; private set; }

        public bool Estado { get; private set; } = true;

        public Adquisicion(decimal presupuesto, string unidad, string tipoBien, int cantidad, decimal valorUnitario, DateTime fechaAdquisicion, string proveedor, string documentacion)
        {
            Presupuesto = presupuesto;
            Unidad = unidad;
            TipoBien = tipoBien;
            Cantidad = cantidad;
            ValorUnitario = SetValorUnitario(valorUnitario, presupuesto);
            ValorTotal = SetValorTotal(valorUnitario, cantidad, presupuesto);
            FechaAdquisicion = fechaAdquisicion;
            Proveedor = proveedor;
            Documentacion = documentacion;
            Estado = true;
        }

        public Adquisicion ActualizarAdquisicion(Adquisicion adquisicionAntigua, decimal presupuesto, string unidad, string tipoBien, int cantidad, decimal valorUnitario, DateTime fechaAdquisicion, string proveedor, string documentacion)
        {
            adquisicionAntigua.Presupuesto = presupuesto != default ? presupuesto : adquisicionAntigua.Presupuesto;
            adquisicionAntigua.Unidad = unidad != default ? unidad : adquisicionAntigua.Unidad;
            adquisicionAntigua.TipoBien = tipoBien != default ? tipoBien : adquisicionAntigua.TipoBien;
            adquisicionAntigua.Cantidad = cantidad != default ? cantidad : adquisicionAntigua.Cantidad;
            adquisicionAntigua.ValorUnitario = valorUnitario != default ? SetValorUnitario(valorUnitario, presupuesto) : adquisicionAntigua.ValorUnitario;
            adquisicionAntigua.FechaAdquisicion = fechaAdquisicion != default ? fechaAdquisicion : adquisicionAntigua.FechaAdquisicion;
            adquisicionAntigua.Proveedor = proveedor != default ? proveedor : adquisicionAntigua.Proveedor;
            adquisicionAntigua.Documentacion = documentacion != default ? documentacion : adquisicionAntigua.Documentacion;
            adquisicionAntigua.ValorTotal = SetValorTotal(valorUnitario, cantidad, presupuesto);
            return adquisicionAntigua;
        }

        private decimal SetValorUnitario(decimal valorUnitario, decimal presupuesto)
        {
            if (valorUnitario <= presupuesto)
            {
                return valorUnitario;
            }
            else
            {
                throw new DomainException($"El valor unitario {valorUnitario} no puede ser mayor al presupuesto {presupuesto}");
            }
        }

        private decimal SetValorTotal(decimal valorUnitario, int cantidad, decimal presupuesto)
        {
            decimal valorTotal = valorUnitario * cantidad;

            if (valorTotal <= presupuesto)
            {
                return valorTotal;
            }
            else
            {
                throw new DomainException($"El valor total {valorTotal} no puede ser mayor al presupuesto {presupuesto}");
            }
        }

        public void SetEstado(bool estado)
        {
            this.Estado = estado;
        }
    }
}
