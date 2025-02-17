using Entity.WebAplication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IDeudaService
    {
        public Task RenovarDeudasVencidasAsync(int miembroId);
        public Task UpdateDeuda(DetallePago detalle);
        public Task ActualizarSaldoSiAutorizado(DetallePago detalle);
    }
}
