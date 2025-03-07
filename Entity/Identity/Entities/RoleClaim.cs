using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Identity.Entities
{
    public class RoleClaim
    {
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; } 
        public bool IsSelected { get; set; }
    }
}
