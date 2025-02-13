using Entity.Identity.ViewModels;
using FluentValidation;
using ServiceLayer.Messages.Identity;
using ServiceLayer.Messages.WebApplication;

namespace ServiceLayer.FluentValidation.Identity
{
    public class ForgotPasswordValidation : AbstractValidator<ForgotPasswordVM>
    {
        public ForgotPasswordValidation()
        {
            RuleFor(x => x.Email)
              .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("El email"))
              .NotNull().WithMessage(ValidationMessages.NullEmptyMessage("El email"))
              .EmailAddress().WithMessage(IdentityMessages.CheckEmailAddress());
        }
    }
}
