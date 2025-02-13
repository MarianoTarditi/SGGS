using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.WebAplication.ViewModels
{
    public class PrecioUpdateRequest
    {
        public string Tipo { get; set; } = null!;
        public decimal Precio { get; set; }
    }
}
