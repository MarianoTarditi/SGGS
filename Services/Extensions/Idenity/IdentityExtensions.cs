using Entity.Identity.Entities;
using Entity.Identity.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using DAL.Context;
using ServiceLayer.Customization.Identity.ErrorDescriber;
using ServiceLayer.Customization.Identity.Validators;
using ServiceLayer.Helpers.Identity.EmailHelper;
using ServiceLayer.Requirement;

namespace ServiceLayer.Extensions.Identity
{
    public static class IdentityExtensions
    {
        public static IServiceCollection LoadIdentityExtensions(this IServiceCollection services, IConfiguration config)
        {
            // Configuración de Identity para AppUser y AppRole
            services.AddIdentity<AppUser, AppRole>(opt =>
            {
                // Configuración de la contraseña
                opt.Password.RequiredLength = 10; // Longitud mínima de la contraseña
                opt.Password.RequireNonAlphanumeric = true; // Requiere al menos un carácter no alfanumérico
                opt.Password.RequiredUniqueChars = 2; // Requiere al menos 2 caracteres únicos

                // Configuración del email
                opt.User.RequireUniqueEmail = true; // Requiere que cada usuario tenga un email único

                // Configuración del bloqueo de cuenta
                opt.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromSeconds(60); // Tiempo de bloqueo por defecto
                opt.Lockout.MaxFailedAccessAttempts = 3; // Número máximo de intentos fallidos antes de bloquear la cuenta
            })
            .AddRoleManager<RoleManager<AppRole>>() // Agrega el manejador de roles
            .AddEntityFrameworkStores<dbContext>() // Configura el almacenamiento con Entity Framework
            .AddDefaultTokenProviders() // Agrega proveedores de tokens por defecto (como el de restablecimiento de contraseñas)
            .AddErrorDescriber<LocalizationErrorDescriber>() // Personaliza los mensajes de error
            .AddPasswordValidator<CustomPasswordValidator>() // Agrega un validador personalizado de contraseñas
            .AddUserValidator<CustomUserValidator>(); // Agrega un validador personalizado de usuarios

            
            services.ConfigureApplicationCookie(opt => // Configuración de cookies para la autenticación
            {
                var newCookie = new CookieBuilder();
                newCookie.Name = "PlumbingCompany"; // Nombre de la cookie
                opt.LoginPath = new PathString("/Authentication/LogIn"); // Ruta para el login
                opt.LogoutPath = new PathString("/Authentication/LogOut"); // Ruta para el logout
                opt.AccessDeniedPath = new PathString("/Authentication/AccessDenied"); // Ruta para acceso denegado
                opt.Cookie = newCookie; // Asigna la cookie personalizada
                opt.ExpireTimeSpan = TimeSpan.FromMinutes(60); // Tiempo de expiración de la cookie
            });

            
            services.Configure<DataProtectionTokenProviderOptions>(opt => // Configuración del token de protección
            {
                opt.TokenLifespan = TimeSpan.FromMinutes(10); // Tiempo de vida del token
                // este es el tiempo que tiene el usuario para cambiar su contraseña en el mail
            });

            // Registro de servicios personalizados
            services.AddScoped<IEmailSendMethod, EmailSendMethod>(); // Registro del servicio de envío de emails
            services.Configure<GmailInformationVM>(config.GetSection("EmailSettings")); // Configuración de los datos de Gmail desde el archivo de configuración

            services.AddScoped<IAuthorizationHandler, AdminObserverRequirementHandler>(); // Registro del manejador de autorización personalizado

            
            services.AddAuthorization(options => // Configuración de políticas de autorización
            {
                options.AddPolicy("AdminObserver", policy =>
                {
                    policy.AddRequirements(new AdminObserverRequirement()); // Requerimientos de la política de "AdminObserver"
                });
            });
           
            services.Configure<SecurityStampValidatorOptions>(opt => // Configuración de la validación del sello de seguridad
            {
                opt.ValidationInterval = TimeSpan.FromMinutes(30); // Intervalo de validación del sello de seguridad
            });

            return services;
        }
    }
}
