using Entity.Identity.Entities;
using Entity.Identity.ViewModels;
using Entity.WebAplication.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NToastNotify;
using ServiceLayer.Messages.Identity;
using ServiceLayer.Services.Identity.Abstract;
using System.Data;
using System.Security.Claims;

namespace ProyectoWeb.Controllers
{
    [Authorize(Roles = "SuperAdmin")]
    public class AdminController : Controller
    {
        private readonly IAuthenticationAdminService _admin;
        private readonly IToastNotification _toasty;

        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;


        public AdminController(IToastNotification toasty, IAuthenticationAdminService admin, RoleManager<AppRole> roleManager, UserManager<AppUser> userManager)
        {
            _toasty = toasty;
            _admin = admin;
            _roleManager = roleManager;
            _userManager = userManager;
        }

        [Authorize(Policy = "CanViewUsuariosPolicy")]
        public async Task<IActionResult> GetUserList()
        {
            var userListVM = await _admin.GetUserListAsync();

            ViewBag.Roles = await _roleManager.Roles.Select(r => r.Name).ToListAsync();
            return View(userListVM);
        }


        public async Task<IActionResult> ExtendClaim(string username)
        {
            var renewClaim = await _admin.ExtendClaimAsync(username);
            if (!renewClaim.Succeeded)
            {
                _toasty.AddErrorToastMessage(NotificationMessagesIdentity.ExtendClaimFailed, new ToastrOptions { Title = "¡Lo sentimos!" });
                return RedirectToAction("GetUserList", "Admin", new { Area = "Admin" });
            }
            _toasty.AddSuccessToastMessage(NotificationMessagesIdentity.ExtendClaimSuccess, new ToastrOptions { Title = "¡Felicitaciones!" });
            return RedirectToAction("GetUserList", "Admin", new { Area = "Admin" });
        }

        [HttpPost]
        [Authorize(Policy = "CanUpdateRolUsuario")]
        public async Task<IActionResult> UpdateUserRole([FromBody] UserRoleUpdateRequestVM request)
        {
            if (string.IsNullOrEmpty(request.UserName))
            {
                return Json(new { success = false, message = "El nombre de usuario no puede estar vacío.", type = "error" });
            }

            var updateResult = await _admin.UpdateUserRoleAsync(request.UserName, request.NewRole);
            if (!updateResult.Succeeded)
            {
                return Json(new { success = false, message = "Error al actualizar el rol.", type = "error" });
            }

            return Json(new { success = true, message = NotificationMessagesIdentity.UserEdit(request.UserName!), type = "success" });
        }

        [HttpPost]
        [Authorize(Policy = "CanDeleteUserPolicy")]
        public async Task<IActionResult> DeleteUser([FromBody] DeleteUserRequestVM request)
        {
            if (string.IsNullOrEmpty(request.UserName))
            {
                return Json(new { success = false, message = "El nombre de usuario no puede estar vacío." });
            }

            var deleteResult = await _admin.DeleteUserAsync(request.UserName);
            if (!deleteResult.Succeeded)
            {
                return Json(new { success = false, message = "Error al eliminar el usuario." });
            }

            return Json(new { success = true, message = $"Usuario {request.UserName} eliminado correctamente." });
        }

    }
}
