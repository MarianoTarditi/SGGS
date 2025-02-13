using Entity.WebAplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IPagoAutorizacionService
    {
        public Task<List<VMPagoAutorizacion>> GetAllListAsync();
        public Task CreateEntityAsync(VMPagoAutorizacion entity);
        public Task DeleteEntityAsync(int id);
        public Task UpdateEntityAsync(VMPagoAutorizacion entity);
        public Task<VMPagoAutorizacion> GetPagoAutorizacionById(int id);
    }
}
