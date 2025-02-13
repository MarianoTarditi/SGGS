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
    public class AutorizacionPagoService : IPagoAutorizacionService
    {
        private readonly IGenericRepository<AutorizacionPago> _repository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AutorizacionPagoService(IGenericRepository<AutorizacionPago> repository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<VMPagoAutorizacion>> GetAllListAsync()
        {
            var pagoAutorizacionListaVM = await _unitOfWork.GetGenericRepository<AutorizacionPago>().GetAllList().ProjectTo<VMPagoAutorizacion>(_mapper.ConfigurationProvider).ToListAsync();
            return pagoAutorizacionListaVM;
        }

        public async Task CreateEntityAsync(VMPagoAutorizacion entity)
        {
            var pagoAutorizacion = _mapper.Map<AutorizacionPago>(entity);

            pagoAutorizacion.Autorizado = false; 

            await _unitOfWork.GetGenericRepository<AutorizacionPago>().CreateEntityAsync(pagoAutorizacion);
            await _unitOfWork.CommitAsync();
        }

        public async Task DeleteEntityAsync(int id)
        {
            var pagoAutorizacion = await _repository.GetEntityByIdAsync(id);
            _repository.Delete(pagoAutorizacion);
            await _unitOfWork.CommitAsync();
        }

        public async Task UpdateEntityAsync(VMPagoAutorizacion entity)
        {
            var pagoAutorizacion = _mapper.Map<AutorizacionPago>(entity);
            _repository.Update(pagoAutorizacion);
            await _unitOfWork.CommitAsync();
        }

        public async Task<VMPagoAutorizacion> GetPagoAutorizacionById(int id)
        {
            var pagoAutorizacion = await _repository.Where(c => c.Id == id).ProjectTo<VMPagoAutorizacion>(_mapper.ConfigurationProvider).SingleAsync();
            return pagoAutorizacion;
        }

     
    }
}
