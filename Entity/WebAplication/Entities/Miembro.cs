using CoreLayer.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.WebAplication.Entities
{
    public class Miembro : BaseEntity
    {
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public string Dni { get; set; } = null!;
        public bool Activo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int CodigoPostal { get; set; }
        public Double? Telefono { get; set; }
        public string? Email { get; set; } 
        public string? DescripcionDiscapacidad { get; set; }
        public string? Titulo { get; set; }


        // ----------------------------------------
        public Localidad Localidad { get; set; } = null!;
        public int LocalidadId { get; set; }
        public Discapacidad? Discapacidad { get; set; }
        public int? DiscapacidadId { get; set; }
        public Idioma Idioma { get; set; } = null!;
        public int IdiomaId { get; set; }
        public Sexo Sexo { get; set; } = null!;
        public int SexoId { get; set; }
        public Religion Religion { get; set; } = null!;
        public int ReligionId { get; set; }
        public Nacionalidad Nacionalidad { get; set; } = null!;
        public int NacionalidadId { get; set; }
        public Organismo Organismo { get; set; } = null!;
        public int OrganismoId { get; set; }

        public EstadoCivil EstadoCivil { get; set; } = null!;
        public int EstadoCivilId { get; set; }
        public Estudio? Estudio { get; set; }
        public int? EstudioId { get; set; }
           public Deuda? Deuda { get; set; }
        public List<Pago>? Pagos { get; set; }


        // ----------------------------------

        public Categoria Categoria { get; set; } = null!;
        public int CategoriaId { get; set; }
        public Rama? Rama { get; set; }
        public int? RamaId { get; set; }
        public bool InsigniaMadera { get; set; }
        public Funcion? Funcion { get; set; }
        public int? FuncionId { get; set; }
    }
}
