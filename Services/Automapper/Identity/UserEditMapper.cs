using AutoMapper;
using Entity.Identity.Entities;
using Entity.Identity.ViewModels;

namespace ServiceLayer.Automapper.Identity
{
    public class UserEditMapper : Profile
    {
        public UserEditMapper()
        {
            CreateMap<AppUser,UserEditVM>().ReverseMap();
            CreateMap<AppUser,UserVM>().ReverseMap();
        }
    }
}
