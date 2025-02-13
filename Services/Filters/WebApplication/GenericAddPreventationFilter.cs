using CoreLayer.BaseEntities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using NToastNotify;
using DAL.UnitOfWork.Interfaces;

namespace ServiceLayer.Filters.WebApplication
{
    public class GenericAddPreventationFilter<T> : IAsyncActionFilter where T : class, IBaseEntity, new()
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IToastNotification _toasty;
       
        public GenericAddPreventationFilter(IToastNotification toasty, IUnitOfWork unitOfWork)
        {
            _toasty = toasty;
            _unitOfWork = unitOfWork;
        }

        // Este método se ejecuta antes de que la acción del controlador sea ejecutada.
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            // Recupera la lista de entidades del repositorio genérico.
            var entityList = await _unitOfWork.GetGenericRepository<T>().GetAllList().ToListAsync();

            
            var methodName = typeof(T).Name; // Nombre de la clase genérica (tipo de entidad) para mostrar un mensaje adecuado.

            // Verifica si ya existe algún registro de esa entidad en la base de datos.
            if (entityList.Any())
            {
                // Si existe al menos un registro, muestra un mensaje de error y redirige al usuario.
                _toasty.AddErrorToastMessage($"You already have an {methodName} Section. Please delete it first and try again later !!", new ToastrOptions { Title = "I am sorry!!" });

                // Redirige al usuario a la lista de esa entidad.
                context.Result = new RedirectToActionResult($"Get{methodName}List", methodName, new { Area = ("Admin") });
                return;
            }
            
            await next.Invoke(); // Si no existe ninguna entidad, permite que la acción continúe.
            return;
        }
    }

}
