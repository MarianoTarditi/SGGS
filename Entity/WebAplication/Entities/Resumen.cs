using CoreLayer.BaseEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.WebAplication.Entities
{
    public class Resumen : BaseEntity
    {
        [Precision(18, 2)]
        public decimal Credito { get; set; }

        [Precision(18, 2)]
        public decimal Debito { get; set; }

        [Precision(18, 2)]
        public decimal SaldoTotal { get; set; }

        [Precision(18, 2)]
        public decimal SaldoAfiliacion { get; set; }
        [Precision(18, 2)]
        public decimal DebitoAfiliacion { get; set; }
        [Precision(18, 2)]
        public decimal DebitoSeguroAcompañante { get; set; }
        [Precision(18, 2)]
        public decimal CreditoAfiliacion { get; set; }
        [Precision(18, 2)]
        public decimal CreditoSeguroAcompañante { get; set; }
        [Precision(18, 2)]
        public decimal SaldoSeguroAcompañante { get; set; }
        //-----------------------------------------------
        public List<Pago> Pagos { get; set; } = null!;
        public Organismo Organismo { get; set; } = null!;
        public int OrganismoId { get; set; }

    }
}
