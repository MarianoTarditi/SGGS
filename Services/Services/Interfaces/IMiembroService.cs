using Entity.WebAplication.Entities;
using Entity.WebAplication.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IMiembroService
    {
        public Task<List<VMMiembro>> GetAllListAsync();
        public Task<List<VMMiembro>> GetAllInactiveListAsync();
        public Task CreateEntityAsync(VMMiembro entity);
        public Task DeleteEntityAsync(int id);
        public Task UpdateEntityAsync(VMMiembro entity);
        public Task<VMMiembro> GetMiembroById(int id);
        public Task<IEnumerable<VMMiembro>> GetMiembrosDeudas();
        public Task<VMMiembro> ObtenerDetallesMiembro(int miembroId);
        public Task<Miembro?> GetMiembroConDeudaPorDNI(string dni);
        public Task<Dictionary<string, int>> GetMiembrosPorRama();



    }
}
