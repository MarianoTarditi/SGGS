using Entity.Identity.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using ServiceLayer.Messages.Identity;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Security;
namespace ServiceLayer.Middlewares.Identity
{
    //Este código pertenece a un middleware en ASP.NET Core, diseñado para verificar y validar el SecurityStamp de un usuario en cada solicitud HTTP. El SecurityStamp es un valor utilizado para proteger las sesiones de usuario, y este middleware se asegura de que el SecurityStamp de la cookie del usuario coincida con el almacenado en el servidor.

    public class SecurityStampCheck
    {
        // Definición de un delegado para el siguiente middleware en la cadena de ejecución
        private readonly RequestDelegate _next;

        // Constructor de la clase que recibe el siguiente middleware a ejecutar
        public SecurityStampCheck(RequestDelegate next)
        {
            _next = next;
        }

        // Método Invoke que será ejecutado para cada solicitud HTTP que pase por el pipeline de ASP.NET
        public async Task Invoke(HttpContext context, UserManager<AppUser> userManager)
        {
            // Si no hay un usuario autenticado (context.User.Identity es null), simplemente pasa al siguiente middleware
            if (context.User.Identity == null)
            {
                await _next(context);  // Llama al siguiente middleware en la cadena de ejecución
                return;  // Termina la ejecución de este middleware
            }

            // Si el usuario está autenticado
            if (context.User.Identity.IsAuthenticated)
            {
                // Recupera el valor del SecurityStamp desde los claims del usuario en la cookie
                var ssCookie = context.User.Claims.FirstOrDefault(x => x.Type.Contains("SecurityStamp"))!.Value;

                // Obtiene el objeto AppUser correspondiente al usuario autenticado en la base de datos
                var user = await userManager.GetUserAsync(context.User);

                // Compara el SecurityStamp de la cookie con el SecurityStamp del usuario en la base de datos
                if (ssCookie != user!.SecurityStamp)
                {
                    // Si los SecurityStamps no coinciden, significa que la sesión del usuario es inválida

                    // Elimina la cookie "PlumbingCompany" (probablemente una cookie de sesión)
                    context.Response.Cookies.Delete("PlumbingCompany");

                    // Codifica el mensaje de error que será mostrado al usuario y lo pasa como parámetro en la URL
                    string encodedErrorMessage = Uri.EscapeDataString(IdentityMessages.SecurityStampError);

                    // Redirige al usuario a la página de inicio de sesión, pasando el mensaje de error
                    context.Response.Redirect($"/Authentication/logIn?errorMessage={encodedErrorMessage}");
                }
            }

            // Llama al siguiente middleware en la cadena, después de haber realizado la validación del SecurityStamp
            await _next(context);  // Continua con la ejecución de la solicitud
            return;  // Finaliza la ejecución del middleware
        }
    }

}
