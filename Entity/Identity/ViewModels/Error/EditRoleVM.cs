using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Identity.ViewModels.Error
{
    public class EditRoleVM
    {
        [Required]
        public string Id { get; set; }
        [Required(ErrorMessage = "El nombre del Rol es requerido")]
        public string RoleName { get; set; }
        public string? Description { get; set; }
        public List<string>? Users { get; set; }
        public List<string>? Claims { get; set; }
    }
}
