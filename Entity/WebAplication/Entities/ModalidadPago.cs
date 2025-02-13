using CoreLayer.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.WebAplication.Entities
{
    public class ModalidadPago : BaseEntity
    {
        public string NombreCompleto { get; set; } = null!;// Propiedad común a todas las modalidades
        public DateTime FechaDePago { get; set; }  // Propiedad común a todas las modalidades
        public string? Observacion { get; set; }

        // -----------
        public Pago Pago { get; set; } = null!;
        public int PagoId { get; set; }

    }
}
