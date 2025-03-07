using BLL.Services.Interfaces;
using Entity.Identity.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ProyectoWeb.Controllers
{
    [Authorize(Roles = "SuperAdmin")]
    public class AuditoriaController : Controller
    {
        private readonly IAuditLogService _auditLogService;

        public AuditoriaController(IAuditLogService auditLogService)
        {
            _auditLogService = auditLogService;
        }

        [Authorize(Policy = "CanViewAuditoriaPolicy")]
        public async Task<IActionResult> Index()
        {
            List<AuditLog> logs = await _auditLogService.GetAllLogsAsync(); // Obtener todos los registros

            var accionesMiembros = await _auditLogService.GetAccionesSobreMiembrosAsync();
            ViewBag.AccionesMiembros = accionesMiembros;

            return View(logs);
        }


        [Authorize(Policy = "CanViewAuditoriaAuthenticationPolicy")]
        public async Task<IActionResult> AuditoriaAuhentication()
        {
            List<AuditLogAuthentication> logsAuthentication = await _auditLogService.GetAllLogsAuhtenticationAsync(); // Obtener todos los registros
            return View(logsAuthentication);
        }
    }
}
