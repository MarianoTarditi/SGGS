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
    public class MiembroValidation : AbstractValidator<VMMiembro>
    {
        public MiembroValidation()
        {
            RuleFor(x => x.Nombre)
                .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("El nombre"))
                .MaximumLength(30).WithMessage(ValidationMessages.MaximumCharachterAllowence("El nombre", 30));

            RuleFor(x => x.Apellido)
                .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("El apellido"))
                .MaximumLength(30).WithMessage(ValidationMessages.MaximumCharachterAllowence("El apellido", 30));

            RuleFor(x => x.Dni)
                .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("El dni"))
                .NotNull().WithMessage(ValidationMessages.NullEmptyMessage("El dni"))
                .Matches(@"^\d{7,8}$").WithMessage("Ingrese un Dni váildo.");


            RuleFor(x => x.CodigoPostal)
             .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("El código postal"))
             .NotNull().WithMessage(ValidationMessages.NullEmptyMessage("El código postal"))
             .InclusiveBetween(1000, 9999).WithMessage("El código postal debe tener 4 dígitos.");

            RuleFor(x => x.Telefono)
                .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("El teléfono"))
                .NotNull().WithMessage(ValidationMessages.NullEmptyMessage("El teléfono"))
                .Must(t => t.HasValue && t.Value.ToString().All(char.IsDigit))
                .WithMessage("El teléfono debe contener solo números y tener entre 7 y 15 dígitos.")
                .Must(t => t.HasValue && t.Value >= 1000000 && t.Value <= 999999999999999)
                .WithMessage("El teléfono debe tener entre 7 y 15 dígitos.");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("El email"))
                .NotNull().WithMessage(ValidationMessages.NullEmptyMessage("El email"))
                .MaximumLength(50).WithMessage(ValidationMessages.MaximumCharachterAllowence("El email", 50))
                .EmailAddress().WithMessage(IdentityMessages.CheckEmailAddress());

            RuleFor(x => x.DescripcionDiscapacidad)
                .MaximumLength(1000).WithMessage(ValidationMessages.MaximumCharachterAllowence("La descripción", 1000));

            RuleFor(x => x.Titulo)
                .MaximumLength(50).WithMessage(ValidationMessages.MaximumCharachterAllowence("El título", 50));

            RuleFor(x => x.FechaNacimiento)
                .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("La fecha de nacimiento"))
                .NotNull().WithMessage(ValidationMessages.NullEmptyMessage("La fecha de nacimiento"))
                .Must(BeValidAge).WithMessage("Ingrese una fecha válida");

            RuleFor(x => x.EstadoCivilId)
                .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("El estado civil"))
                .NotNull().WithMessage(ValidationMessages.NullEmptyMessage("El estado civil"));

            RuleFor(x => x.ReligionId)
                .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("La religión"))
                .NotNull().WithMessage(ValidationMessages.NullEmptyMessage("La religión"));

            RuleFor(x => x.IdiomaId)
                .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("El idioma"))
                .NotNull().WithMessage(ValidationMessages.NullEmptyMessage("El idioma"));

            RuleFor(x => x.SexoId)
                .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("El sexo"))
                .NotNull().WithMessage(ValidationMessages.NullEmptyMessage("El sexo"));

            RuleFor(x => x.NacionalidadId)
                .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("La nacionalidad"))
                .NotNull().WithMessage(ValidationMessages.NullEmptyMessage("La nacionalidad"));

            RuleFor(x => x.ProvinciaId)
                .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("La provincia"))
                .NotNull().WithMessage(ValidationMessages.NullEmptyMessage("La provincia"));

            RuleFor(x => x.LocalidadId)
                .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("La localidad"))
                .NotNull().WithMessage(ValidationMessages.NullEmptyMessage("La localidad"));

            RuleFor(x => x.EstudioId)
                .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("EL estudio"))
                .NotNull().WithMessage(ValidationMessages.NullEmptyMessage("El estudio"));

            RuleFor(x => x.OrganismoId)
                .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("El organismo"))
                .NotNull().WithMessage(ValidationMessages.NullEmptyMessage("El organismo"));

            RuleFor(x => x.CategoriaId)
                .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("La categoria"))
                .NotNull().WithMessage(ValidationMessages.NullEmptyMessage("La categoria"));
        }

        private bool BeValidAge(DateTime? fechaNacimiento)
        {
            if (!fechaNacimiento.HasValue)
            {
                return false; // En caso de que no se haya proporcionado fecha de nacimiento
            }

            var edad = DateTime.Today.Year - fechaNacimiento.Value.Year;

            // Ajustar si no ha pasado el cumpleaños este año
            if (fechaNacimiento.Value.Date > DateTime.Today.AddYears(-edad)) edad--;

            return edad >= 3 && edad <= 100;
        }
    }
}
