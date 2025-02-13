using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Identity.ViewModels
{
    public class UserVM
    {
        public string UserName { get; set; } = null!;
        public string Email { get; set; } = null!;

        public IList<string> UserRoles { get; set; } = null!;
        public IList<Claim>? UserClaims { get; set; }
        public string? Role { get; set; }
        public string Roles { get; set; } = string.Empty;
    }
}
