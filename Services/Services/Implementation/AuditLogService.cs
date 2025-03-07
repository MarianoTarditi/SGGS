using BLL.Services.Interfaces;
using DAL.Repositories.Interfaces;
using DAL.UnitOfWork.Interfaces;
using Entity.Identity.Entities;
using Entity.WebAplication.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL.Services.Implementation
{
    public class AuditLogService : IAuditLogService
    {
        private readonly IGenericRepository<AuditLog> _auditLogRepository;
        private readonly IUnitOfWork _unitOfWork;

        public AuditLogService(IGenericRepository<AuditLog> auditLogRepository, IUnitOfWork unitOfWork)
        {
            _auditLogRepository = auditLogRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<List<AuditLog>> GetAllLogsAsync()
        {
            return await _unitOfWork.GetGenericRepository<AuditLog>().GetAllList().ToListAsync();
        }

        public async Task<List<AuditLogAuthentication>> GetAllLogsAuhtenticationAsync()
        {
            return await _unitOfWork.GetGenericRepository<AuditLogAuthentication>().GetAllList().ToListAsync();
        }

        public async Task<Dictionary<string, int>> GetAccionesSobreMiembrosAsync()
        {
            var accionesCount = new Dictionary<string, int>
            {
                { "Created", 0 },
                { "Modified", 0 },
                { "Deleted", 0 }
            };

            // Obtener todas las auditorías relacionadas con Miembro
            var auditorias = await _unitOfWork.GetGenericRepository<AuditLog>()
                .GetAllList()
                .Where(a => a.EntityName == "Miembro")
                .ToListAsync();

            // 📌 Imprimir los registros obtenidos en consola
            Console.WriteLine($"Total de registros obtenidos: {auditorias.Count}");
            foreach (var audit in auditorias)
            {
                Console.WriteLine($"ID: {audit.Id}, Acción: {audit.Action}, Usuario: {audit.UserEmail}");
            }

            // Contar las acciones correctamente
            foreach (var audit in auditorias)
            {
                if (audit.Action != null && accionesCount.ContainsKey(audit.Action))
                {
                    accionesCount[audit.Action]++;
                }
            }

            return accionesCount;
        }

    }
}
