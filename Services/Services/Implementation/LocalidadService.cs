using AutoMapper;
using AutoMapper.QueryableExtensions;
using DAL.Repositories.Interfaces;
using DAL.UnitOfWork.Interfaces;
using Entity.WebAplication.Entities;
using Entity.WebAplication.ViewModels;
using Microsoft.EntityFrameworkCore;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Implementation
{
    public class LocalidadService : ILocalidadService
    {

        private readonly IGenericRepository<Localidad> _localidadRepository;

        public LocalidadService(IGenericRepository<Localidad> localidadRepository)
        {
            _localidadRepository = localidadRepository;
        }

        public async Task<List<VMLocalidad>> GetLocalidadesByProvinciaAsync(int provinciaId)
        {
            // Asegúrate de usar ToListAsync desde Microsoft.EntityFrameworkCore
            var localidadesQuery = _localidadRepository.Where(l => l.ProvinciaId == provinciaId);

            // Convertir a lista asincrónicamente
            var localidades = await localidadesQuery.ToListAsync();
            return localidades.Select(l => new VMLocalidad
            {
                Id = l.Id,
                Nombre = l.Nombre,
                ProvinciaId = l.ProvinciaId
            }).ToList();
        }
    }   
}
