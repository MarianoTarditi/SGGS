using CoreLayer.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.WebAplication.Entities
{
    public class Nacionalidad : BaseEntity
    {
        public string Pais { get; set; } = null!;
    }
}
