using CoreLayer.BaseEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.WebAplication.Entities
{
    public class Categoria : BaseEntity
    {
        public string Nombre { get; set; } = null!;
    }
}
