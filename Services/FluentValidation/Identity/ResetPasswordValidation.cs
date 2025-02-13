using Entity.Identity.ViewModels;
using FluentValidation;
using ServiceLayer.Messages.Identity;
using ServiceLayer.Messages.WebApplication;

namespace ServiceLayer.FluentValidation.Identity
{
    public class ResetPasswordValidation : AbstractValidator<ResetPasswordVM>
    {
        public ResetPasswordValidation()
        {
            RuleFor(x => x.Password)
                .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("La contraseña"))
                .NotNull().WithMessage(ValidationMessages.NullEmptyMessage("La ontraseña"));
            RuleFor(x => x.ConfirmPassword)
                .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("Confirmar contraseña"))
                .NotNull().WithMessage(ValidationMessages.NullEmptyMessage("Confirmar contraseña"))
                .Equal(x => x.Password).WithMessage(IdentityMessages.ComparePassword());
        }
    }
}
