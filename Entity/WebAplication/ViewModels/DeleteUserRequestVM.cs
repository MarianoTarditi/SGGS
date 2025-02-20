using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.WebAplication.ViewModels
{
    public class DeleteUserRequestVM
    {
        public string UserName { get; set; } // Usuario a eliminar
        public string? UserId { get; set; } // (Opcional) ID del usuario en el sistema
        public string? RequestedBy { get; set; } // (Opcional) Quién realizó la solicitud
        public string? Reason { get; set; } // (Opcional) Motivo de la eliminación
        public bool ConfirmDelete { get; set; } // Confirmación de eliminación
    }
}
