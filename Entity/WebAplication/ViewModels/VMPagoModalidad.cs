using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.WebAplication.ViewModels
{
    public class VMPagoModalidad
    {
        public int Id { get; set; }
        public string NombreCompleto { get; set; } = null!;// Propiedad común a todas las modalidades
        public DateTime FechaDePago { get; set; }  // Propiedad común a todas las modalidades
        public string? Observacion { get; set; } 
        
        public string TipoModalidad { get; set; }


    }
}
