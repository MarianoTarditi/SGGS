using Entity.WebAplication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.WebAplication.ViewModels
{
    public class VMDetallePago
    {
        public int Id { get; set; }
        public decimal Monto { get; set; }
        public VMCategoriaPago CategoriaPago { get; set; } = null!;
        public int CategoriaPagoId { get; set; }

        public int Pagoid { get; set; }
        public VMPago Pago { get; set; } = null!;
        public VMMiembro Miembro { get; set; } = null!;
        public int MiembroId { get; set; }

        public decimal? DeudaOriginalAfiliacion { get; set; }
        public decimal? DeudaOriginalSeguro { get; set; }

    }
}
