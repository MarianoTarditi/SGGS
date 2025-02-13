using Entity.Identity.Entities;
using Microsoft.AspNetCore.Identity;

namespace ServiceLayer.Customization.Identity.Validators
{
    public class CustomUserValidator : IUserValidator<AppUser>
    {
        public Task<IdentityResult> ValidateAsync(UserManager<AppUser> manager, AppUser user)
        {
            var errors = new List<IdentityError>();

            
            var isNumeric = int.TryParse(user.UserName![0].ToString(), out _); // Validación para que el nombre de usuario no comience con un dígito
            if (isNumeric)
            {
                // Si el nombre de usuario comienza con un dígito, se agrega un error
                errors.Add(new() { Code = "StartWithDigitError", Description = "El nombre de usuario no puede comenzar con un dítigto" });
            }
            
            if (errors.Any()) // Si hay errores, se devuelve un resultado fallido
            {
                return Task.FromResult(IdentityResult.Failed(errors.ToArray()));
            }
      
            return Task.FromResult(IdentityResult.Success); // Si no hay errores, se devuelve un resultado exitoso
        }
    }

}
