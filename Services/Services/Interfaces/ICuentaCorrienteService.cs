using Entity.WebAplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface ICuentaCorrienteService
    {
        public  Task<Dictionary<string, int>> GetCategoriaMiembroAsync();
        public Task<Dictionary<string, int>> GetFuncionMiembroAsync();
        public Task<Dictionary<string, int>> GetRamaMiembroAsync();
        public Task<Dictionary<string, int>> GetReligionMiembroAsync();
        public Task GestionarSaldosPagos(decimal montoAfiliacion, decimal montoSeguro);
        public Task GestionarSaldosMiembros(decimal montoAfiliacion, decimal montoSeguro);
        public Task<(decimal saldoAfiliacion, decimal saldoSeguroAcompañante, decimal saldoTotal, decimal debito, decimal credito, decimal debitoAfiliacion, decimal debitoSeguro, decimal creditoAfiliacion, decimal creditoSeguro)> ObtenerSaldoTotal();
        public bool ActualizarPrecio(string tipo, decimal nuevoPrecio);
        Task RenovarDeudasVencidasAsync();

    }
}
