using Microsoft.AspNetCore.Identity;

namespace ServiceLayer.Customization.Identity.ErrorDescriber
{
    public class LocalizationErrorDescriber : IdentityErrorDescriber
    {
        public override IdentityError PasswordRequiresDigit()
        {
            return new() { Code = "NewDigitError", Description = "Las contraseñas deben tener al menos un dígito ('0'-'9')." };
            //return base.PasswordRequiresDigit();
        }

        public override IdentityError PasswordRequiresLower()
        {
            return new() { Code = "NewLowerLettersError", Description = "Las contraseñas deben tener al menos una minúscula ('a'-'z')." };
            //return base.PasswordRequiresLower();
        }

        public override IdentityError PasswordTooShort(int length)
        {
            return new() { Code = "NewTooShortError", Description = "Las contraseñas deben tener al menos 10 caracteres." };
            //return base.PasswordTooShort(length);
        }

        public override IdentityError PasswordRequiresUpper()
        {
            return new() { Code = "NewUpperLettersError", Description = "Las contraseñas deben tener al menos una mayúscula ('A'-'Z')." };
        }

        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new() { Code = "NewAlphanumericLettersError", Description = "Las contraseñas deben tener al menos un carácter no alfanumérico." };
        }

    }
}
