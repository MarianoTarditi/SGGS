using Entity.Identity.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace ServiceLayer.Requirement
{
    public class AdminObserverRequirement : IAuthorizationRequirement
    {
    }

    public class AdminObserverRequirementHandler : AuthorizationHandler<AdminObserverRequirement>
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public AdminObserverRequirementHandler(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        protected override async Task HandleRequirementAsync(AuthorizationHandlerContext context, AdminObserverRequirement requirement)
        {
            // Verifica si el usuario tiene el rol de "SuperAdmin". Si es así, satisface el requisito automáticamente.
            var hasSuperAdminRole = context.User.IsInRole("SuperAdmin");
            if (hasSuperAdminRole)
            {
                context.Succeed(requirement);
                return;
            }

            // Busca el reclamo "AdminObserverExpireDate" en el usuario actual.
            var claim = context.User.FindFirst("AdminObserverExpireDate");
            if (claim == null)
            {
                context.Fail();  // Falla si el reclamo no está presente.

                return;
            }

            // Convierte el valor del reclamo en una fecha y verifica si todavía es válida.
            var cookieExpireDate = Convert.ToDateTime(claim.Value);
            if (DateTime.Now < cookieExpireDate)
            {
                context.Succeed(requirement);
                return;
            }

            // Busca al usuario en la base de datos utilizando su nombre de usuario.
            var user = await _userManager.FindByNameAsync(context.User.Identity!.Name!);
            var claims = await _userManager.GetClaimsAsync(user!);

            // Verifica si la fecha de expiración en la base de datos es más reciente que la almacenada en la cookie.
            var dbExpiredate = Convert.ToDateTime(claims.FirstOrDefault(x => x.Type.Contains("Observer"))!.Value);
            if (dbExpiredate > cookieExpireDate)
            {
                // Si la fecha es más reciente, se cierra sesión y se inicia una nueva sesión para actualizar los datos del usuario.
                await _signInManager.SignOutAsync();
                await _signInManager.SignInAsync(user!, isPersistent: false);

                context.Succeed(requirement);
                return;
            }

            context.Fail(); // Si ninguna validación se cumple, falla el contexto de autorización.

            return;
        }
    }
}
