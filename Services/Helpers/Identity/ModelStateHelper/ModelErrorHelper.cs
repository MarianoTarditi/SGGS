using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ServiceLayer.Helpers.Identity.ModelStateHelper
{
    public static class ModelErrorHelper
    {
        // Método para agregar una lista de errores personalizados al estado del modelo.
        public static void AddModelErrorList(this ModelStateDictionary modelState, List<string> errors)
        {
            // Recorre cada error en la lista y lo agrega al estado del modelo.
            foreach (var error in errors)
            {
                modelState.AddModelError(string.Empty, error);
            }
        }

        // Método para agregar una lista de errores de identidad al estado del modelo.
        public static void AddModelErrorList(this ModelStateDictionary modelState, IEnumerable<IdentityError> errors)
        {
            // Recorre cada error de identidad y agrega su descripción al estado del modelo.
            foreach (var error in errors)
            {
                modelState.AddModelError(string.Empty, error.Description);
            }
        }
    }
}
