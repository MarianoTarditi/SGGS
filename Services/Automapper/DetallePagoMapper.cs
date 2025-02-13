using AutoMapper;
using Entity.WebAplication.ViewModels;
using Entity.WebAplication.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Automapper
{
    public class DetallePagoMapper : Profile
    {
        public DetallePagoMapper()
        {
            CreateMap<DetallePago, VMDetallePago>().ReverseMap();
        }
    }
}
