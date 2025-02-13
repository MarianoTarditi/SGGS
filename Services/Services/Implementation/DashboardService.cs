using DAL.UnitOfWork.Interfaces;
using Entity.Identity.Entities;
using Entity.WebAplication.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ServiceLayer.Services.Identity.Abstract;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Implementation
{
    public class DashboardService : IDashboardService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<AppUser> _userManager;
        private readonly IAuthenticationAdminService _authentificationAdminService;

        public DashboardService(IUnitOfWork unitOfWork, IAuthenticationAdminService authentificationAdminService, UserManager<AppUser> userManager)
        {
            _unitOfWork = unitOfWork;
            _authentificationAdminService = authentificationAdminService;
            _userManager = userManager;
        }

        public async Task<int> GetAllMiembrosCountAsync()
        {
            var miembrosCount = await _unitOfWork.GetGenericRepository<Miembro>().GetAllList().CountAsync();
            return miembrosCount;
        }

        public async Task<int> GetAllPagosCountAsync()
        {
            var pagos = await _unitOfWork.GetGenericRepository<Pago>().GetAllList().CountAsync();
            return pagos;
        }

        public int GetAllUsersCountAsync()
        {
            var users = _userManager.Users.Count();
            return users; // Devuelve la cantidad de usuarios
        }
    }
}
