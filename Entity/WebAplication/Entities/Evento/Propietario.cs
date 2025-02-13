using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.WebAplication.Entities.Evento
{
    public class Propietario
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public double Telefono { get; set; }
        public List<Locacion> Locacion { get; set; } = null!;
    }
}
