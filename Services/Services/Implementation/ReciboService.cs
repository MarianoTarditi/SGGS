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
    public class ReciboService : IReciboService
    {
        private readonly IGenericRepository<Recibo> _repository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ReciboService(IGenericRepository<Recibo> repository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<VMRecibo>> GetAllListAsync()
        {
            var reciboListaVM = await _unitOfWork.GetGenericRepository<Pago>().GetAllList().ProjectTo<VMRecibo>(_mapper.ConfigurationProvider).ToListAsync();
            return reciboListaVM;
        }

        public async Task CreateEntityAsync(VMRecibo entity)
        {
            var recibo = _mapper.Map<Recibo>(entity);

            var ultimoCodigo = await _unitOfWork.GetGenericRepository<Recibo>().GetAllList().OrderByDescending(o => o.Codigo).FirstOrDefaultAsync();
            int nuevoCodigo = (ultimoCodigo != null) ? ultimoCodigo.Codigo + 1 : 1;

            recibo.Codigo = nuevoCodigo;

          

            await _unitOfWork.GetGenericRepository<Recibo>().CreateEntityAsync(recibo);
            await _unitOfWork.CommitAsync();
        }

        public async Task DeleteEntityAsync(int id)
        {
            var recibo = await _repository.GetEntityByIdAsync(id);
            _repository.Delete(recibo);
            await _unitOfWork.CommitAsync();
        }

        public async Task UpdateEntityAsync(VMRecibo entity)
        {
            var recibo = _mapper.Map<Recibo>(entity);
            _repository.Update(recibo);
            await _unitOfWork.CommitAsync();
        }
        public async Task<VMRecibo> GetPagoById(int id)
        {
            var recibo = await _repository.Where(c => c.Id == id).ProjectTo<VMRecibo>(_mapper.ConfigurationProvider).SingleAsync();
            return recibo;
        }
    }
}
