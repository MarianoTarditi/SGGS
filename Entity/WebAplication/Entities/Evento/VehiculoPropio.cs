using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.WebAplication.Entities.Evento
{
    public class VehiculoPropio
    {
        public int Id { get; set; }
        public string Tipo { get; set; } = null!;
        public string Marca { get; set; } = null!;
        public string Modelo { get; set; } = null!;
        public string Patente { get; set; } = null!;
    }
}
