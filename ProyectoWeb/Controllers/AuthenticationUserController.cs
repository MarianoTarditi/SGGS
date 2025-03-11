using DAL.UnitOfWork.Implementation;
using DAL.UnitOfWork.Interfaces;
using Entity.Identity.Entities;
using Entity.Identity.ViewModels;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using ServiceLayer.Helpers.Identity.ModelStateHelper;
using ServiceLayer.Messages.Identity;
using ServiceLayer.Services.Identity.Abstract;
using System.Collections.Generic;
using System.Data;

namespace ProyectoWeb.Controllers
{
    [Authorize]
    public class AuthenticationUserController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signinManager;

        private readonly IValidator<UserEditVM> _userEditValidator;
        private readonly IAuthenticationUserService _authenticationUserService;
        private readonly IToastNotification _toasty;

        private readonly IUnitOfWork _unitOfWork;

        public AuthenticationUserController(UserManager<AppUser> userManager, IValidator<UserEditVM> userEditValidator, IAuthenticationUserService authenticationUserService, IToastNotification toasty, SignInManager<AppUser> signinManager, IUnitOfWork unitOfWork)
        {
            _userManager = userManager;
            _userEditValidator = userEditValidator;
            _authenticationUserService = authenticationUserService;
            _toasty = toasty;
            _signinManager = signinManager;
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult> UserEdit()
        {
            var userEditVm = await _authenticationUserService.FindUserAsync(HttpContext);
            return View(userEditVm);
        }

        [HttpPost]
        public async Task<IActionResult> UserEdit(UserEditVM request)
        {
            var user = await _userManager.FindByNameAsync(User.Identity!.Name!);

            var validation = await _userEditValidator.ValidateAsync(request);
            if (!validation.IsValid)
            {
                validation.AddToModelState(ModelState);
                return View();
            }

            var userEditResult = await _authenticationUserService.UserEditAsync(request, user!);
            if (!userEditResult.Succeeded)
            {
                ViewBag.Result = "FailedUserEdit";
                ModelState.AddModelErrorList(userEditResult.Errors);
                return View();
            }

            ViewBag.Id = user!.Id;
            _toasty.AddInfoToastMessage(NotificationMessagesIdentity.UserEdit(user.UserName!), new ToastrOptions { Title = NotificationMessagesIdentity.SuccessedTitle });

            var roles = await _userManager.GetRolesAsync(user);
            if (roles.Contains("External Member"))
            {
                return RedirectToAction("Index", "EsperarAprobacion");
            }
            return RedirectToAction("Index", "Dashboard", new { Area = "User" });
        }



        public async Task<IActionResult> Logout()
        {
            var user = await _userManager.GetUserAsync(User); // Obtiene el usuario actual
            if (user != null)
            {
                // Recupera la hora de inicio de sesión desde la sesión
                var sessionStartString = HttpContext.Session.GetString("SessionStartTime");
                DateTime? sessionStartTime = sessionStartString != null ? DateTime.Parse(sessionStartString) : (DateTime?)null;

                TimeSpan? sessionDuration = null;
                if (sessionStartTime.HasValue)
                {
                    sessionDuration = DateTime.Now - sessionStartTime.Value;
                }

                // Registra el evento en la tabla de auditoría
                var auditLog = new AuditLogAuthentication
                {
                    UserId = user.Id,
                    UserName = user.UserName,
                    UserEmail = user.Email,
                    UserRole = (await _userManager.GetRolesAsync(user)).FirstOrDefault(),
                    Action = "Cierre de sesión",
                    Timestamp = DateTime.Now,
                    SessionDuration = sessionDuration // Guarda la duración de la sesión
                };

                // Guarda el registro en la base de datos
                await _unitOfWork.GetDbContext().AddAsync(auditLog);
                await _unitOfWork.CommitAsync();

                // Limpiar la sesión
                HttpContext.Session.Remove("SessionStartTime");
            }

            await _signinManager.SignOutAsync(); // Cierra la sesión del usuario
            return Redirect("/Authentication/LogIn"); // Redirige al login
        }


    }
}
