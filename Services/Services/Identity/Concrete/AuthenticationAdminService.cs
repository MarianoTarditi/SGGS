using AutoMapper;
using Entity.Identity.Entities;
using Entity.Identity.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NToastNotify;
using ServiceLayer.Messages.Identity;
using ServiceLayer.Services.Identity.Abstract;
using System.Security.Claims;

namespace ServiceLayer.Services.Identity.Concrete
{
    public class AuthenticationAdminService : IAuthenticationAdminService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IMapper _mapper;
        private readonly IToastNotification _toasty;

        public AuthenticationAdminService(UserManager<AppUser> userManager, IMapper mapper, IToastNotification toasty)
        {
            _userManager = userManager;
            _mapper = mapper;
            _toasty = toasty;
        }

        public async Task<IdentityResult> ExtendClaimAsync(string username)
        {          
            var user = await _userManager.FindByNameAsync(username); // Busca al usuario por su nombre de usuario.

            // Obtiene los reclamos actuales del usuario y busca uno específico que contenga "Observer".
            var claims = await _userManager.GetClaimsAsync(user!);
            var existingClaim = claims.FirstOrDefault(x => x.Type.Contains("Observer"));
   
            var newExtendedClaim = new Claim("AdminObserverExpireDate", DateTime.Now.AddDays(5).ToString()); // Crea un nuevo reclamo extendido

            return await _userManager.ReplaceClaimAsync(user!, existingClaim!, newExtendedClaim); // Reemplaza el reclamo existente con el nuevo reclamo.
        }

        public async Task<List<UserVM>> GetUserListAsync()
        {
            // Recupera la lista de usuarios desde la base de datos.
            var userList = await _userManager.Users.ToListAsync();

            // Convierte la lista de entidades de usuario en una lista de objetos de vista (UserVM) utilizando AutoMapper.
            var userListVM = _mapper.Map<List<UserVM>>(userList);

            // Para cada usuario, recupera sus roles y reclamos, y los asigna al modelo de vista.
            for (int i = 0; i < userList.Count; i++)
            {
                var userRoles = await _userManager.GetRolesAsync(userList[i]);
                userListVM[i].UserRoles = userRoles;

                userListVM[i].Roles = userRoles.FirstOrDefault() ?? "Sin rol";

                var userClaims = await _userManager.GetClaimsAsync(userList[i]);
                userListVM[i].UserClaims = userClaims;
            }
         
            return userListVM; // Devuelve la lista de usuarios con sus roles y reclamos asignados.
        }


        public async Task<IdentityResult> UpdateUserRoleAsync(string userName, string newRole)
        {
            var user = await _userManager.FindByNameAsync(userName);
            if (user == null)
            {
                return IdentityResult.Failed(new IdentityError { Description = $"User with username {userName} not found." });
            }

            var currentRoles = await _userManager.GetRolesAsync(user);
            var removeResult = await _userManager.RemoveFromRolesAsync(user, currentRoles);
            if (!removeResult.Succeeded)
            {
                return IdentityResult.Failed(new IdentityError { Description = "Failed to remove user roles." });
            }

            var addResult = await _userManager.AddToRoleAsync(user, newRole);
            if (!addResult.Succeeded)
            {
                return IdentityResult.Failed(new IdentityError { Description = "Failed to add new role to user." });
            }

            return IdentityResult.Success;
        }

       

            public async Task<IdentityResult> DeleteUserAsync(string userName)
            {
                // Buscar al usuario por su nombre de usuario
                var user = await _userManager.FindByNameAsync(userName);

                if (user == null)
                {
                    // Si el usuario no existe, retornar un error
                    return IdentityResult.Failed(new IdentityError
                    {
                        Description = "El usuario no existe."
                    });
                }

                // Eliminar el usuario
                var deleteResult = await _userManager.DeleteAsync(user);

                if (!deleteResult.Succeeded)
                {
                    // Si hubo un error al eliminar al usuario, retornar un error
                    return IdentityResult.Failed(new IdentityError
                    {
                        Description = "Hubo un problema al intentar eliminar el usuario."
                    });
                }

                // Si la eliminación fue exitosa
                return IdentityResult.Success;
            }
        }  
}
