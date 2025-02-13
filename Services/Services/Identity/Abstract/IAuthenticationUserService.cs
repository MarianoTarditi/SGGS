using Entity.Identity.Entities;
using Entity.Identity.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace ServiceLayer.Services.Identity.Abstract
{
    public interface IAuthenticationUserService
    {
        Task<UserEditVM> FindUserAsync(HttpContext httpContext);
        Task<IdentityResult> UserEditAsync(UserEditVM request, AppUser user);
    }
}
