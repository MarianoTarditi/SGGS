using Entity.Identity.ViewModels;
using FluentValidation;
using ServiceLayer.Messages.Identity;
using ServiceLayer.Messages.WebApplication;

namespace ServiceLayer.FluentValidation.Identity
{
    public class LogInValidation : AbstractValidator<LogInVM>
    {
        public LogInValidation()
        {
            RuleFor(x => x.Email)
               .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("El email"))
               .NotNull().WithMessage(ValidationMessages.NullEmptyMessage("El email"))
               .EmailAddress().WithMessage(IdentityMessages.CheckEmailAddress());
            RuleFor(x => x.Password)
                .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("La contraseña"))
                .NotNull().WithMessage(ValidationMessages.NullEmptyMessage("La contraseña"));
                           
        }
    }
}
