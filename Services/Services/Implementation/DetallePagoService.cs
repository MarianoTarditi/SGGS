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
    public class DetallePagoService : IDetallePagoService
    {
        //private readonly IGenericRepository<DetallePago> _repository;
        //private readonly IUnitOfWork _unitOfWork;
        //private readonly IMapper _mapper;

        //public DetallePagoService(IGenericRepository<DetallePago> repository, IUnitOfWork unitOfWork, IMapper mapper)
        //{
        //    _repository = repository;
        //    _unitOfWork = unitOfWork;
        //    _mapper = mapper;
        //}

        //public async Task<List<VMDetallePago>> GetAllListAsync()
        //{
        //    var detallePagoListaVM = await _unitOfWork.GetGenericRepository<Pago>().GetAllList().ProjectTo<VMDetallePago>(_mapper.ConfigurationProvider).ToListAsync();
        //    return detallePagoListaVM;
        //}

        //public async Task CreateEntityAsync(VMDetallePago entity)
        //{
        //    var detallePago = _mapper.Map<DetallePago>(entity);
        //    await _unitOfWork.GetGenericRepository<DetallePago>().CreateEntityAsync(detallePago);
        //    await _unitOfWork.CommitAsync();
        //}

        //public async Task DeleteEntityAsync(int id)
        //{
        //    var detallePago = await _repository.GetEntityByIdAsync(id);
        //    _repository.Delete(detallePago);
        //    await _unitOfWork.CommitAsync();
        //}

        //public async Task UpdateEntityAsync(VMDetallePago entity)
        //{
        //    var detallePago = _mapper.Map<DetallePago>(entity);
        //    _repository.Update(detallePago);
        //    await _unitOfWork.CommitAsync();
        //}
        //public async Task<VMDetallePago> GetPagoById(int id)
        //{
        //    var detallePago = await _repository.Where(c => c.Id == id).ProjectTo<VMDetallePago>(_mapper.ConfigurationProvider).SingleAsync();
        //    return detallePago;
        //}
    }
}

