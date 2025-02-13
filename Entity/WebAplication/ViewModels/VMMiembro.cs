using Entity.WebAplication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.WebAplication.ViewModels
{
    public class VMMiembro
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public string Dni { get; set; } = null!;
        public bool Activo { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public bool InsigniaMadera { get; set; }
        public int? CodigoPostal { get; set; }
        public double? Telefono { get; set; }
        public string? Email { get; set; }
        public string? DescripcionDiscapacidad { get; set; }
        public string? Titulo { get; set; }

        // ----------------------------------------
        public VMLocalidad Localidad { get; set; } = null!;
        public int? LocalidadId { get; set; }
        public VMDiscapacidad? Discapacidad { get; set; }
        public int? MiembroDiscapacidadId { get; set; }
        public VMIdioma Idioma { get; set; } = null!;
        public int IdiomaId { get; set; }
        public VMSexo Sexo { get; set; } = null!;
        public int? SexoId { get; set; }
        public VMReligion Religion { get; set; } = null!;
        public int? ReligionId { get; set; }
        public VMNacionalidad Nacionalidad { get; set; } = null!;
        public int NacionalidadId { get; set; }
        public VMOrganismo Organismo { get; set; } = null!;
        public int? OrganismoId { get; set; }

        public VMEstadoCivil? EstadoCivil { get; set; } 
        public int? EstadoCivilId { get; set; }
        public VMMiembroEstudio? Estudio { get; set; }

        public int? EstudioId { get; set; }
        public int? ProvinciaId { get; set; }

        public VMDeuda? Deuda { get; set; }
        //public int? DeudaId { get; set; }

        public string? SexoNombre { get; set; }
        public string? OrganismoNombre { get; set; }


        public decimal MontoAfiliacion { get; set; }
        public decimal MontoSeguroAcompañante { get; set; }
        public DateTime DeudaFechaVencimiento { get; set; }
        public bool DeudaTiene { get; set; }
        public List<VMPago>? Pagos { get; set; }


        public VMCategoria Categoria { get; set; } = null!;
        public int CategoriaId { get; set; }
        public VMRama? Rama { get; set; }
        public int? RamaId { get; set; }
        public bool InisgniaMadera { get; set; }
        public VMFuncion? Funcion { get; set; }
        public int? FuncionId { get; set; }
        public string CategoriaNombre { get; set; } = null!;
        public string? FuncionNombre { get; set; }
        public string? RamaNombre { get; set; }

    }
}
