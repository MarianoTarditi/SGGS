using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.WebAplication.Entities.Evento
{
    public class Locacion
    {
        public int Id { get; set; }
        public Propietario Propietario { get; set; } = null!;
        public int PropietarioId { get; set; }
        public string Provincia { get; set; } = null!;
        public string Ciudad { get; set; } = null!;
        public string Direccion { get; set; } = null!;
    }
}
