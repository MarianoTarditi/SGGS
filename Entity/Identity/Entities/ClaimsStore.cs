using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Identity.Entities
{
    public static class ClaimsStore
    {
        // Definir las constantes para las reclamaciones
        public const string CanViewDashboard = "Ver Dashboard";
        public const string CanViewCuentaCorriente = "Ver Cuenta Corriente";
        public const string CanViewMiembros = "Ver Miembros";
        public const string CanViewExMiembros = "Ver Ex-Miembros";
        public const string VerPagos = "Ver Pagos";
        public const string CanViewOrganismo = "Ver Organismo";
        public const string CanViewUsuarios = "Ver Lista de Usuarios";
        public const string CanViewAyuda = "Ver Ayuda";
        public const string CanViewRoles = "Ver Roles";
        public const string CanViewEsperarAprobacion = "Ver Aprobacion";
        public const string CanViewAuditoriaPolicy = "Ver Auditoria";
        public const string CanViewAuditoriaAuthenticationPolicy = "Ver AuditoriaAuthentication";


        // Agregar
        public const string CanCreateMiembros = "Crear Miembros";
        public const string CanCreatePagos = "Crear Pagos";
        public const string CanCreateRol = "Crear Rol";
        public const string CanAñadirRemoverRoles = "Añadir/Remover Roles";

        // Eliminar
        public const string CanDeleteMiembros = "Eliminar Miembros";
        public const string CanDeleteUser = "Eliminar Usuario";
        public const string CanDeleteRol = "Eliminar Rol";

        // Modificar 
        public const string CanUpdateMiembros = "Modificar Miembros";
        public const string CanUpdateOrganismos = "Modificar Organismo";
        public const string CanUpdateUsuarios = "Modificar Usuario";
        public const string CanUpdateRoles = "Modificar Rol";
        public const string CanUpdateReclamaciones = "Modificar Reclamaciones";

        // Autorizar
        public const string CanAutorizePagos = "Autorizar Pagos";

        // Restaurar
        public const string RestoreExMiembros= "Restaurar Ex-Miembros";

        public static List<Claim> GetAllClaims()
        {
            return new List<Claim>
            {
                new Claim(CanViewDashboard, "Ver Dashboard"),
                new Claim(CanViewCuentaCorriente, "Ver Cuenta Corriente"),
                new Claim(CanViewMiembros, "Ver Miembros"),
                new Claim(CanViewExMiembros, "Ver Ex-Miembros"),
                new Claim(VerPagos, "Ver Pagos"),
                new Claim(CanViewOrganismo, "Ver Organismo"),
                new Claim(CanViewUsuarios, "Ver Lista de Usuarios"),
                new Claim(CanViewAyuda, "Ver Ayuda"),
                new Claim(CanViewRoles, "Ver Roles"),
                new Claim(CanViewAuditoriaPolicy, "Ver Auditoria"),
                new Claim(CanViewAuditoriaAuthenticationPolicy, "Ver AuditoriaAuthentication"),


                // Agregar
                new Claim(CanCreateMiembros, "Crear Miembros"),
                new Claim(CanCreateRol, "Crear Roles"),
                new Claim(CanCreatePagos, "Crear Pagos"),
                new Claim(CanAñadirRemoverRoles, "Añadir/Remover Roles"),

                // Eliminar
                new Claim(CanDeleteMiembros, "Eliminar Miembros"),
                new Claim(CanDeleteRol, "Eliminar Roles"),
                new Claim(CanDeleteUser, "Eliminar Usuarios"),


                // Modificar
                new Claim(CanUpdateMiembros, "Modificar Miembros"),
                new Claim(CanUpdateOrganismos, "Modificar Organismo"),
                new Claim(CanUpdateUsuarios, "Modificar Usuarios"),
                new Claim(CanUpdateRoles, "Modificar Roles"),
                new Claim(CanUpdateReclamaciones, "Modificar Reclamaciones"),

                // Autorizar
                new Claim(CanAutorizePagos, "Autorizar Pagos"),

                // Restaurar
                new Claim(RestoreExMiembros, "Restaurar Ex-Miembros"),

                new Claim(CanViewEsperarAprobacion, "Ver EsperarAprobacionView")
            };
        }
    }
}
