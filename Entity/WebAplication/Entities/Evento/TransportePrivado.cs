using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.WebAplication.Entities.Evento
{
    public class TransportePrivado
    {
        public int Id { get; set; }
        public string RazonSocial { get; set; } = null!;
        public string NumeroHabilitacion { get; set; } = null!;
        public double Telefono { get; set; }
        public string Direccion { get; set; } = null!;
    }
}
