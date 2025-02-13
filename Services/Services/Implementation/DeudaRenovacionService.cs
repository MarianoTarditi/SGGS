using DAL.UnitOfWork.Interfaces;
using Entity.WebAplication.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Implementation
{
    public class DeudaRenovacionService : BackgroundService
    {
        private readonly IServiceScopeFactory _scopeFactory;
        private readonly TimeSpan _intervalo = TimeSpan.FromMinutes(1); // Ejecutar cada 1 minuto

        private readonly ILogger<DeudaRenovacionService> _logger;

        public DeudaRenovacionService(ILogger<DeudaRenovacionService> logger, IServiceScopeFactory scopeFactory)
        {
            _logger = logger;
            _scopeFactory = scopeFactory;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("🔄 Servicio Iniciado");

            try
            {
                while (!stoppingToken.IsCancellationRequested)
                {
                    _logger.LogInformation("⏳ Ejecutando renovación de deudas...");

                    using (var scope = _scopeFactory.CreateScope())
                    {
                        var unitOfWork = scope.ServiceProvider.GetRequiredService<IUnitOfWork>();
                        var cuentaCorrienteService = scope.ServiceProvider.GetRequiredService<ICuentaCorrienteService>();

                        await RenovarDeudasVencidasAsync(unitOfWork, cuentaCorrienteService);
                    }

                    _logger.LogInformation("✅ Renovación completada.");
                    await Task.Delay(TimeSpan.FromMinutes(1), stoppingToken);
                }
            }
            catch (SystemException ex)
            {
                _logger.LogError("❌ Error en DeudaRenovacionService: {Message}", ex.Message);
            }

            _logger.LogInformation("⏹️ Servicio Detenido");
        }


        private async Task RenovarDeudasVencidasAsync(IUnitOfWork _unitOfWork, ICuentaCorrienteService _cuentaCorrienteService)
        {
            const int CategoriaSeguroAcompanante = 6;
            const string EstadoAutorizado = "Autorizado";

            var deudasVencidas = await _unitOfWork.GetGenericRepository<Deuda>().Where(d => DateTime.Now >= d.FechaVencimiento
                 && d.Miembro.Pagos.Any(p => p.Autorizacion.EstadoAutorizacion.Estado == "Autorizado")) // Solo si está autorizado
                .Include(d => d.Miembro)
                .ThenInclude(m => m.Pagos) // Incluir pagos del miembro
                .ThenInclude(p => p.Autorizacion) // Incluir autorización del pago
                .ToListAsync();

            var organismo = await _unitOfWork.GetGenericRepository<Organismo>()
                .GetAllList()
                .FirstOrDefaultAsync();

            if (organismo == null || !deudasVencidas.Any())
                return;

            foreach (var deuda in deudasVencidas)
            {
                deuda.Tiene = true;
                deuda.FechaVencimiento = DateTime.Now.AddMinutes(5);

                if (deuda.Miembro.CategoriaId == CategoriaSeguroAcompanante)
                {
                    deuda.MontoSeguroAcompañante = organismo.ValorSeguro;
                    await _cuentaCorrienteService.GestionarSaldosMiembros(0, organismo.ValorSeguro);
                }
                else
                {
                    deuda.MontoAfiliacion = organismo.ValorAfiliacion;
                    await _cuentaCorrienteService.GestionarSaldosMiembros(organismo.ValorAfiliacion, 0);
                }
            }

            await _unitOfWork.CommitAsync();
        }
    }
}

