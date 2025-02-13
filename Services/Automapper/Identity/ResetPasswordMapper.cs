using AutoMapper;
using Entity.Identity.Entities;
using Entity.Identity.ViewModels;

namespace ServiceLayer.Automapper.Identity
{
    public class ResetPasswordMapper : Profile
    {
        public ResetPasswordMapper()
        {
            CreateMap<AppUser,ResetPasswordVM>().ReverseMap();
        }
    }
}
