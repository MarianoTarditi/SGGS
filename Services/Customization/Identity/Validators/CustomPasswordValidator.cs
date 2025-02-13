using Entity.Identity.Entities;
using Microsoft.AspNetCore.Identity;

namespace ServiceLayer.Customization.Identity.Validators
{
    internal class CustomPasswordValidator : IPasswordValidator<AppUser>
    {
        public Task<IdentityResult> ValidateAsync(UserManager<AppUser> manager, AppUser user, string? password)
        {
            var errors = new List<IdentityError>();

            if (password!.ToLower().Contains(user.UserName!.ToLower()))
            {
                errors.Add(new() { Code = "UsernameContainError", Description = "La contraseña no puede contener su nombre de usuario." });
            }

            if (password.StartsWith("1234"))
            {
                errors.Add(new() { Code = "PasswordStartDigitError", Description = "La contraseña no puede empezar en 1234." });
            }

            if (errors.Any())
            {
                return Task.FromResult(IdentityResult.Failed(errors.ToArray()));
            }

            return Task.FromResult(IdentityResult.Success);
        }
    }
}
