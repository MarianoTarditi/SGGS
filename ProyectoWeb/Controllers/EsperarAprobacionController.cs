using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ProyectoWeb.Controllers
{
    public class EsperarAprobacionController : Controller
    {
        [Authorize(Policy = "CanViewEsperarAprobacionPolicy")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
