using Entity.WebAplication.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.WebAplication.ViewModels
{
    public class VMResumen
    {
        public int Id { get; set; }
        public decimal Credito { get; set; }
        public decimal Debito { get; set; }
        [Precision(18, 2)]
        public decimal SaldoTotal { get; set; }

        [Precision(18, 2)]
        public decimal SaldoAfiliacion { get; set; }
        [Precision(18, 2)]
        public decimal SaldoSeguroAcompañante { get; set; }

        // -----------------------------------------------
        public List<VMPago> Pagos { get; set; } = null!;
        public VMOrganismo Organismo { get; set; } = null!;
        public int OrganismoId { get; set; }
    }
}
