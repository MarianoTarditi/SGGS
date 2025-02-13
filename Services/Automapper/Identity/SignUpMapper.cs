using AutoMapper;
using Entity.Identity.Entities;
using Entity.Identity.ViewModels;

namespace ServiceLayer.Automapper.Identity
{
    public class SignUpMapper : Profile
    {
        public SignUpMapper()
        {
            CreateMap<AppUser,SignUpVM>().ReverseMap();
        }
    }
}
