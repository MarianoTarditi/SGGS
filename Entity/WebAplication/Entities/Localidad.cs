using Entity.Identity.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.WebAplication.Entities
{
    public class Localidad : BaseEntity
    {
        public string Nombre { get; set; } = null!;
        public Provincia Provincia { get; set; } = null!;
        public int ProvinciaId { get; set; }
        public int Codigo { get; set; }
        public List<Organismo> Organismos { get; set; } = null!;

    }
}
