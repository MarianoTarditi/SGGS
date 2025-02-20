using Azure.Core;
using Entity.WebAplication.Entities;
using Entity.WebAplication.ViewModels;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ServiceLayer.Filters.WebApplication;
using ServiceLayer.Services.Implementation;
using ServiceLayer.Services.Interfaces;
using static iText.IO.Util.IntHashtable;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;

namespace ProyectoWeb.Areas.Admin.Controllers
{
    [Authorize(Roles = "SuperAdmin")]
    public class OrganismoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        private readonly IOrganismoService _organismoService;
        private readonly IValidator<VMOrganismo> _organismoValidator;


        public OrganismoController(IOrganismoService organismoService, IValidator<VMOrganismo> organismoValidator)
        {
            _organismoService = organismoService;
            _organismoValidator = organismoValidator;
        }

        public async Task<IActionResult> GetOrganismoList()
        {
            var organismo = await _organismoService.GetAllListAsync();
            return View(organismo);
        }

        public async Task<IActionResult> GetOrganismo(int id)
        {
            var organismo = await _organismoService.GetOrganmismoById(id);

            ViewBag.Provincias = new SelectList(await _organismoService.GetProvinciasAsync(), "Id", "Nombre", organismo.ProvinciaId);
            ViewBag.Localidades = new SelectList(await _organismoService.GetLocalidadesByProvinciaAsync(organismo.ProvinciaId), "Id", "Nombre", organismo.LocalidadId);



            return View(organismo);
        }

        [HttpGet]
        public async Task<IActionResult> GetLocalidades(int provinciaId)
        {
            if (provinciaId <= 0)
            {
                return BadRequest("El ID de provincia es inválido.");
            }

            var localidades = await _organismoService.GetLocalidadesByProvinciaAsync(provinciaId);
            return Json(localidades);
        }

        [HttpGet]
        public async Task<IActionResult> AddOrganismo(int? id)
        {
            var provincias = await _organismoService.GetProvinciasAsync();
            ViewBag.Provincias = new SelectList(provincias, "Id", "Nombre");

             return View("AddOrganismo", new VMOrganismo());
        }

        [HttpPost]
        public async Task<IActionResult> AddOrganismo(VMOrganismo request)
        {
            await _organismoService.CreateEntityAsync(request);
            return RedirectToAction("GetOrganismo", "Organismo", new { id = request.Id });
        }

        [HttpGet]
        public async Task<IActionResult> UpdateOrganismo(int id)
        {
            var organismo = await _organismoService.GetOrganmismoById(id);

            ViewBag.Provincias = new SelectList(await _organismoService.GetProvinciasAsync(), "Id", "Nombre", organismo.ProvinciaId);
            ViewBag.Localidades = new SelectList(await _organismoService.GetLocalidadesByProvinciaAsync(organismo.ProvinciaId), "Id", "Nombre", organismo.LocalidadId);

            return View(organismo);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateOrganismo(VMOrganismo request)
        {
            var validation = await _organismoValidator.ValidateAsync(request);

            // Obtener el organismo actual para recargar datos necesarios
            var organismo = await _organismoService.GetOrganmismoById(request.Id);

            // Recargar SelectLists
            ViewBag.Provincias = new SelectList(await _organismoService.GetProvinciasAsync(), "Id", "Nombre", organismo.ProvinciaId);
            ViewBag.Localidades = new SelectList(await _organismoService.GetLocalidadesByProvinciaAsync(organismo.ProvinciaId), "Id", "Nombre", organismo.LocalidadId);

            if (!validation.IsValid)
            {
                // Agregar errores al ModelState
                validation.AddToModelState(this.ModelState);

                // Volver a la vista en lugar de redirigir
                return View(request); // Asegúrate de que el nombre de la vista sea correcto
            }

            await _organismoService.UpdateEntityAsync(request);
            return RedirectToAction("GetOrganismo", "Organismo", new { id = request.Id });
        }


        [Authorize(Roles = "SuperAdmin")]
        public async Task<IActionResult> DeleteOrganismo(int id)
        {
            await _organismoService.DeleteEntityAsync(id);
            return RedirectToAction("GetOrganismo", "Organismo", new { Id = id });
        }
    }
}
