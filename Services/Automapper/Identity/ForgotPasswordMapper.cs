using AutoMapper;
using Entity.Identity.Entities;
using Entity.Identity.ViewModels;

namespace ServiceLayer.Automapper.Identity
{
    public class ForgotPasswordMapper : Profile
    {
        public ForgotPasswordMapper()
        {
            CreateMap<AppUser,ForgotPasswordVM>().ReverseMap();
        }
    }
}
