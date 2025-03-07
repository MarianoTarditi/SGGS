using Entity.Identity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Identity.ViewModels
{
    public class RoleClaimsViewModel
    {
        public RoleClaimsViewModel()
        {
            //To Avoid runtime exception, we are initializing the Cliams property
            Claims = new List<RoleClaim>();
        }
        public string RoleId { get; set; }
        public List<RoleClaim> Claims { get; set; }
    }
}
