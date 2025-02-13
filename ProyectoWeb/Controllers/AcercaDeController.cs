using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ProyectoWeb.Controllers
{
    [Authorize]
    public class AcercaDeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
