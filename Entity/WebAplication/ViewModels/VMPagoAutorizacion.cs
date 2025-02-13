using Entity.WebAplication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.WebAplication.ViewModels
{
    public class VMPagoAutorizacion
    {
        public int Id { get; set; }
        public VMEstadoAutorizacion EstadoAutorizacion { get; set; } = null!;
        public int EstadoAutorizacionId { get; set; }
        public string? Observacion { get; set; }
        public DateTime Fecha { get; set; }
        public bool Autorizado { get; set; }
        public ICollection<VMPago> Pagos { get; set; } = new List<VMPago>();
    }
}
