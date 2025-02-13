using Entity.Identity.ViewModels;
using FluentValidation;
using ServiceLayer.Messages.Identity;
using ServiceLayer.Messages.WebApplication;

namespace ServiceLayer.FluentValidation.Identity
{
    public class UserEditValidation : AbstractValidator<UserEditVM>
    {
        public UserEditValidation()
        {
            RuleFor(x => x.Username)
                .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("El nombre de usuario"))
                .NotNull().WithMessage(ValidationMessages.NullEmptyMessage("El nombre de usuario"));
            RuleFor(x => x.Email)
                .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("El email"))
                .NotNull().WithMessage(ValidationMessages.NullEmptyMessage("El email"))
                .EmailAddress().WithMessage(IdentityMessages.CheckEmailAddress());
            RuleFor(x => x.Password)
                .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("La contraseña"))
                .NotNull().WithMessage(ValidationMessages.NullEmptyMessage("La contraseña"));
            RuleFor(x => x.ConfirmNewPassword)
                .Equal(x => x.NewPassword).WithMessage(IdentityMessages.ComparePassword());
        }
    }
}
