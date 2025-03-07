using Entity.Identity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Interfaces
{
    public interface IAuditLogService
    {
        public Task<List<AuditLog>> GetAllLogsAsync();
        public Task<List<AuditLogAuthentication>> GetAllLogsAuhtenticationAsync();
        public Task<Dictionary<string, int>> GetAccionesSobreMiembrosAsync();

    }
}
