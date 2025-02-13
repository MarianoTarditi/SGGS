using Entity.WebAplication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.WebAplication.ViewModels
{
    public class VMRecibo
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int Codigo { get; set; }
        public decimal Total { get; set; }

        // -----------------------------------

        public VMResumen Resumen { get; set; } = null!;
        public int ResumenId { get; set; }
        public VMPago Pago { get; set; } = null!;
        public int PagoId { get; set; }

    } 
}
