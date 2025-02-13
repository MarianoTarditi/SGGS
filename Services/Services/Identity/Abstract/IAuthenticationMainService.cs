using Entity.Identity.Entities;
using Entity.Identity.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ServiceLayer.Services.Identity.Abstract
{
    public interface IAuthenticationMainService
    {
        Task CreateResetCredentialsAndSend(AppUser user,HttpContext context,IUrlHelper url, ForgotPasswordVM request);
    }
}
