using CoreLayer.BaseEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.WebAplication.Entities
{
    public class DetallePago : BaseEntity
    {
        [Precision(18, 2)]
        public decimal Monto { get; set; }

        public int Pagoid { get; set; }
        public Pago Pago { get; set; } = null!;


        // --------

        public CategoriaPago CategoriaPago { get; set; } = null!;
        public int CategoriaPagoId { get; set; }

        [Precision(18, 2)]
        public decimal? DeudaOriginalAfiliacion { get; set; }
        [Precision(18, 2)]
        public decimal? DeudaOriginalSeguro { get; set; }


    }
}
