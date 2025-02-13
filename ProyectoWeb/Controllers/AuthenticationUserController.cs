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

        public AuthenticationUserController(UserManager<AppUser> userManager, IValidator<UserEditVM> userEditValidator, IAuthenticationUserService authenticationUserService, IToastNotification toasty, SignInManager<AppUser> signinManager)
        {
            _userManager = userManager;
            _userEditValidator = userEditValidator;
            _authenticationUserService = authenticationUserService;
            _toasty = toasty;
            _signinManager = signinManager;
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

            return RedirectToAction("Index", "Dashboard", new { Area = "User" });
        }

       

        public async Task<IActionResult> Logout()
        {
            await _signinManager.SignOutAsync();
            return Redirect("/Authentication/LogIn");
        }
    }
}
