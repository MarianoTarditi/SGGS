using AutoMapper;
using Entity.Identity.Entities;
using Entity.Identity.ViewModels;

namespace ServiceLayer.Automapper.Identity
{
    public class LogInMapper : Profile
    {
        public LogInMapper()
        {
            CreateMap<AppUser, LogInVM>().ReverseMap();
        }
    }
}
