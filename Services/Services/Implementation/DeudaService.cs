using AutoMapper;
using DAL.UnitOfWork.Interfaces;
using Entity.WebAplication.Entities;
using Microsoft.EntityFrameworkCore;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Implementation
{
    public class DeudaService : IDeudaService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        private readonly ICuentaCorrienteService _cuentaCorrienteService;

        public DeudaService(IUnitOfWork unitOfWork, IMapper mapper, ICuentaCorrienteService cuentaCorrienteService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _cuentaCorrienteService = cuentaCorrienteService;
        }

        public async Task RenovarDeudasVencidasAsync(int miembroId)
        {
            const int CategoriaSeguroAcompanante = 6;
            const string EstadoAutorizado = "Autorizado";
            const string EstadoPendiente = "Pendiente";


            // 🔹 Obtener la deuda vencida del miembro
            var deuda = await _unitOfWork.GetGenericRepository<Deuda>()
            .Where(d => d.MiembroId == miembroId && DateTime.Now >= d.FechaVencimiento)
            .Include(d => d.Miembro)
                .ThenInclude(m => m.Pagos)
            .ThenInclude(p => p.ModalidadPago)
            .Include(d => d.Miembro)
                .ThenInclude(m => m.Pagos)
                    .ThenInclude(p => p.Autorizacion)
                        .ThenInclude(p => p.EstadoAutorizacion)  // ✅ Ahora incluye Autorizacion correctamente
            .FirstOrDefaultAsync();

            var deudasVencidas = await _unitOfWork.GetGenericRepository<Deuda>().Where(d => DateTime.Now >= d.FechaVencimiento
              && d.Miembro.Pagos.Any(p => p.Autorizacion.EstadoAutorizacion.Estado == "Autorizado")) // Solo si está autorizado
             .Include(d => d.Miembro)
             .ThenInclude(m => m.Pagos) // Incluir pagos del miembro
             .ThenInclude(p => p.Autorizacion) // Incluir autorización del pago
             .ToListAsync();

            if (deuda == null) return;

            // 🔹 Obtener datos del organismo
            var organismo = await _unitOfWork.GetGenericRepository<Organismo>()
                .GetAllList()
                .FirstOrDefaultAsync();

            if (organismo == null) return;

            // 🔹 Buscar el pago más reciente
            var pagoMasReciente = deuda.Miembro.Pagos.OrderByDescending(p => p.ModalidadPago.FechaDePago).FirstOrDefault();

            // 🔹 Verificar si el último pago es válido
            bool tienePagoValido = pagoMasReciente?.Autorizacion?.EstadoAutorizacion?.Estado is "Autorizado";

            // 🔹 Verificar si hay pagos autorizados vencidos
            bool tienePagosAutorizadosVencidos = deuda.Miembro.Pagos.Any(p => p.Autorizacion.EstadoAutorizacion.Estado == EstadoAutorizado && DateTime.Now >= p.Miembro.Deuda.FechaVencimiento);

            if (pagoMasReciente.Autorizacion.EstadoAutorizacion.Estado == "Autorizado")
            {
                deuda.DeudaPendiente = tienePagosAutorizadosVencidos;
                deuda.Tiene = true;

                if (tienePagosAutorizadosVencidos && !deuda.SaldoDebitado)  // ✅ Solo si aún no se ha debitado
                {
                    // 🔹 Asignar montos según la categoría del miembro
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

                    deuda.SaldoDebitado = true;  // ✅ Marcar como debitado para evitar futuros descuentos
                }
            }
            else if (pagoMasReciente.Autorizacion.EstadoAutorizacion.Estado == "Pendiente")
            {
                deuda.DeudaPendiente = false;
            }
            else
            {
                deuda.DeudaPendiente = true;
            }

            await _unitOfWork.CommitAsync();
        }

        public async Task UpdateDeuda(DetallePago detalle)
        {



            var deuda = await _unitOfWork.GetGenericRepository<Deuda>().Where(d => d.MiembroId == detalle.Pago.MiembroId)/*.Include(x => x.Organismo)*/.FirstOrDefaultAsync();

            if (deuda == null)
            {
                throw new InvalidOperationException($"No se encontró una deuda para el miembro con ID: {detalle.Pagoid}");
            }

            var pago = await _unitOfWork.GetGenericRepository<Pago>().GetAllList()
           .Include(x => x.ListaDetalles)
           .Include(x => x.Autorizacion)
           .ThenInclude(x => x.EstadoAutorizacion)
           .Include(x => x.Miembro) // Incluir la relación con Miembro
           .ThenInclude(m => m.Deuda) // Incluir la relación con Deuda
           .FirstOrDefaultAsync(p => p.Id == detalle.Pagoid);

            if (pago.Autorizacion.EstadoAutorizacion.Estado == "Rechazado")
            {
                // Guardamos los valores originales de la deuda por si el pago es rechazado
                decimal deudaOriginalAfiliacion = deuda.MontoAfiliacion;
                decimal deudaOriginalSeguro = deuda.MontoSeguroAcompañante;

                // Guardamos los valores originales en caso de rechazo
                detalle.DeudaOriginalAfiliacion = deudaOriginalAfiliacion;
                detalle.DeudaOriginalSeguro = deudaOriginalSeguro;
            }
            else
            {
                if (detalle.CategoriaPagoId == 1) // Afiliación
                {
                    if (detalle.Monto > deuda.MontoAfiliacion)
                    {
                        throw new InvalidOperationException("¡El monto del pago no puede superar al monto de la deuda!");
                    }
                    deuda.MontoAfiliacion -= detalle.Monto;
                }
                else if (detalle.CategoriaPagoId == 2) // Seguro
                {
                    if (detalle.Monto > deuda.MontoSeguroAcompañante)
                    {
                        throw new InvalidOperationException("¡El monto del pago no puede superar al monto de la deuda!");
                    }
                    deuda.MontoSeguroAcompañante -= detalle.Monto;
                }

                deuda.Tiene = (deuda.MontoAfiliacion > 0 || deuda.MontoSeguroAcompañante > 0);
                //deuda.DeudaPendiente = false;
                deuda.FechaCreacion = DateTime.Now;
            }

            _unitOfWork.GetGenericRepository<Deuda>().Update(deuda);
            await _unitOfWork.CommitAsync();
        }

        public async Task ActualizarSaldoSiAutorizado(DetallePago detalle)
        {
            if (detalle.CategoriaPagoId == 1)
            {
                await _cuentaCorrienteService.GestionarSaldosPagos(detalle.Monto, 0); // afiliacion
            }
            else if (detalle.CategoriaPagoId == 2)
            {
                await _cuentaCorrienteService.GestionarSaldosPagos(0, detalle.Monto);
            }
        }
    }
}
