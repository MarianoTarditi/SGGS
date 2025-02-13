using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.WebAplication.Entities
{
    public class Deposito : ModalidadPago 
    {
        //public int Id { get; set; }
        public string NumeroSucursal { get; set; } = null!;
        public string NumeroOperacion { get; set; } = null!;
        public string NumeroCuenta { get; set; } = null!;
    }
}
