using Entity.WebAplication.Entities;
using Entity.WebAplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IOrganismoService
    {
        public Task<List<VMOrganismo>> GetAllListAsync();
        public Task CreateEntityAsync(VMOrganismo entity);
        public Task DeleteEntityAsync(int id);
        public Task UpdateEntityAsync(VMOrganismo entity);
        public Task<VMOrganismo> GetOrganmismoById(int id);

        public Task<List<VMProvincia>> GetProvinciasAsync();
        public Task<IEnumerable<VMNacionalidad>> GetNacionalidadesAsync();
        public Task<IEnumerable<VMDiscapacidad>> GetDiscapacidadesAsync();
        public Task<IEnumerable<VMMiembroEstudio>> GetEstudiosAsync();
        public Task<IEnumerable<VMEstadoCivil>> GetEstadosCivilesAsync();
        public Task<IEnumerable<VMReligion>> GetReligionesAsync();
        public Task<IEnumerable<VMSexo>> GetSexosAsync();
        public Task<IEnumerable<VMIdioma>> GetIdiomasAsync();
        public Task<IEnumerable<VMFuncion>> GetFunciones();
        public Task<IEnumerable<VMCategoria>> GetCategorias();
        public Task<IEnumerable<VMRama>> GetRamas();
        public Task<(decimal afiliacion, decimal seguro)> GetPreciosAfiliacionesAsync();



    }
}
