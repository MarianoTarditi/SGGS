using Entity.WebAplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface ILocalidadService
    {
        Task<List<VMLocalidad>> GetLocalidadesByProvinciaAsync(int provinciaId);
    }
}
