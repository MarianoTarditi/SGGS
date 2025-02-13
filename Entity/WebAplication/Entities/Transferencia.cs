using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.WebAplication.Entities
{
    public class Transferencia : ModalidadPago
    {
        //public int Id { get; set; }
        public string NroCuentaOrigenFondo { get; set; } = null!;
        public string BancoOrigen { get; set; } = null!;
        public string NumeroOperacion { get; set; } = null!;
        public string Dni { get; set; } = null!;
    }
}
