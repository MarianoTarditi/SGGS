using Entity.WebAplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IModalidadService
    {
        public Task<List<VMPagoModalidad>> GetAllListAsync();
        public Task CreateEntityAsync(VMPagoModalidad entity);
        public Task DeleteEntityAsync(int id);
        public Task UpdateEntityAsync(VMPagoModalidad entity);
        public Task<VMPagoModalidad> GetPagoById(int id);
    }
}
