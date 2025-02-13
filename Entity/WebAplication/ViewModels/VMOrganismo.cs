using Entity.WebAplication.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entity.WebAplication.ViewModels
{
    public class VMOrganismo
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public int Codigo { get; set; } 
        public DateTime? FechaCreacion { get; set; }
        public string? Descripcion { get; set; } = null!;
        public string Direccion { get; set; } = null!;
        public int? CodigoPostal { get; set; }
        public string Latitud { get; set; } = null!;
        public string Longitud { get; set; } = null!;
        public long Telefono { get; set; }
        public long Celular { get; set; }
        public string? Email { get; set; }

        // ---------------------------------
        public VMResumen Resumen { get; set; } = null!;

        // ---------------------------------
        public VMProvincia Provincia { get; set; } = null!;
        public VMLocalidad Localidad { get; set; } = null!;

        public int ProvinciaId { get; set; }
        public int LocalidadId { get; set; }

        public List<VMMiembro> Miembros { get; set; } = null!;
        public bool Activo { get; set; }

        [Precision(18, 2)]
        public decimal ValorAfiliacion { get; set; }

        [Precision(18, 2)]
        public decimal ValorSeguro { get; set; }
        public List<VMDeuda> Deudas { get; set; } = new List<VMDeuda>();

    }
}
