using Entity.WebAplication.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.WebAplication.ViewModels
{
    public class VMDeuda
    {
        public int Id { get; set; }
        public bool Tiene { get; set; }
        public bool DeudaPendiente { get; set; }
        public bool SaldoDebitado { get; set; } = false;


        public VMMiembro Miembro { get; set; } = null!;
        [Required]
        public int MiembroId { get; set; }
        public Organismo Organismo { get; set; } = null!;
        public int? OrganismoId { get; set; }

        [Precision(18, 2)]
        public decimal MontoAfiliacion { get; set; }
        [Precision(18, 2)]
        public decimal MontoSeguroAcompañante { get; set; }

        public DateTime FechaVencimiento { get; set; }
        public DateTime FechaCreacion { get; set; }  // Fecha en que se generó la deuda

        public VMDeuda()
        {
            FechaCreacion = DateTime.Now;
            FechaVencimiento = DateTime.Now; // La deuda vence en 1 mes
        }

    }
}
