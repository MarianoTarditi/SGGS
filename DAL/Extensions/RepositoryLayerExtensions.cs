using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using DAL.Context;
using DAL.Repositories.Implementation;
using DAL.Repositories.Interfaces;
using DAL.UnitOfWork.Interfaces;
using DAL.UnitOfWork.Implementation;
using DAL.Enumerators;


namespace DAL.Enumerators
{
    public static class RepositoryLayerExtensions
    {
        public static IServiceCollection LoadRepositoryLayerExtensions(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<DbContext>(opt => opt.UseSqlServer(config.GetConnectionString("SqlConnection")));

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            services.AddScoped<IUnitOfWork, DAL.UnitOfWork.Implementation.UnitOfWork>(); // Reemplaza con el espacio de nombres correcto

            return services;

        }
    }
}
