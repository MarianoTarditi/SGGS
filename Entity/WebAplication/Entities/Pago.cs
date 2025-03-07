using Entity.Identity.Entities.BaseEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Entity.WebAplication.Entities
{
    public class Pago : BaseEntity
    {
        public int Codigo { get; set; }

        [Precision(18, 2)]
        public decimal Total { get; set; }

        // --------------------------------------
        public ModalidadPago ModalidadPago { get; set; }
        
        public List<DetallePago> ListaDetalles { get; set; } = new List<DetallePago>();
        public AutorizacionPago Autorizacion { get; set; } = null!;
        public int AutorizacionPagoId { get; set; } // Clave foránea

        public Miembro Miembro { get; set; } = null!;
        public int MiembroId { get; set; }
        public Resumen Resumen { get; set; } = null!;
        public int ResumenId { get; set; }
        public bool Activo { get; set; }
        public string? TipoModalidad { get; set; }  // Almacena el tipo de modalidad seleccionado ("Efectivo", "Deposito", "Transferencia")
    }
}
