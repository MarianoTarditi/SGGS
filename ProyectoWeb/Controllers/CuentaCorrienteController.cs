using Entity.WebAplication.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services.Implementation;
using ServiceLayer.Services.Interfaces;

namespace ProyectoWeb.Controllers
{
    [Authorize(Roles = "SuperAdmin")]
    public class CuentaCorrienteController : Controller
    {
        private readonly ICuentaCorrienteService _cuentaCorrienteService;
        private readonly IOrganismoService _organismoService;


        public CuentaCorrienteController(ICuentaCorrienteService cuentaCorrienteService, IOrganismoService organismoService)
        {
            _cuentaCorrienteService = cuentaCorrienteService;
            _organismoService = organismoService;
        }

        public async Task<IActionResult> Index()
        {
            var categoriasCount = await _cuentaCorrienteService.GetCategoriaMiembroAsync();
            var funcionesCount = await _cuentaCorrienteService.GetFuncionMiembroAsync();
            var ramasCount = await _cuentaCorrienteService.GetRamaMiembroAsync();
            var religionesCount = await _cuentaCorrienteService.GetReligionMiembroAsync();

            var (saldoAfiliacion, saldoSeguro, saldoTotal, debito, credito, debitoAfiliacion, debitoSeguro, creditoAfiliacion, CreditoSeguro) = await _cuentaCorrienteService.ObtenerSaldoTotal();

            ViewBag.SaldoTotal = saldoTotal;
            ViewBag.SaldoAfiliacion = saldoAfiliacion;
            ViewBag.SaldoSeguroAcompañante = saldoSeguro;

            ViewBag.Debito = debito;
            ViewBag.DebitoAfiliacion = debitoAfiliacion;
            ViewBag.DebitoSeguro = debitoSeguro;

            ViewBag.Credito = credito;
            ViewBag.CreditoAfiliacion = creditoAfiliacion;
            ViewBag.CreditoSeguro = CreditoSeguro;

            ViewBag.CategoriasCount = categoriasCount;
            ViewBag.FuncionesCount = funcionesCount;
            ViewBag.RamasCount = ramasCount;
            ViewBag.ReligionesCount = religionesCount;

            var (valorAfiliacion, valorSeguro) = await _organismoService.GetPreciosAfiliacionesAsync();

            ViewBag.PrecioAfiliacion = valorAfiliacion;
            ViewBag.PrecioSeguro = valorSeguro;

            return View(); 
        }

        [HttpPost]
        public IActionResult ActualizarPrecio([FromBody] PrecioUpdateRequest request)
        {
            try
            {
                if (request == null || request.Precio <= 0)
                {
                    return Json(new { success = false, message = "Datos inválidos." });
                }

                bool actualizado = _cuentaCorrienteService.ActualizarPrecio(request.Tipo, request.Precio);

                if (!actualizado)
                {
                    return Json(new { success = false, message = "No se pudo actualizar el precio." });
                }

                return Json(new { success = true });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }
    }
}

