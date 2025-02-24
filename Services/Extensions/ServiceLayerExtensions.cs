using DAL.UnitOfWork.Implementation;
using DAL.UnitOfWork.Interfaces;
using FluentValidation.AspNetCore;
using FluentValidation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ServiceLayer.Extensions.Identity;
using ServiceLayer.Helpers.Generic.Image;
using ServiceLayer.Services.Implementation;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ServiceLayer.Extensions.WebApplication;
using DAL.Context;
using Entity.Identity.ViewModels;
using ServiceLayer.FluentValidation.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Hosting;
using Entity.WebAplication.ViewModels;
using ServiceLayer.FluentValidation.WebAplication;

namespace ServiceLayer.Extensions
{
    public static class ServiceLayerExtensions
    {
        public static IServiceCollection LoadServiceLayerExtensions(this IServiceCollection services, IConfiguration config)
        {
            services.LoadIdentityExtensions(config);
            services.LoadWebApplicationExtensions();

            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddDbContext<dbContext>();

            services.AddTransient<IValidator<SignUpVM>, SignUpValidation>();
            services.AddTransient<IValidator<LogInVM>, LogInValidation>();
            services.AddTransient<IValidator<ForgotPasswordVM>, ForgotPasswordValidation>();
            services.AddTransient<IValidator<ResetPasswordVM>, ResetPasswordValidation>();
            services.AddTransient<IValidator<UserEditVM>, UserEditValidation>();
            services.AddTransient<IValidator<VMMiembro>, MiembroValidation>();
            services.AddTransient<IValidator<VMOrganismo>, OrganismoValidator>();

            services.AddScoped<ICuentaCorrienteService, CuentaCorrienteService>();
            services.AddScoped<IDashboardService, DashboardService>();
            services.AddScoped<IDeudaService, DeudaService>();
            services.AddScoped<IOrganismoService, OrganismoService>();

            var types = Assembly.GetExecutingAssembly().GetTypes().Where(c => c.IsClass && !c.IsAbstract && c.Name.EndsWith("Service"));

            foreach (var serviceType in types)
            {
                var iserviceType = serviceType.GetInterfaces().FirstOrDefault(c => c.Name == $"I{serviceType.Name}");
                
                if(iserviceType != null)
                {
                    services.AddScoped(iserviceType, serviceType);
                }
            }

            services.AddFluentValidationAutoValidation(opt =>
            {
                opt.DisableDataAnnotationsValidation = true;
            });

            //services.AddValidatorsFromAssemblyContaining<HomePageAddValidation>();

            services.AddScoped<IImageHelper, ImageHelper>();

            return services;
        }
    }
}
