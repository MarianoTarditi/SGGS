using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Identity.Entities
{
    public class AuditLogAuthentication
    {
        public int Id { get; set; }
        public required string UserId { get; set; } // Relacionado con Identity
        public required string UserName { get; set; }
        public required string UserEmail { get; set; }
        public required string UserRole { get; set; }
        public required string Action { get; set; } // "Inicio de sesión" o "Cierre de sesión"
        public required DateTime Timestamp { get; set; }
        public TimeSpan? SessionDuration { get; set; } // Duración de la sesión (solo para Logout)
    }
}
