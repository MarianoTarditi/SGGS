using Azure.Core;
using Entity.WebAplication.Entities;
using Entity.WebAplication.ViewModels;
using FluentValidation;
using FluentValidation.AspNetCore;


//using FluentValidation;
//using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NLog.Layouts;
using NToastNotify;
using ServiceLayer.Filters.WebApplication;
using ServiceLayer.Messages.WebApplication;
using ServiceLayer.Services.Implementation;
using ServiceLayer.Services.Interfaces;
using static System.Collections.Specialized.BitVector32;

namespace ProyectoWeb.Areas.Admin.Controllers
{
    [Authorize(Roles = "Member,SuperAdmin")]
    public class MiembrosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        private readonly IMiembroService _miembroService;
        private readonly IOrganismoService _organismoService;
        private readonly IToastNotification _toastNotification;
        private readonly ICuentaCorrienteService _cuentaCorrienteService;
        private readonly IValidator<VMMiembro> _miembroValidator;


        public MiembrosController(IMiembroService miembroService, IOrganismoService oganismoService/*, IValidator<VMMiembro> addValidator*/, IToastNotification toastNotification, ICuentaCorrienteService cuentaCorrienteService, IValidator<VMMiembro> miembroValidator)
        {
            _miembroService = miembroService;
            _organismoService = oganismoService;
            _toastNotification = toastNotification;
            _cuentaCorrienteService = cuentaCorrienteService;
            _miembroValidator = miembroValidator;
        }

        [Authorize(Policy = "CanViewMiembrosPolicy")]
        public async Task<IActionResult> GetMiembroList()
        {
            var miembro = await _miembroService.GetAllListAsync();

            var ramasCount = await _cuentaCorrienteService.GetRamaMiembroAsync();
            ViewBag.RamasCount = ramasCount;

            var categoriaCount = await _cuentaCorrienteService.GetCategoriaMiembroAsync();
            ViewBag.CategoriaCount = categoriaCount;

            var insigniasCount = await _cuentaCorrienteService.GetEducadoresInsigniaAsync();
            ViewBag.MiembroInsigniasCount = insigniasCount;

            return View(miembro);
        }

        [Authorize(Policy = "CanViewExMiembrosPolicy")]
        public async Task<IActionResult> GetExMiembrosList()
        {
            var miembro = await _miembroService.GetAllInactiveListAsync();
            return View(miembro);
        }

        public async Task<IActionResult> GetMiembro(int id)
        {
            var miembro = await _miembroService.GetMiembroById(id);
            if (miembro == null)
            {
                return NotFound();
            }
            else
            {
                return View(miembro);
            }
        }

        [HttpGet]
        [Authorize(Policy = "CanCreateMiembrosPolicy")]
        public async Task<IActionResult> AddMiembro(int? id)
        {
            var provincias = await _organismoService.GetProvinciasAsync();
            var nacionalidades = await _organismoService.GetNacionalidadesAsync();
            var estudios = await _organismoService.GetEstudiosAsync();
            var estadosCiviles = await _organismoService.GetEstadosCivilesAsync();
            var discapacidades = await _organismoService.GetDiscapacidadesAsync();
            var religiones = await _organismoService.GetReligionesAsync();
            var sexos = await _organismoService.GetSexosAsync();
            var idiomas = await _organismoService.GetIdiomasAsync();
            var organismos = await _organismoService.GetAllListAsync();

            var funciones = await _organismoService.GetFunciones();
            var ramas = await _organismoService.GetRamas();
            var categorias = await _organismoService.GetCategorias();


            ViewBag.Provincias = new SelectList(provincias, "Id", "Nombre");
            ViewBag.Nacionalidades = new SelectList(nacionalidades, "Id", "Pais");
            ViewBag.Estudios = new SelectList(estudios, "Id", "Nivel");
            ViewBag.EstadosCiviles = new SelectList(estadosCiviles, "Id", "Nombre");
            ViewBag.Discapacidades = new SelectList(discapacidades, "Id", "Nombre");
            ViewBag.Religiones = new SelectList(religiones, "Id", "Nombre");
            ViewBag.Sexos = new SelectList(sexos, "Id", "Nombre");
            ViewBag.Idiomas = new SelectList(idiomas, "Id", "Nombre");
            ViewBag.Organismos = new SelectList(organismos, "Id", "Nombre");

            ViewBag.Funciones = new SelectList(funciones, "Id", "Nombre");
            ViewBag.Ramas = new SelectList(ramas, "Id", "Nombre");
            ViewBag.Categorias = new SelectList(categorias, "Id", "Nombre");

            if (id.HasValue)
            {
                var miembro = await _miembroService.GetMiembroById(id.Value);

                if (miembro == null)
                {
                    return NotFound();
                }
                return View("AddMiembro", miembro);
            }
            else
            {
                return View("AddMiembro", new VMMiembro());
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddMiembro(VMMiembro entity)
        {
            var validation = await _miembroValidator.ValidateAsync(entity);

            // Cargar los valores de los comboBox siempre, incluso si hay validación
            var provincias = await _organismoService.GetProvinciasAsync();


            var nacionalidades = await _organismoService.GetNacionalidadesAsync();
            var estudios = await _organismoService.GetEstudiosAsync();
            var estadosCiviles = await _organismoService.GetEstadosCivilesAsync();
            var discapacidades = await _organismoService.GetDiscapacidadesAsync();
            var religiones = await _organismoService.GetReligionesAsync();
            var sexos = await _organismoService.GetSexosAsync();
            var idiomas = await _organismoService.GetIdiomasAsync();
            var organismos = await _organismoService.GetAllListAsync();

            var funciones = await _organismoService.GetFunciones();
            var ramas = await _organismoService.GetRamas();
            var categorias = await _organismoService.GetCategorias();

            ViewBag.Provincias = new SelectList(provincias, "Id", "Nombre");
            ViewBag.Nacionalidades = new SelectList(nacionalidades, "Id", "Pais");
            ViewBag.Estudios = new SelectList(estudios, "Id", "Nivel");
            ViewBag.EstadosCiviles = new SelectList(estadosCiviles, "Id", "Nombre");
            ViewBag.Discapacidades = new SelectList(discapacidades, "Id", "Nombre");
            ViewBag.Religiones = new SelectList(religiones, "Id", "Nombre");
            ViewBag.Sexos = new SelectList(sexos, "Id", "Nombre");
            ViewBag.Idiomas = new SelectList(idiomas, "Id", "Nombre");
            ViewBag.Organismos = new SelectList(organismos, "Id", "Nombre");

            ViewBag.Funciones = new SelectList(funciones, "Id", "Nombre");
            ViewBag.Ramas = new SelectList(ramas, "Id", "Nombre");
            ViewBag.Categorias = new SelectList(categorias, "Id", "Nombre");

            if (validation.IsValid)
            {
                if (entity.Id > 0) // Si tiene ID, actualizar
                {
                    await _miembroService.UpdateEntityAsync(entity);
                }
                else // Si no tiene ID, crear nuevo
                {
                    await _miembroService.CreateEntityAsync(entity);
                }

                return RedirectToAction("GetMiembroList", "Miembros", new { Area = "Admin" });
            }

            validation.AddToModelState(this.ModelState);

            ViewBag.OrganismoId = 1; // Asegurar que OrganismoId no sea null en la vista
            return View(entity);
        }

        [HttpGet]
        public async Task<IActionResult> GetLocalidades(int provinciaId)
        {
            if (provinciaId <= 0)
            {
                return BadRequest("El ID de provincia es inválido.");
            }

            var localidades = await _miembroService.GetLocalidadesByProvinciaAsync(provinciaId);
            return Json(localidades);
        }

        [Authorize(Policy = "CanViewOrganismoPolicy")]
        public async Task<IActionResult> DeleteMiembro(int id)
        {
            // Si el usuario no tiene el rol necesario, muestra un mensaje y redirige
            if (!User.IsInRole("SuperAdmin"))
            {
                _toastNotification.AddWarningToastMessage("No tienes permiso para realizar esta acción", new ToastrOptions { Title = NotificationMessagesWebApplication.FailedTitle });

                return RedirectToAction("GetMiembroList", "Miembros", new { Area = "Admin" });
            }
            else
            {
                await _miembroService.DeleteEntityAsync(id);
                return RedirectToAction("GetMiembroList", "Miembros", new { Area = "Admin" });
            }
        }

    }
}
