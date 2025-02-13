using Entity.Identity.Entities;
using Entity.Identity.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Helpers.Identity.EmailHelper;
using ServiceLayer.Services.Identity.Abstract;

namespace ServiceLayer.Services.Identity.Concrete
{
    public class AuthenticationMainService : IAuthenticationMainService
    {
        private readonly IEmailSendMethod _email;
        private readonly UserManager<AppUser> _userManager;

        public AuthenticationMainService(IEmailSendMethod email, UserManager<AppUser> userManager)
        {
            _email = email;
            _userManager = userManager;
        }

        public async Task CreateResetCredentialsAndSend(AppUser user, HttpContext context, IUrlHelper url, ForgotPasswordVM request)
        {
            // Genera un token único para el restablecimiento de contraseña del usuario.
            string resetToken = await _userManager.GeneratePasswordResetTokenAsync(user);

            // Crea un enlace para el restablecimiento de contraseña utilizando el token y las rutas proporcionadas.
            var passwordResetLink = url.Action(
                "ResetPassword",            // Acción del controlador que manejará el restablecimiento.
                "Authentication",           // Nombre del controlador.
                new { userId = user.Id, token = resetToken },  // Parámetros para el enlace.
                context.Request.Scheme      // Esquema de URL (http o https).
            );

            // Envía un correo electrónico al usuario con el enlace de restablecimiento de contraseña.
            await _email.SendPasswordResetLinkWithToken(passwordResetLink!, request.Email);
        }

    }
}
