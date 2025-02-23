using Entity.Identity.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.WebAplication.Entities
{
    public class CategoriaPago : BaseEntity
    {
        public string CategoriaNombre { get; set; } = null!;
        public List<DetallePago>? ListaDetallesPagos { get; set; }
    }
}
