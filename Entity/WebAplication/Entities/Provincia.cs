using Entity.Identity.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.WebAplication.Entities
{
    public class Provincia : BaseEntity
    {
        public string Nombre { get; set; } = null!;
        public List<Localidad> Localidades { get; set; } = null!;            
    }
}
