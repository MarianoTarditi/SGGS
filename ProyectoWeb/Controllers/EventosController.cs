using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ProyectoWeb.Areas.Admin.Controllers
{
    [Authorize]
    public class EventosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
