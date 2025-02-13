using CoreLayer.BaseEntities;
using Microsoft.AspNetCore.Mvc.Filters;
using DAL.UnitOfWork.Interfaces;
using ServiceLayer.Exception.WebApplication;

namespace ServiceLayer.Filters.WebApplication
{
    public class GenericNotFoundFilter<T> : IAsyncActionFilter where T : class, IBaseEntity, new()
    {
        private readonly IUnitOfWork _unitOfWork;

        public GenericNotFoundFilter(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // Método que se ejecuta antes de la acción del controlador.
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            // Se obtiene el valor del primer argumento de la acción (probablemente el ID de la entidad).
            var value = context.ActionArguments.FirstOrDefault().Value;
      
            if (value == null) // Si el valor es nulo, lanza una excepción indicando que el ID proporcionado no es válido.
            {
                throw new ClientSideExceptions("La entrada no es válida. Por favor intenta utilizar una identificación válida.");
            }
    
            var id = (int)value!; // Convierte el valor a un entero (ID de la entidad).

            var entity = await _unitOfWork.GetGenericRepository<T>().GetEntityByIdAsync(id); // Intenta obtener la entidad del repositorio por su ID.

            
            if (entity == null) // Si la entidad no se encuentra, lanza una excepción indicando que el ID no existe.
            {
                throw new ClientSideExceptions("La identificación no existe. Intente utilizar una identificación existente.");
            }
        
            await next.Invoke(); // Si todo es válido, permite que la acción del controlador continúe.
            return;
        }
    }

}

