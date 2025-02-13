using CoreLayer.BaseEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.WebAplication.Entities
{
    public class Organismo : BaseEntity
    {
        public string Nombre { get; set; } = null!;
        public int Codigo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string? Descripcion { get; set; }
        public string Direccion { get; set; } = null!;
        public int CodigoPostal { get; set; }
        public bool Activo { get; set; }


        public string Latitud { get; set; } = null!;
        public string Longitud { get; set; } = null!;
        public long Telefono { get; set; }
        public long Celular { get; set; }
        public string? Email { get; set; }


        // --------------------------------

        public Localidad Localidad { get; set; } = null!;
        public int LocalidadId { get; set; }

        public List<Miembro> Miembros { get; set; } = null!;
        public Resumen Resumen { get; set; } = null!;

        // ------------------------------------------------------

        [Precision(18, 2)]
        public decimal ValorAfiliacion { get; set; }

        [Precision(18, 2)]
        public decimal ValorSeguro { get; set; }
        public List<Deuda> Deudas { get; set; } = new List<Deuda>();

    }

}
