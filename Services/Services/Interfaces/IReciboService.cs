using Entity.WebAplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IReciboService
    {
        public Task<List<VMRecibo>> GetAllListAsync();
        public Task CreateEntityAsync(VMRecibo entity);
        public Task DeleteEntityAsync(int id);
        public Task UpdateEntityAsync(VMRecibo entity);
        public Task<VMRecibo> GetPagoById(int id);
    }
}
