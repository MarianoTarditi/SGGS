using AutoMapper;
using Entity.Identity.Entities;
using Entity.Identity.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;
using System.Security.Claims;
using FluentValidation.AspNetCore;
using ServiceLayer.Messages.Identity;
using ServiceLayer.Services.Identity.Abstract;
using ServiceLayer.Helpers.Identity.ModelStateHelper;
using FluentValidation;
using NToastNotify;

namespace ProyectoWeb.Controllers
{
    public class AuthenticationController : Controller
    {

        // Clases de Identity
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        // API Validator
        private readonly IValidator<SignUpVM> _signUpValidator;
        private readonly IValidator<LogInVM> _logInValidator;
        private readonly IValidator<ForgotPasswordVM> _forgotPasswordValidator;
        private readonly IValidator<ResetPasswordVM> _resetPasswordValidator;

        private readonly IAuthenticationMainService _authenticationService;

        // Mapper - Notification
        private readonly IMapper _iMapper;
        private readonly IToastNotification _toasty;

        public AuthenticationController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IValidator<SignUpVM> signUpValidator, IValidator<LogInVM> logInValidator, IValidator<ForgotPasswordVM> forgotPasswordValidator, IMapper iMapper, IValidator<ResetPasswordVM> resetPasswordValidator, IAuthenticationMainService authenticationService, IToastNotification toasty)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _signUpValidator = signUpValidator;
            _logInValidator = logInValidator;
            _forgotPasswordValidator = forgotPasswordValidator;
            _iMapper = iMapper;
            _resetPasswordValidator = resetPasswordValidator;
            _authenticationService = authenticationService;
            _toasty = toasty;
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpVM request)
        {
            // Valida los datos con los datos especificados en `_signUpValidator`.
            var validation = await _signUpValidator.ValidateAsync(request);
            if (!validation.IsValid)
            {
                // Si la validación falla, agrega los errores al `ModelState` para mostrar mensajes en la vista.
                validation.AddToModelState(ModelState);
                return View();
            }

            // Mapea los datos del modelo de vista a un objeto `AppUser` para crear el usuario.
            var user = _iMapper.Map<AppUser>(request);

            // Crea el usuario
            var userCreateResult = await _userManager.CreateAsync(user, request.Password);
            if (!userCreateResult.Succeeded)
            {
                // Si la creación falla, muestra errores en la vista.
                ViewBag.Result = "NotSucceed";
                ModelState.AddModelErrorList(userCreateResult.Errors);
                return View();
            }

            // Asigna al usuario el rol predeterminado de "Member".
            var assignRoleResult = await _userManager.AddToRoleAsync(user, "Member");
            if (!assignRoleResult.Succeeded)
            {
                // Si falla la asignación de rol, elimina al usuario creado y muestra los errores.
                await _userManager.DeleteAsync(user);
                ViewBag.Result = "NotSucceed";
                ModelState.AddModelErrorList(assignRoleResult.Errors);
                return View();
            }

            // Agrega un *claim* predeterminado al usuario.
            var defaultClaim = new Claim("AdminObserverExpireDate", DateTime.Now.AddDays(-1).ToString());
            var addClaimResult = await _userManager.AddClaimAsync(user, defaultClaim);
            if (!addClaimResult.Succeeded)
            {
                // Si falla la adición del *claim*, elimina el usuario y revierte las asignaciones previas.
                await _userManager.RemoveFromRoleAsync(user, "Member");
                await _userManager.DeleteAsync(user);
                ViewBag.Result = "NotSucceed";
                ModelState.AddModelErrorList(addClaimResult.Errors);
                return View();
            }

            // Si todo es exitoso, muestra un mensaje de éxito con Toastr y redirige al formulario de inicio de sesión.
            _toasty.AddSuccessToastMessage(
                NotificationMessagesIdentity.SignUp(user.UserName!),
                new ToastrOptions { Title = NotificationMessagesIdentity.SuccessedTitle });
            return RedirectToAction("LogIn", "Authentication");
        }

        [HttpGet]
        public IActionResult LogIn(string? errorMessage)
        {
            // Si hay un mensaje de error relacionado con el sello de seguridad, muestra un error en la vista.
            if (errorMessage != null && errorMessage == IdentityMessages.SecurityStampError)
            {
                ViewBag.Result = "NotSucceed";
                ModelState.AddModelErrorList(new List<string> { errorMessage });
                return View();
            }

            // Si hay cualquier otro mensaje de error, redirige a la página de error.
            if (errorMessage != null)
            {
                return Redirect("/Error/PageNotFound");
            }

            // Muestra el formulario de inicio de sesión.
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LogIn(LogInVM request, string? returnUrl = null)
        {
            // Define la URL de redirección por defecto si no se proporciona una personalizada.
            returnUrl = returnUrl ?? Url.Action("Index", "Dashboard", new { Area = "Admin" });

            // Valida los datos de inicio de sesión según las reglas de `_logInValidator`.
            var validation = await _logInValidator.ValidateAsync(request);
            if (!validation.IsValid)
            {
                // Si la validación falla, agrega los errores al `ModelState` y retorna la vista.
                validation.AddToModelState(ModelState);
                return View();
            }

            // Busca al usuario por su correo electrónico.
            var hasUser = await _userManager.FindByEmailAsync(request.Email);
            if (hasUser == null)
            {
                // Si el usuario no existe, muestra un error en la vista.
                ViewBag.Result = "NotSucceed";
                ModelState.AddModelErrorList(new List<string> { "Email y/o contraseña incorrectos" });
                return View();
            }

            // Intenta iniciar sesión con el usuario encontrado y la contraseña proporcionada.
            var logInResult = await _signInManager.PasswordSignInAsync(hasUser, request.Password, request.RememberMe, true);
            if (logInResult.Succeeded)
            {
                // Obtiene los roles del usuario
                var roles = await _userManager.GetRolesAsync(hasUser);

                // Si el usuario tiene el rol "ExternalMember", lo redirigimos a la página de espera.
                if (roles.Contains("External Member"))
                {
                    return RedirectToAction("Index", "EsperarAprobacion");
                }

                // Si el inicio de sesión es exitoso, muestra un mensaje de éxito y redirige a la URL deseada.
                _toasty.AddSuccessToastMessage(
                    NotificationMessagesIdentity.LogInSuccess,
                    new ToastrOptions { Title = NotificationMessagesIdentity.SuccessedTitle });
                return Redirect(returnUrl!);
            }

            // Si el usuario está bloqueado, muestra un mensaje indicando el bloqueo temporal.
            if (logInResult.IsLockedOut)
            {
                ViewBag.Result = "LockedOut";
                ModelState.AddModelErrorList(new List<string> { "¡Su cuenta se ha bloqueado por 60 segundos!" });
                return View();
            }

            // Si el intento falla, muestra un mensaje indicando un intento fallido y cuántos han ocurrido.
            ViewBag.Result = "FailedAttempt";
            ModelState.AddModelErrorList(
                new List<string> { $"Contraseña o email incorrecto. Intento fallido: {await _userManager.GetAccessFailedCountAsync(hasUser)}" });
            return View();
        }


        [HttpGet]
        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordVM request)
        {
            // Validación del modelo de entrada
            var validation = await _forgotPasswordValidator.ValidateAsync(request);
            if (!validation.IsValid)
            {
                // Si la validación falla, se agregan los errores al ModelState y se retorna la misma vista
                validation.AddToModelState(ModelState);
                return View();
            }

            // Verificación de la existencia del usuario en la base de datos
            var hasUser = await _userManager.FindByEmailAsync(request.Email);
            if (hasUser == null)
            {
                // Si el usuario no existe, se notifica al usuario y se retorna la vista
                ViewBag.Result = "UserDoesNotExist";
                ModelState.AddModelErrorList(new List<string> { "El Usuario no existe." });
                return View();
            }

            // Envío de enlace de restablecimiento de contraseña si todo es válido
            _toasty.AddSuccessToastMessage(NotificationMessagesIdentity.PasswordResetSuccess, new ToastrOptions { Title = NotificationMessagesIdentity.SuccessedTitle });
            await _authenticationService.CreateResetCredentialsAndSend(hasUser, HttpContext, Url, request);

            return RedirectToAction("LogIn", "Authentication");
        }

        [HttpGet]
        public IActionResult ResetPassword(string userId, string token, List<string> errors)
        {
            // Almacena temporalmente el ID del usuario y el token
            TempData["UserId"] = userId;
            TempData["Token"] = token;

            // Si existen errores, se muestran en la vista
            if (errors.Any())
            {
                ViewBag.Result = "Error";
                ModelState.AddModelErrorList(errors);
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordVM request)
        {
            // Recupera el ID del usuario y el token almacenados temporalmente
            var userId = TempData["UserId"];
            var token = TempData["Token"];

            // Validación de la presencia del token y del ID del usuario
            if (userId == null || token == null)
            {
                _toasty.AddErrorToastMessage(NotificationMessagesIdentity.TokenValidationError, new ToastrOptions { Title = NotificationMessagesIdentity.FailedTitle });
                return RedirectToAction("LogIn", "Authentication");
            }

            // Validación del modelo de restablecimiento de contraseña
            var validation = await _resetPasswordValidator.ValidateAsync(request);
            if (!validation.IsValid)
            {
                // Si falla, se redirige a la vista con los errores correspondientes
                List<string> errors = validation.Errors.Select(x => x.ErrorMessage).ToList();
                return RedirectToAction("ResetPassword", "Authentication", new { userId, token, errors });
            }

            // Verificación de la existencia del usuario
            var hasUser = await _userManager.FindByIdAsync(userId.ToString()!);
            if (hasUser == null)
            {
                _toasty.AddErrorToastMessage(NotificationMessagesIdentity.UserError, new ToastrOptions { Title = NotificationMessagesIdentity.FailedTitle });
                return RedirectToAction("LogIn", "Authentication");
            }

            // Intento de restablecimiento de la contraseña
            var resetPasswordResult = await _userManager.ResetPasswordAsync(hasUser!, token.ToString()!, request.Password);
            if (resetPasswordResult.Succeeded)
            {
                // Si es exitoso, se notifica al usuario y se redirige al login
                _toasty.AddSuccessToastMessage(NotificationMessagesIdentity.PasswordChangeSuccess, new ToastrOptions { Title = NotificationMessagesIdentity.SuccessedTitle });
                return RedirectToAction("LogIn", "Authentication");
            }
            else
            {
                // Si falla, se redirige a la vista con los errores
                List<string> errors = resetPasswordResult.Errors.Select(x => x.Description).ToList();
                return RedirectToAction("ResetPassword", "Authentication", new { userId, token, errors });
            }
        }
         public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
