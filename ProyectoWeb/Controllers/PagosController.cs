using Entity.WebAplication.Entities;
using Entity.WebAplication.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using ServiceLayer.Services.Implementation;
using ServiceLayer.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using ServiceLayer.Filters.WebApplication;
using ServiceLayer.Messages.Identity;
using Microsoft.AspNetCore.Identity;
using NToastNotify;

namespace ProyectoWeb.Controllers
{
    [Authorize(Roles = "Member,SuperAdmin,AdminObserver")]
    public class PagosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        private readonly IPagoService _pagoService;
        private readonly IMiembroService _miembroService;
        private readonly IToastNotification _toasty;
        private readonly ICuentaCorrienteService _cuentaCorrienteService;


        public PagosController(IPagoService pagoService, IMiembroService miembroService, IToastNotification toasty, ICuentaCorrienteService cuentaCorrienteService)
        {
            _pagoService = pagoService;
            _miembroService = miembroService;
            _toasty = toasty;
            _cuentaCorrienteService = cuentaCorrienteService;
        }

        public async Task<IActionResult> GetPagoList()
        {
            var pago = await _pagoService.GetAllListAsync();

            var estadoPagosCount = await _cuentaCorrienteService.GetEstadosPagosAsync();
            ViewBag.EstadosPagosCount = estadoPagosCount;

            var categoriaPagosCount = await _cuentaCorrienteService.GetCategoriasPagosAsync();
            ViewBag.CategoriasPagosCount = categoriaPagosCount;

            var tipoModalidadPagoCount = await _cuentaCorrienteService.GetModalidadesPagosAsync();
            ViewBag.TipoModalidadPagoCount = tipoModalidadPagoCount;

            return View(pago);
        }



        [HttpGet]
        public IActionResult AddPagoEfectivo(int? id)
        {
            // Crea una nueva instancia de VMPago y pásala a la vista
            return View();
        }

        public async Task<IActionResult> GetPago(int id)
        {
            var estados = await _pagoService.GetEstadosAutorizacionAsync();

            ViewBag.Estados = estados.Select(e => new SelectListItem
            {
                Value = e.Id.ToString(),
                Text = e.Estado
            }).ToList();

            var pago = await _pagoService.GetPagoById(id);

            ViewBag.EstadoActual = pago.Autorizacion?.EstadoAutorizacion.Estado;

            return View(pago);
        }



        [HttpPost]
        public async Task<IActionResult> CambiarEstado([FromBody] VMCambiarEstadoRequest request)
        {
            if (request.IdPago <= 0 || request.NuevoEstadoId <= 0)
            {
                return Json(new { success = false, message = "Datos inválidos.", type = "error" });
            }

            try
            {
                var updateResult = await _pagoService.CambiarEstadoAsync(request.IdPago, request.NuevoEstadoId);
                if (!updateResult)
                {
                    return Json(new { success = false, message = "No se encontró el pago o la autorización.", type = "error" });
                }

                // Este es el mensaje que se enviará al cliente
                return Json(new { success = true, message = "Estado del pago actualizado correctamente.", type = "success" });
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return Json(new { success = false, message = "Ocurrió un error al actualizar el estado.", type = "error" });
            }
        }




        [HttpGet]
        public async Task<IActionResult> ObtenerDetallesMiembro(int miembroId)
        {
            // Llama al servicio asíncrono y espera el resultado
            var miembro = await _miembroService.GetMiembroById(miembroId);


            if (miembro == null)
            {
                return NotFound();
            }

            return Json(new
            {
                miembro.Nombre,
                miembro.Apellido,
                miembro.Dni,
                miembro.Deuda.Tiene,
                miembro.Deuda.FechaVencimiento,
                miembro.Deuda.MontoAfiliacion,
                miembro.Deuda.MontoSeguroAcompañante,
                categoriaMiembro = miembro.Categoria

            });
        }

        [HttpGet]
        public async Task<IActionResult> BuscarMiembroPorDNI(string dni)
        {
            if (string.IsNullOrEmpty(dni))
            {
                return Json(new { success = false, message = "Debe ingresar un DNI válido." });
            }

            var miembro = await _miembroService.GetMiembroConDeudaPorDNI(dni);

            if (miembro == null)
            {
                return Json(new { success = false, message = "No se encontró ningún miembro con ese DNI." });
            }

            return Json(new { success = true, data = miembro });
        }


        [HttpGet]
        public async Task<IActionResult> AddPago(int? id)
        {
            ViewBag.Modalidades = new SelectList(new List<SelectListItem>
            {
                new SelectListItem { Value = "Efectivo", Text = "Efectivo" },
                new SelectListItem { Value = "Deposito", Text = "Depósito" },
                new SelectListItem { Value = "Transferencia", Text = "Transferencia" }
            }, "Value", "Text");

            var modalidades = await _pagoService.GetModalidadesAsync();
            ViewBag.Modalidades = new SelectList(modalidades, "Id", "Tipo");

            var categorias = await _pagoService.GetCategoriasAsync();  // Obtener la lista de países
            ViewBag.Categorias = new SelectList(categorias, "Id", "CategoriaNombre");

            var miembros = await _miembroService.GetMiembrosDeudas();
            ViewBag.MiembrosDeudas = new SelectList(miembros.Select(m => new
            {
                Id = m.Id,
                NombreCompleto = $"{m.Nombre} {m.Apellido}"
            }), "Id", "NombreCompleto");



            if (id.HasValue)
            {
                var pago = await _pagoService.GetPagoById(id.Value);

                pago = await _pagoService.GetPagoById(id.Value);

                if (pago == null)
                {
                    return NotFound();
                }
                return View("AddPago", pago);
            }
            else
            {
                // Crear nuevo organismo
                return View("AddPago", new VMPago());
            }
        }


        [HttpPost]
        public async Task<IActionResult> AddPago(VMPago request, string detalles)
        {
            try
            {
                if (string.IsNullOrEmpty(detalles))
                {
                    return BadRequest("No se recibieron detalles.");
                }
                else
                {
                    var listaDetalles = JsonConvert.DeserializeObject<List<DetallePago>>(detalles);
                    if (listaDetalles.Any(d => d.CategoriaPagoId == null))
                    {
                        return BadRequest("Algunos detalles no tienen una categoría válida.");
                    }

                    if (request.Id > 0)
                    {
                        await _pagoService.UpdateEntityAsync(request);
                    }
                    else
                    {
                        await _pagoService.CreateEntityAsync(request, listaDetalles);
                    }
                    return RedirectToAction("GetPagoList", "Pagos");

                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Error de InvalidOperationException: {ex.Message}");
                return RedirectToAction("AddPago", "Pagos");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error general: {ex.Message}");
                return RedirectToAction("AddPago", "Pagos");
            }

        }


        [HttpGet]
        public async Task<IActionResult> UpdatePago(int id)
        {
            var pago = await _pagoService.GetPagoById(id);
            return View(pago);
        }

        [HttpPost]
        public async Task<IActionResult> UpdatePago(VMPago request)
        {
            await _pagoService.UpdateEntityAsync(request);
            return RedirectToAction("GetPagoList", "Pagos", new { Area = "Admin" });
        }

        public async Task<IActionResult> DeletePago(int id)
        {
            await _pagoService.DeleteEntityAsync(id);
            return RedirectToAction("GetPagoList", "Pagos", new { Area = "Admin" });
        }
    }
}
