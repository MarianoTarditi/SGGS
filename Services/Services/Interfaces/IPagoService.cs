using Entity.WebAplication.Entities;
using Entity.WebAplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IPagoService
    {
        public Task<List<VMPago>> GetAllListAsync();
        public Task CreateEntityAsync(VMPago pago, List<DetallePago> listaDetalles);

        public Task DeleteEntityAsync(int id);
        public Task DeleteDetalleAsync(int id);
        public Task UpdateEntityAsync(VMPago pago);
        public Task<VMPago> GetPagoById(int id);


        public Task<IEnumerable<VMPagoModalidad>> GetModalidadesAsync();
        public Task<IEnumerable<VMCategoriaPago>> GetCategoriasAsync();

        public Task<IEnumerable<VMEstadoAutorizacion>> GetEstadosAutorizacionAsync();
        public Task<bool> CambiarEstadoAsync(int idPago, int nuevoEstadoId);

    }
}
