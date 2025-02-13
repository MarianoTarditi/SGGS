using Entity.WebAplication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.WebAplication.ViewModels
{
    public class VMCategoriaPago
    {
        public int Id { get; set; }
        public string CategoriaNombre { get; set; } = null!;
        public List<DetallePago>? ListaDetallesPagos { get; set; }
    }
}
