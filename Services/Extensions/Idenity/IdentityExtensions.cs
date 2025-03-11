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
            //services.AddScoped<IAuthorizationHandler, PermissionAuthorizationService>(); // Registro del manejador de autorización personalizado


            services.AddAuthorization(options =>
            {
                // Agregar cada permiso como una política específica
                options.AddPolicy("CanViewDashboardPolicy", policy => policy.RequireClaim("Ver Dashboard"));
                options.AddPolicy("CanViewCuentaCorrientePolicy", policy => policy.RequireClaim("Ver Cuenta Corriente"));
                options.AddPolicy("CanViewMiembrosPolicy", policy => policy.RequireClaim("Ver Miembros"));
                options.AddPolicy("CanViewExMiembrosPolicy", policy => policy.RequireClaim("Ver Ex-Miembros"));
                options.AddPolicy("CanViewPagosPolicy", policy => policy.RequireClaim("Ver Pagos"));
                options.AddPolicy("CanViewOrganismoPolicy", policy => policy.RequireClaim("Ver Organismo"));
                options.AddPolicy("CanViewUsuariosPolicy", policy => policy.RequireClaim("Ver Lista de Usuarios"));
                options.AddPolicy("CanViewAyudaPolicy", policy => policy.RequireClaim("Ver Ayuda"));
                options.AddPolicy("CanViewRolesPolicy", policy => policy.RequireClaim("Ver Roles"));
                options.AddPolicy("CanViewEsperarAprobacionPolicy", policy => policy.RequireClaim("Ver EsperarAprobacionView"));
                options.AddPolicy("CanViewAuditoriaPolicy", policy => policy.RequireClaim("Ver Auditoria"));
                options.AddPolicy("CanViewAuditoriaAuthenticationPolicy", policy => policy.RequireClaim("Ver AuditoriaAuthentication"));


                options.AddPolicy("CanCreateMiembrosPolicy", policy => policy.RequireClaim("Crear Miembros"));
                options.AddPolicy("CanCreatePagosPolicy", policy => policy.RequireClaim("Crear Pagos"));
                options.AddPolicy("CanCreateRolPolicy", policy => policy.RequireClaim("Crear Roles"));
                options.AddPolicy("CanAñadirRemoverRolesPolicy", policy => policy.RequireClaim("Añadir/Remover Roles"));

                options.AddPolicy("CanDeleteMiembrosPolicy", policy => policy.RequireClaim("Eliminar Miembros"));
                options.AddPolicy("CanDeleteUserPolicy", policy => policy.RequireClaim("Eliminar Usuarios"));
                options.AddPolicy("CanDeleteRolPolicy", policy => policy.RequireClaim("Eliminar Roles"));

                options.AddPolicy("CanUpdateMiembrosPolicy", policy => policy.RequireClaim("Modificar Miembros"));
                options.AddPolicy("CanUpdateOrganismosPolicy", policy => policy.RequireClaim("Modificar Organismo"));
                options.AddPolicy("CanUpdateUsuariosPolicy", policy => policy.RequireClaim("Modificar Usuarios"));
                options.AddPolicy("CanUpdateRolesPolicy", policy => policy.RequireClaim("Modificar Roles"));
                options.AddPolicy("CanUpdateReclamacionesPolicy", policy => policy.RequireClaim("Modificar Reclamaciones"));
                options.AddPolicy("CanUpdateRolUsuario", policy => policy.RequireClaim("Modificar Rol Usuarios"));

                options.AddPolicy("CanAutorizePagosPolicy", policy => policy.RequireClaim("Autorizar Pagos"));

                options.AddPolicy("RestoreExMiembrosPolicy", policy => policy.RequireClaim("Restaurar Ex-Miembros"));


            });


            services.Configure<SecurityStampValidatorOptions>(opt => // Configuración de la validación del sello de seguridad
            {
                opt.ValidationInterval = TimeSpan.FromMinutes(30); // Intervalo de validación del sello de seguridad
            });

            return services;
        }
    }
}
