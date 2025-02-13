using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.WebAplication.ViewModels
{
    public class VMDeposito : VMPagoModalidad
    {
        public string NumeroSucursal { get; set; } = null!;
        public string NumeroOperacion { get; set; } = null!;
        public string NumeroCuenta { get; set; } = null!;
    }
}
