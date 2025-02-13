using AutoMapper;
using Entity.WebAplication.Entities;
using Entity.WebAplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Automapper
{
    public class MiembroEstadoCivilMapper : Profile
    {
        public MiembroEstadoCivilMapper()
        {
            CreateMap<EstadoCivil, VMEstadoCivil>().ReverseMap();
        }
    }
}
