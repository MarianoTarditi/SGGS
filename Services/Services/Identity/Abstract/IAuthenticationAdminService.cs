using Entity.Identity.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace ServiceLayer.Services.Identity.Abstract
{
    public interface IAuthenticationAdminService
    {
        Task<List<UserVM>> GetUserListAsync();
        Task<IdentityResult> ExtendClaimAsync(string username);
        public Task<IdentityResult> UpdateUserRoleAsync(string username, string newRole);
        public Task<IdentityResult> DeleteUserAsync(string userName);

        // roles 
        public Task<List<string>> GetAllRolesAsync();
        public Task<bool> RevocarPermisoDeRol(string roleId, string modulo, string permiso);
        public Task<bool> AsignarPermisoARol(string roleId, string modulo, string permiso);

        //public Task AsignarTodosLosPermisos();




    }
}
