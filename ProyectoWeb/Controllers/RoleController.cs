using Entity.Identity.Entities;
using Entity.Identity.ViewModels;
using Entity.Identity.ViewModels.Error;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NToastNotify;
using ServiceLayer.Services.Identity.Abstract;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace ProyectoWeb.Controllers
{
    public class RoleController : Controller
    {
        private readonly IAuthenticationAdminService _admin;
        private readonly IToastNotification _toasty;

        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;
        private readonly SignInManager<AppUser> _signInManager;


        public RoleController(IAuthenticationAdminService admin, IToastNotification toasty, UserManager<AppUser> userManager, RoleManager<AppRole> roleManager, SignInManager<AppUser> signInManager)
        {
            _admin = admin;
            _toasty = toasty;
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        [Authorize(Policy = "CanViewRolesPolicy")]
        public async Task<IActionResult> ListRoles()
        {
            List<AppRole> roles = await _roleManager.Roles.ToListAsync();
            return View(roles);
        }

        [HttpGet]
        [Authorize(Policy = "CanCreateRolPolicy")]
        public IActionResult CreateRole()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Policy = "CanCreateRolPolicy")]
        public async Task<IActionResult> CreateRole(CreateRolVM roleModel)
        {
            if (ModelState.IsValid)
            {
                // Check if the role already exists
                bool roleExists = await _roleManager.RoleExistsAsync(roleModel?.RoleName);
                if (roleExists)
                {
                    ModelState.AddModelError("", "Role Already Exists");
                }
                else
                {
                    // Create the role
                    // We just need to specify a unique role name to create a new role
                    AppRole identityRole = new AppRole
                    {
                        Name = roleModel?.RoleName,
                        Description = roleModel?.Description,
                        ConcurrencyStamp = Guid.NewGuid().ToString() // Asigna un nuevo GUID para ConcurrencyStamp
                    };

                    // Saves the role in the underlying AspNetRoles table
                    IdentityResult result = await _roleManager.CreateAsync(identityRole);

                    if (result.Succeeded)
                    {
                        return RedirectToAction("ListRoles", "Role");
                    }

                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }

            return View(roleModel);
        }

        [HttpGet]
        [Authorize(Policy = "CanUpdateRolesPolicy")]
        public async Task<IActionResult> EditRole(string roleId)
        {
            //First Get the role information from the database
            AppRole role = await _roleManager.FindByIdAsync(roleId);
            if (role == null)
            {
                // Handle the scenario when the role is not found
                return View("Error");
            }

            //Populate the EditRoleViewModel from the data retrived from the database
            var model = new EditRoleVM
            {
                Id = role.Id,
                RoleName = role.Name,
                Description = role.Description
                // You can add other properties here if needed
            };

            //Initialize the Users and Claims Property to avoid Null Reference Exception while Add the user name
            model.Users = new List<string>();
            model.Claims = new List<string>();

            // Gets a list of claims associated with the specified role.
            var roleClaims = await _roleManager.GetClaimsAsync(role);
            model.Claims = roleClaims.Select(c => c.Value).ToList();

            // Retrieve all the Users
            foreach (var user in _userManager.Users.ToList())
            {
                // If the user is in this role, add the username to
                // Users property of EditRoleViewModel. 
                // This model object is then passed to the view for display
                if (await _userManager.IsInRoleAsync(user, role.Name))
                {
                    model.Users.Add(user.UserName);
                }
            }

            return View(model);
        }

        [HttpPost]
        [Authorize(Policy = "CanUpdateRolesPolicy")]
        public async Task<IActionResult> EditRole(EditRoleVM model)
        {
            if (ModelState.IsValid)
            {
                var role = await _roleManager.FindByIdAsync(model.Id);
                if (role == null)
                {
                    // Handle the scenario when the role is not found
                    ViewBag.ErrorMessage = $"Role with Id = {model.Id} cannot be found";
                    return View("NotFound");
                }
                else
                {
                    role.Name = model.RoleName;
                    role.Description = model.Description;
                    // Update other properties if needed

                    var result = await _roleManager.UpdateAsync(role);
                    if (result.Succeeded)
                    {
                        // Actualiza el SecurityStamp para reflejar los cambios
                        var usersInRole = await _userManager.GetUsersInRoleAsync(role.Name);
                        foreach (var user in usersInRole)
                        {
                            await _userManager.UpdateSecurityStampAsync(user);
                            await _signInManager.SignOutAsync();
                            await _signInManager.SignInAsync(user, isPersistent: false);
                        }

                        return RedirectToAction("ListRoles"); // Redirect to the roles list
                    }

                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }

                    return View(model);
                }
            }

            return View(model);
        }

        [HttpPost]
        [Authorize(Policy = "CanDeleteRolPolicy")]
        public async Task<IActionResult> DeleteRole(string roleId)
        {
            var role = await _roleManager.FindByIdAsync(roleId);
            if (role == null)
            {
                // Role not found, handle accordingly
                ViewBag.ErrorMessage = $"Role with Id = {roleId} cannot be found";
                return View("NotFound");
            }

            // Obtener los usuarios que están en el rol antes de eliminarlo
            var usersInRole = await _userManager.GetUsersInRoleAsync(role.Name);

            var result = await _roleManager.DeleteAsync(role);
            if (result.Succeeded)
            {
                // Actualiza el SecurityStamp de los usuarios afectados sin cerrar su sesión
                foreach (var user in usersInRole)
                {
                    await _userManager.UpdateSecurityStampAsync(user);
                    // Aquí no es necesario hacer el SignOut/SignIn, ya que solo estamos actualizando el SecurityStamp
                }

                // Redirige a la lista de roles después de la eliminación del rol
                return RedirectToAction("ListRoles");
            }

            // Si hubo errores al eliminar el rol, agrega los errores al estado del modelo
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }

            // Si llegamos aquí, algo salió mal, regresa a la vista de roles
            return View("ListRoles", await _roleManager.Roles.ToListAsync());
        }




        [HttpGet]
        [Authorize(Policy = "CanAñadirRemoverRolesPolicy")]
        public async Task<IActionResult> EditUsersInRole(string roleId)
        {
            ViewBag.roleId = roleId;

            var role = await _roleManager.FindByIdAsync(roleId);

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role with Id = {roleId} cannot be found";
                return View("NotFound");
            }

            ViewBag.RollName = role.Name;
            var model = new List<UserRoleViewModel>();

            foreach (var user in _userManager.Users.ToList())
            {
                var userRoleViewModel = new UserRoleViewModel
                {
                    UserId = user.Id,
                    UserName = user.UserName
                };

                if (await _userManager.IsInRoleAsync(user, role.Name))
                {
                    userRoleViewModel.IsSelected = true;
                }
                else
                {
                    userRoleViewModel.IsSelected = false;
                }

                model.Add(userRoleViewModel);
            }

            return View(model);
        }

        [HttpPost]
        [Authorize(Policy = "CanAñadirRemoverRolesPolicy")]
        public async Task<IActionResult> EditUsersInRole(List<UserRoleViewModel> model, string roleId)
        {
            //First check whether the Role Exists or not
            var role = await _roleManager.FindByIdAsync(roleId);

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role with Id = {roleId} cannot be found";
                return View("NotFound");
            }

            for (int i = 0; i < model.Count; i++)
            {
                var user = await _userManager.FindByIdAsync(model[i].UserId);

                IdentityResult? result;

                if (model[i].IsSelected && !(await _userManager.IsInRoleAsync(user, role.Name)))
                {
                    //If IsSelected is true and User is not already in this role, then add the user
                    result = await _userManager.AddToRoleAsync(user, role.Name);
                }
                else if (!model[i].IsSelected && await _userManager.IsInRoleAsync(user, role.Name))
                {
                    //If IsSelected is false and User is already in this role, then remove the user
                    result = await _userManager.RemoveFromRoleAsync(user, role.Name);
                }
                else
                {
                    //Don't do anything simply continue the loop
                    continue;
                }
                          
                //If you add or remove any user, please check the Succeeded of the IdentityResult
                if (result.Succeeded)
                {
                    await _userManager.UpdateSecurityStampAsync(user);

                    if (i < (model.Count - 1))
                        continue;
                    else
                        return RedirectToAction("EditRole", new { roleId = roleId });
                }
            }

            return RedirectToAction("EditRole", new { roleId = roleId });
        }

        [HttpGet]
        [Authorize(Policy = "CanUpdateReclamacionesPolicy")]
        public async Task<IActionResult> ManageRoleClaims(string RoleId)
        {
            //First, fetch the Role Details Based on the RoleId
            var role = await _roleManager.FindByIdAsync(RoleId);

            if (role == null)
            {
                //handle if the role is not Exists in the database
                ViewBag.ErrorMessage = $"Role with Id = {RoleId} cannot be found";
                return View("NotFound");
            }

            //Storing the Role Name in the ViewBag for Display Purpose
            ViewBag.RoleName = role.Name;

            //Create RoleClaimsViewModel Instance
            var model = new RoleClaimsViewModel
            {
                RoleId = RoleId
            };

            // RoleManager service GetClaimsAsync method gets all the current claims of the role
            var existingRoleClaims = await _roleManager.GetClaimsAsync(role);

            // Loop through each claim we have in our application
            // Call the GetAllClaims Static Method ClaimsStore Class
            foreach (Claim claim in ClaimsStore.GetAllClaims())
            {
                //Create an Instance of RoleClaim class
                RoleClaim roleClaim = new RoleClaim
                {
                    ClaimType = claim.Type,
                    ClaimValue = claim.Value
                };

                // If the Role has the claim, set IsSelected property to true, so the checkbox
                // next to the claim is checked on the UI
                if (existingRoleClaims.Any(c => c.Type == claim.Type))
                {
                    roleClaim.IsSelected = true;
                }
                //By default, the IsSelected is False, no need to set as false

                //Add the roleClaim to RoleClaimsViewModel Instance 
                model.Claims.Add(roleClaim);
            }

            return View(model);
        }

        [HttpPost]
        [Authorize(Policy = "CanUpdateReclamacionesPolicy")]
        public async Task<IActionResult> ManageRoleClaims(RoleClaimsViewModel model)
        {
            // Primero obtenemos el detalle del rol
            var role = await _roleManager.FindByIdAsync(model.RoleId);

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role with Id = {model.RoleId} cannot be found";
                return View("NotFound");
            }

            // Obtenemos todos los claims existentes del rol
            var claims = await _roleManager.GetClaimsAsync(role);

            for (int i = 0; i < model.Claims.Count; i++)
            {
                Claim claim = new Claim(model.Claims[i].ClaimType, model.Claims[i].ClaimType);

                IdentityResult? result;

                if (model.Claims[i].IsSelected && !(claims.Any(c => c.Type == claim.Type)))
                {
                    result = await _roleManager.AddClaimAsync(role, claim);
                }
                else if (!model.Claims[i].IsSelected && claims.Any(c => c.Type == claim.Type))
                {
                    result = await _roleManager.RemoveClaimAsync(role, claim);
                }
                else
                {
                    continue;
                }

                // Si el resultado es satisfactorio, forzamos la reautenticación
                if (result.Succeeded)
                {
                    var user = await _userManager.GetUserAsync(User);

                    await _userManager.UpdateSecurityStampAsync(user);
                    await _signInManager.SignOutAsync();
                    await _signInManager.SignInAsync(user, false);               

                    if (i < (model.Claims.Count - 1))
                        continue;
                    else
                        return RedirectToAction("EditRole", new { roleId = model.RoleId });
                }
                else
                {
                    ModelState.AddModelError("", "Cannot add or removed selected claims to role");
                    return View(model);
                }
            }
            return RedirectToAction("EditRole", new { roleId = model.RoleId });
        }

    }
}
