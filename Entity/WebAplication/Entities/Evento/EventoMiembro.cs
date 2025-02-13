using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.WebAplication.Entities.Evento
{
    public class EventoMiembro
    {
        public int MiembroId { get; set; }       // Llave foránea hacia Miembro
        public Miembro Miembro { get; set; } = null!;

        public int EventoId { get; set; }         // Llave foránea hacia Evento
        public Evento Evento { get; set; } = null!;
    }
}
