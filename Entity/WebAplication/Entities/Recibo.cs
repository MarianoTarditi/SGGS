using CoreLayer.BaseEntities;
using Entity.WebAplication.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.WebAplication.Entities
{
    public class Recibo : BaseEntity
    {
        public DateTime Fecha { get; set; }
        public int Codigo { get; set; }

        [Precision(18, 2)]
        public decimal Total { get; set; }

        // -----------------------------------
        public Pago? Pago { get; set; } 
        public int? PagoId { get; set; }
    }
}
