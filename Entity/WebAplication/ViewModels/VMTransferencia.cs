using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.WebAplication.ViewModels
{
    public class VMTransferencia : VMPagoModalidad
    {
        public string NroCuentaOrigenFondo { get; set; } = null!;
        public string BancoOrigen { get; set; } = null!;
        public string NumeroOperacion { get; set; } = null!;
        public string Dni { get; set; } = null!;
    }
}
