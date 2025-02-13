using AutoMapper;
using DAL.Repositories.Interfaces;
using DAL.UnitOfWork.Interfaces;
using Entity.WebAplication.Entities;
using Entity.WebAplication.ViewModels;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Implementation
{
    public class ProvinciaService : IProvinciaService
    {
        private readonly IGenericRepository<Provincia> _provinciaRepository;

        public ProvinciaService(IGenericRepository<Provincia> provinciaRepository)
        {
            _provinciaRepository = provinciaRepository;
        }

        public async Task<List<VMProvincia>> GetAllProvinciasAsync()
        {
            var provincias =  _provinciaRepository.GetAllList();
            return provincias.Select(p => new VMProvincia
            {
                Id = p.Id,
                Nombre = p.Nombre,
                Localidades = p.Localidades.ToList()
            }).ToList();
        }
    }
}
