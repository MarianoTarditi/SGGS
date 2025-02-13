using Entity.WebAplication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.WebAplication.ViewModels
{
    public class VMLocalidad
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;

        public VMProvincia Provincia { get; set; } = null!;
        public int ProvinciaId { get; set; }
        public int Codigo { get; set; }

    }
}

