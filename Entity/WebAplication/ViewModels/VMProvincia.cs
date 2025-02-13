using Entity.WebAplication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.WebAplication.ViewModels
{
    public class VMProvincia
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public List<Localidad> Localidades { get; set; } = null!;
    }
}
