using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.WebAplication.ViewModels
{
    public class VMCambiarEstadoRequest
    {
        public int IdPago { get; set; }
        public int NuevoEstadoId { get; set; }
    }
}
