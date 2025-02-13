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
    public class ModalidadService : IModalidadService
    {
        private readonly IGenericRepository<ModalidadPago> _repository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ModalidadService(IGenericRepository<ModalidadPago> repository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<VMPagoModalidad>> GetAllListAsync()
        {
            var pagoModalidadListVM = await _unitOfWork.GetGenericRepository<Pago>().GetAllList().ProjectTo<VMPagoModalidad>(_mapper.ConfigurationProvider).ToListAsync();
            return pagoModalidadListVM;
        }

        public async Task CreateEntityAsync(VMPagoModalidad entity)
        {
            var modalidad = _mapper.Map<ModalidadPago>(entity);
            await _unitOfWork.GetGenericRepository<ModalidadPago>().CreateEntityAsync(modalidad);
            await _unitOfWork.CommitAsync();
        }

        public async Task DeleteEntityAsync(int id)
        {
            var modalidad = await _repository.GetEntityByIdAsync(id);
            _repository.Delete(modalidad);
            await _unitOfWork.CommitAsync();
        }

        public async Task UpdateEntityAsync(VMPagoModalidad entity)
        {
            var modalidad = _mapper.Map<ModalidadPago>(entity);
            _repository.Update(modalidad);
            await _unitOfWork.CommitAsync();
        }
        public async Task<VMPagoModalidad> GetPagoById(int id)
        {
            var modalidad = await _repository.Where(c => c.Id == id).ProjectTo<VMPagoModalidad>(_mapper.ConfigurationProvider).SingleAsync();
            return modalidad;
        }
    }
}
