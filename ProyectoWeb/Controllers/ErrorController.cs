using CoreLayer.Models;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ServiceLayer.Exception.WebApplication;

namespace ProyectoWeb.Controllers
{
    public class ErrorController : Controller
    {
        private readonly ILogger<ErrorController> _logger;

        public ErrorController(ILogger<ErrorController> logger)
        {
            _logger = logger;
        }

        public IActionResult GeneralExceptions()
        {
            var exceptions = HttpContext.Features.Get<IExceptionHandlerFeature>()!.Error;

            if (exceptions is ClientSideExceptions)
                return View(new ErrorVM("Tus datos han sido cambiados. Por favor inténtalo de nuevo más tarde.", 401));

            if (exceptions.InnerException is SqlException sqlException && sqlException.Number == 547)
                return View(new ErrorVM("Tienes que eliminar todos los datos relevantes antes de continuar.", 401));

            _logger.LogError("El mensaje de error del sistema : -----" + exceptions.Message + "-----");
            return View(new ErrorVM("Error del servidor. Por favor habla con tu administrador.", 500));
        }

        public IActionResult PageNotFound()
        {
            return View();
        }
    }
}
