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
    public class CategoriaMapper : Profile
    {
        public CategoriaMapper()
        {
            CreateMap<Categoria, VMCategoria>().ReverseMap();
        }
    }
}
