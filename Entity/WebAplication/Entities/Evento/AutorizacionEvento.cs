using CoreLayer.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.WebAplication.Entities.Evento
{
    public class AutorizacionEvento : BaseEntity
    {
        public string? Observacion { get; set; }
        public DateTime Fecha { get; set; }
        public bool Autorizado { get; set; }
        public Evento Evento { get; set; } = null!;
        public EstadoAutorizacion EstadoAutorizacion { get; set; } = null!;
        public int EstadoAutorizacionId { get; set; }
    }
}
