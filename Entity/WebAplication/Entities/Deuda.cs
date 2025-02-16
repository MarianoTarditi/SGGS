using CoreLayer.BaseEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.WebAplication.Entities
{
    public class Deuda : BaseEntity
    {
        [Precision(18, 2)]
        public decimal MontoAfiliacion { get; set; }
        [Precision(18, 2)]
        public decimal MontoSeguroAcompañante { get; set; }
        public bool DeudaPendiente { get; set; }
        public bool Tiene { get; set; }
        public Miembro Miembro { get; set; } = null!;
        [Required]
        public int MiembroId { get; set; }
        public Organismo Organismo { get; set; } = null!;
        public int? OrganismoId { get; set; }

        public DateTime FechaVencimiento { get; set; }
        public DateTime FechaCreacion { get; set; }  // Fecha en que se generó la deuda

        public Deuda()
        {
            FechaCreacion = DateTime.Now;
            FechaVencimiento = FechaCreacion.AddMinutes(5); // La deuda vence en 1 mes
        }
    }
}
