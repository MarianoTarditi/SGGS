using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services.Implementation;
using ServiceLayer.Services.Interfaces;

namespace ProyectoWeb.Areas.Admin.Controllers
{
    [Authorize(Roles = "Member,SuperAdmin")]
    public class DashboardController : Controller
    {
        private readonly IDashboardService _dashboardService;
        private readonly IPagoService _pagoService;

        public DashboardController(IDashboardService dashboardService, IPagoService pagoService)
        {
            _dashboardService = dashboardService;
            _pagoService = pagoService;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.Miembros = await _dashboardService.GetAllMiembrosCountAsync();
            ViewBag.Pagos = await _dashboardService.GetAllPagosCountAsync();
            ViewBag.Usuarios =  _dashboardService.GetAllUsersCountAsync();

            var pagos = await _pagoService.GetAllListAsync(); // Asegúrate de que esto devuelve una lista válida
            return View(pagos); // Aquí pasamos la lista de pagos a la vista
        }
    }
}
