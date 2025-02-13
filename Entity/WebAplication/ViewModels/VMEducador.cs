using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.WebAplication.ViewModels
{
    public class VMEducador
    {
        public int Id { get; set; }
        public bool InsigniaMadera { get; set; }
        public string FuncionEducador { get; set; } = null!;
    }
}
