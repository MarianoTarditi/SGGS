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

    }
}
