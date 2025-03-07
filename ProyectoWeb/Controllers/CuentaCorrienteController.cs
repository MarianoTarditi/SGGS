using Entity.WebAplication.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services.Implementation;
using ServiceLayer.Services.Interfaces;

namespace ProyectoWeb.Controllers
{
    [Authorize(Roles = "SuperAdmin,Member")]
    public class CuentaCorrienteController : Controller
    {
        private readonly ICuentaCorrienteService _cuentaCorrienteService;
        private readonly IOrganismoService _organismoService;
        private readonly IPagoService _pagoService;


        public CuentaCorrienteController(ICuentaCorrienteService cuentaCorrienteService, IOrganismoService organismoService, IPagoService pagoService)
        {
            _cuentaCorrienteService = cuentaCorrienteService;
            _organismoService = organismoService;
            _pagoService = pagoService;
        }

        [Authorize(Policy = "CanViewCuentaCorrientePolicy")]
        public async Task<IActionResult> Index(DateTime? startDate, DateTime? endDate)
        {
            var categoriasCount = await _cuentaCorrienteService.GetCategoriaMiembroAsync();
            var funcionesCount = await _cuentaCorrienteService.GetFuncionMiembroAsync();
            var ramasCount = await _cuentaCorrienteService.GetRamaMiembroAsync();
            var religionesCount = await _cuentaCorrienteService.GetReligionMiembroAsync();

            if (startDate == null) startDate = DateTime.Today.AddDays(-14); // Rango por defecto
            if (endDate == null) endDate = DateTime.Today;

            // Pasar las fechas a la vista para que se mantengan seleccionadas
            ViewBag.StartDate = startDate?.ToString("yyyy-MM-dd");
            ViewBag.EndDate = endDate?.ToString("yyyy-MM-dd");

            // Obtener la cantidad de pagos por día
            var pagosPorDiaTuple = await _cuentaCorrienteService.GetPagosPorDia(startDate.Value, endDate.Value);
            Dictionary<string, int> pagosPorDia = pagosPorDiaTuple.Item1;
            int maxPagos = pagosPorDiaTuple.Item2;

            // Pasar los datos al ViewBag
            ViewBag.PagosCount = pagosPorDia;
            ViewBag.MaxPagos = maxPagos;

            // Obtener el monto total de pagos por día
            var montoPagosPorDiaTuple = await _cuentaCorrienteService.GetMontoTotalPorDia(startDate.Value, endDate.Value);
            Dictionary<string, decimal> montosPorDia = montoPagosPorDiaTuple.Item1;
            decimal maxMonto = montoPagosPorDiaTuple.Item2; // Aquí debería ser decimal, no int

            // Pasar los datos al ViewBag con nombres diferentes para evitar sobrescribir
            ViewBag.MontosCount = montosPorDia;
            ViewBag.MaxMonto = maxMonto;




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

