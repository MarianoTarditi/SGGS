using CoreLayer.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.WebAplication.Entities
{
    public class Educador : BaseEntity
    {
        public bool InsigniaMadera { get; set; }
        public string FuncionEducador { get; set; } = null!;
    }
}
