using CoreLayer.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.WebAplication.Entities
{
    public class AutorizacionPago : BaseEntity
    {
        public string? Observacion { get; set; }
        public DateTime Fecha { get; set; }
        public bool Autorizado { get; set; }
        public List<Pago> Pagos { get; set; } = new List<Pago>();
        public EstadoAutorizacion EstadoAutorizacion { get; set; } = null!;
        public int EstadoAutorizacionId { get; set; }
    }
}
