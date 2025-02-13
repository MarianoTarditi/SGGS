using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.WebAplication.Entities.Evento
{
    public class Evento
    {
        public int Id { get; set; }
        public int Codigo { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaSalida { get; set; }
        public DateTime HoraSalida { get; set; }
        public DateTime FechaLlegada { get; set; }
        public DateTime HoraLlegada { get; set; }
    
        public double Telefono { get; set; }
        public string? Observacion { get; set; }
        public string NombreDirecZona { get; set; } = null!;
        public double? Celular {  get; set; }


        public Locacion Locacion { get; set; } = null!;
        public int LocacionId { get; set; }
        public VehiculoPropio? VehiculoPropio { get; set; }
        public int VehiculoPropioId { get; set; }
        public TransportePrivado? TransportePrivdado { get; set; }
        public int TransportePrivdadoId { get; set; }
        public DestacamientoPolicial? DestacamientoPolicial { get; set; }
        public int DestacamientoPolicialId { get; set; }
        public UnidadSanitaria? UnidadSanitaria { get; set; }
        public int UnidadSanitariaId { get; set; }
        public Miembro JefeDeCampo { get; set; } = null!;
        public int JefeDeCampoId { get; set; }
        public AutorizacionEvento? Autorizacion { get; set; }
        public int AutorizacionId { get; set; }
        public List<EventoMiembro>? EventosMiembros { get; set; }
        public bool Activo { get; set; }
    }
}
