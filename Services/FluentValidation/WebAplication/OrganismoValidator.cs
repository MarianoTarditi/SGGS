using Entity.WebAplication.ViewModels;
using FluentValidation;
using ServiceLayer.Messages.Identity;
using ServiceLayer.Messages.WebApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.FluentValidation.WebAplication
{
    public class OrganismoValidator : AbstractValidator<VMOrganismo>
    {
        public OrganismoValidator()
        {
            RuleFor(x => x.Nombre)
               .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("El nombre"))
               .MaximumLength(30).WithMessage(ValidationMessages.MaximumCharachterAllowence("El nombre", 30));

            RuleFor(x => x.CodigoPostal)
             .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("El código postal"))
             .NotNull().WithMessage(ValidationMessages.NullEmptyMessage("El código postal"))
             .InclusiveBetween(1000, 9999).WithMessage("El código postal debe tener 4 dígitos.");

            RuleFor(x => x.Telefono)
                .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("El teléfono"))
                .NotNull().WithMessage(ValidationMessages.NullEmptyMessage("El teléfono"))
                .Must(t => t.ToString().All(char.IsDigit)) // Verificar que todos los caracteres sean dígitos
                .WithMessage("El teléfono debe contener solo números y tener entre 7 y 15 dígitos.")
                .Must(t => t >= 1000000 && t <= 999999999999999) // Validar el rango de 7 a 15 dígitos
                .WithMessage("El teléfono debe tener entre 7 y 15 dígitos.");

            RuleFor(x => x.Celular)
                .Must(t => t.ToString().All(char.IsDigit)) // Verificar que todos los caracteres sean dígitos
                .WithMessage("El celular debe contener solo números y tener entre 7 y 15 dígitos.")
                .Must(t => t >= 1000000 && t <= 999999999999999) // Validar el rango de 7 a 15 dígitos
                .WithMessage("El celular debe tener entre 7 y 15 dígitos.");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("El email"))
                .NotNull().WithMessage(ValidationMessages.NullEmptyMessage("El email"))
                .MaximumLength(50).WithMessage(ValidationMessages.MaximumCharachterAllowence("El email", 50))
                .EmailAddress().WithMessage(IdentityMessages.CheckEmailAddress());


            RuleFor(x => x.Descripcion)
                .MaximumLength(1000).WithMessage(ValidationMessages.MaximumCharachterAllowence("La descripción", 1000));

            RuleFor(x => x.ProvinciaId)
                .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("La provincia"))
                .NotNull().WithMessage(ValidationMessages.NullEmptyMessage("La provincia"));

            RuleFor(x => x.LocalidadId)
                .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("La localidad"))
                .NotNull().WithMessage(ValidationMessages.NullEmptyMessage("La localidad"));

            RuleFor(x => x.Direccion)
               .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("El nombre"))
               .MaximumLength(100).WithMessage(ValidationMessages.MaximumCharachterAllowence("El nombre", 50));

            RuleFor(x => x.Latitud)
               .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("El nombre"))
               .MaximumLength(100).WithMessage(ValidationMessages.MaximumCharachterAllowence("El nombre", 50));

            RuleFor(x => x.Longitud)
               .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("El nombre"))
               .MaximumLength(100).WithMessage(ValidationMessages.MaximumCharachterAllowence("El nombre", 50));

                    RuleFor(x => x.ValorAfiliacion)
            .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("La afiliación"))
            .NotNull().WithMessage(ValidationMessages.NullEmptyMessage("La afiliación"))
            .GreaterThan(0).WithMessage("La afiliación debe ser mayor que 0.");

            RuleFor(x => x.ValorSeguro)
                .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("El seguro de acompañante"))
                .NotNull().WithMessage(ValidationMessages.NullEmptyMessage("El seguro de acompañante"))
                .GreaterThan(0).WithMessage("El seguro de acompañante debe ser mayor que 0.");

        }
    }
}
