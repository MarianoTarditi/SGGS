using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ProyectoWeb.Controllers
{
    public class HelpController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}
