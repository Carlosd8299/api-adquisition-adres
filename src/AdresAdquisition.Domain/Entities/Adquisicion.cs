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
            SetValorUnitario(valorUnitario, presupuesto);
            SetValorTotal(valorUnitario, cantidad, presupuesto);
            FechaAdquisicion = fechaAdquisicion;
            Proveedor = proveedor;
            Documentacion = documentacion;
            Estado = true;
        }

        public Adquisicion ActualizarAdquisicion(Adquisicion adquisicionAntigua, decimal presupuesto, string unidad, string tipoBien, int cantidad, decimal valorUnitario, DateTime fechaAdquisicion, string proveedor, string documentacion)
        {
            decimal xPresupuesto = presupuesto != default ? presupuesto : adquisicionAntigua.Presupuesto;
            string xUnidad = unidad != default ? unidad : adquisicionAntigua.Unidad;
            string xTipoBien = tipoBien != default ? tipoBien : adquisicionAntigua.TipoBien;
            int xCantidad = cantidad != default ? cantidad : adquisicionAntigua.Cantidad;
            decimal xValorUnitario = valorUnitario != default ? valorUnitario : adquisicionAntigua.ValorUnitario;
            DateTime xFechaAdquisicion = fechaAdquisicion != default ? fechaAdquisicion : adquisicionAntigua.FechaAdquisicion;
            string xProveedor = proveedor != default ? proveedor : adquisicionAntigua.Proveedor;
            string xDocumentacion = documentacion != default ? documentacion : adquisicionAntigua.Documentacion;

            var response = new Adquisicion(xPresupuesto, xUnidad, xTipoBien, xCantidad, xValorUnitario, xFechaAdquisicion, xProveedor, xDocumentacion);

            return response;
        }

        private void SetValorUnitario(decimal valorUnitario, decimal presupuesto)
        {
            if (valorUnitario <= presupuesto)
            {
                this.ValorUnitario = valorUnitario;
            }
            else
            {
                throw new DomainException($"El valor unitario {valorUnitario} no puede ser mayor al presupuesto {presupuesto}");
            }
        }

        private void SetValorTotal(decimal valorUnitario, int cantidad, decimal presupuesto)
        {
            decimal valorTotal = valorUnitario * cantidad;

            if (valorTotal <= presupuesto)
            {
                this.ValorTotal = valorTotal;
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

        //public void SetIdentity(Adquisicion adquisicion)
        //{
        //    adquisicion.
        //}
    }
}
