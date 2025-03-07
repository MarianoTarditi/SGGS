using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Identity.Entities;
using Microsoft.AspNetCore.Identity;

namespace Entity.Identity.Entities
{
    public class AppRole : IdentityRole
    {
        public string? Description { get; set; }
    }
}

