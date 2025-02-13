using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IDashboardService
    {
        Task<int> GetAllMiembrosCountAsync();
        Task<int> GetAllPagosCountAsync();
        int GetAllUsersCountAsync();


    }
}
