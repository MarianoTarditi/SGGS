using Entity.WebAplication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.WebAplication.ViewModels
{
    public class VMPago
    {
        public int Id { get; set; }
        public int Codigo { get; set; }
        public decimal Total { get; set; }

        // --------------------------------------

        public List<VMDetallePago> ListaDetalles { get; set; } = new List<VMDetallePago>();
        public VMPagoAutorizacion Autorizacion { get; set; } = null!;
        public int PagoAutorizacionId { get; set; }
        public VMRecibo? Recibo { get; set; } = null!;
        public int ReciboId { get; set; }

        public VMResumen Resumen { get; set; } = null!;
        public int ResumenId { get; set; }

        public string? TipoModalidad { get; set; } = null!;  // Almacena el tipo de modalidad seleccionado ("Efectivo", "Deposito", "Transferencia")

        public VMDetallePago DetallePago { get; set; }

        public VMEfectivo? Efectivo { get; set; }
        public int? EfectivoId { get; set; }

        public VMDeposito? Deposito { get; set; }
        public int? DepositoId { get; set; }

        public VMTransferencia? Transferencia { get; set; }
        public int? TransferenciaId { get; set; }

        public VMPagoModalidad Modalidad { get; set; }


        public DateTime FechaDePago { get; set; }

        public string autorizacionEstado { get; set; }
        public string Observacion {  get; set; }
        public decimal Monto { get; set; }
        public VMMiembro Miembro { get; set; }
        public int MiembroId { get; set; }


    }
}
