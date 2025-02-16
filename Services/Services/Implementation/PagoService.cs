using ServiceLayer.Services.Interfaces;
using DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using System.Threading.Tasks;
using Entity.WebAplication.Entities;
using AutoMapper;
using DAL.UnitOfWork.Interfaces;
using AutoMapper.QueryableExtensions;
using Entity.WebAplication.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Data;
using NToastNotify;
using ServiceLayer.Messages.WebApplication;
using ServiceLayer.Exception.WebApplication;
using DAL.Context;

namespace ServiceLayer.Services.Implementation
{
    public class PagoService : IPagoService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        private readonly IGenericRepository<Pago> _pagoRepository;
        private readonly IGenericRepository<DetallePago> _detallePagoRepository;
        private readonly IGenericRepository<AutorizacionPago> _autorizacionPagoRepository;
        private readonly IGenericRepository<Recibo> _reciboRepository;
        private readonly IGenericRepository<ModalidadPago> _modalidadPagoRepository;
        private readonly IGenericRepository<Miembro> _miemebroRepository;
        private readonly ICuentaCorrienteService _cuentaCorrienteService;

        private readonly IToastNotification _toasty;
        private const string Section = "El pago";

        public PagoService(
            IUnitOfWork unitOfWork,
            IMapper mapper,
            IGenericRepository<Pago> pagoRepository,
            IGenericRepository<DetallePago> detallePagoRepository,
            IGenericRepository<AutorizacionPago> autorizacionPagoRepository,
            IGenericRepository<Recibo> reciboRepository,
            IGenericRepository<ModalidadPago> modalidadPagoRepository,
            IGenericRepository<Miembro> miemebroRepository,
            IToastNotification toasty,
            ICuentaCorrienteService cuentaCorrienteService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;

            _pagoRepository = pagoRepository;
            _detallePagoRepository = detallePagoRepository;
            _autorizacionPagoRepository = autorizacionPagoRepository;
            _reciboRepository = reciboRepository;
            _modalidadPagoRepository = modalidadPagoRepository;
            _miemebroRepository = miemebroRepository;
            _toasty = toasty;
            _cuentaCorrienteService = cuentaCorrienteService;
        }

        public async Task<List<VMPago>> GetAllListAsync()
        {
            var pagos = await _unitOfWork.GetGenericRepository<Pago>()
                .GetAllList()
                .Where(p => p.Activo == true)
                .Include(p => p.ModalidadPago)
                .Include(p => p.Autorizacion)
                .ThenInclude(p => p.EstadoAutorizacion)
                .Include(p => p.Miembro)
                .Include(p => p.Recibo)
                .Include(p => p.ListaDetalles)
                .ThenInclude(dp => dp.CategoriaPago) 
                .ToListAsync();

            var pagoListaVM = pagos.Select(p => new VMPago
            {
                Id = p.Id,
                Codigo = p.Codigo,
                Total = p.Total,
                TipoModalidad = p.TipoModalidad,
                Monto = p.Total,
                FechaDePago = p.ModalidadPago != null ? p.ModalidadPago.FechaDePago : DateTime.MinValue,  // Usar DateTime.MinValue si es null
                Observacion = p.ModalidadPago != null ? p.ModalidadPago.Observacion : null,

                Miembro = new VMMiembro
                {
                    Id = p.Miembro.Id,
                    Nombre = p.Miembro.Nombre,
                },
                Autorizacion = new VMPagoAutorizacion
                {
                    Id = p.Autorizacion.Id,
                    Autorizado = p.Autorizacion.Autorizado,
                    Fecha = p.Autorizacion.Fecha,
                    EstadoAutorizacion = new VMEstadoAutorizacion
                    {
                        Id = p.Autorizacion.EstadoAutorizacion.Id,
                        Estado = p.Autorizacion.EstadoAutorizacion.Estado
                    },
                },
                ListaDetalles = p.ListaDetalles.Select(dp => new VMDetallePago
                {
                    Id = dp.Id,
                    Monto = dp.Monto,
                    CategoriaPago = dp.CategoriaPago != null
                        ? new VMCategoriaPago
                        {
                            Id = dp.CategoriaPago.Id,
                            CategoriaNombre = dp.CategoriaPago.CategoriaNombre
                        }
                        : null
                }).ToList()

            }).ToList();

            return pagoListaVM;
        }

        public async Task CreateEntityAsync(VMPago entity, List<DetallePago> listaDetalles)
        {
            var pago = _mapper.Map<Pago>(entity);
            await _unitOfWork.BeginTransactionAsync();

            try
            {
                // Lógica de modalidades de pago (Efectivo, Deposito, etc.)
                switch (entity.TipoModalidad)
                {
                    case "Efectivo":
                        pago.ModalidadPago = new Efectivo
                        {
                            FechaDePago = DateTime.Now,
                            Observacion = entity.Modalidad.Observacion,
                            NombreCompleto = entity.Modalidad.NombreCompleto
                        };
                        break;
                    case "Deposito":
                        pago.ModalidadPago = new Deposito
                        {
                            FechaDePago = DateTime.Now,
                            NombreCompleto = entity.Modalidad.NombreCompleto,
                            NumeroCuenta = entity.Deposito.NumeroCuenta,
                            NumeroSucursal = entity.Deposito.NumeroSucursal,
                            NumeroOperacion = entity.Deposito.NumeroOperacion,
                            Observacion = entity.Modalidad.Observacion
                        };
                        break;
                    case "Transferencia":
                        pago.ModalidadPago = new Transferencia
                        {
                            FechaDePago = DateTime.Now,
                            Observacion = entity.Modalidad.Observacion,
                            NombreCompleto = entity.Modalidad.NombreCompleto,
                            NroCuentaOrigenFondo = entity.Transferencia.NroCuentaOrigenFondo,
                            BancoOrigen = entity.Transferencia.BancoOrigen,
                            Dni = entity.Transferencia.Dni,
                            NumeroOperacion = entity.Transferencia.NumeroOperacion,
                        };
                        break;
                    default:
                        throw new InvalidOperationException("Modalidad no válida");
                }

                var query = _unitOfWork.GetGenericRepository<Miembro>().GetAllList()
                .Where(m => m.Id == entity.MiembroId)
                .Include(m => m.Organismo)
                .ThenInclude(o => o.Resumen)
                .Include(m => m.Deuda); // Incluir la relación con Deuda

                var miembro = await query.FirstOrDefaultAsync();

                if (miembro == null)
                {
                    throw new InvalidOperationException("El miembro no existe o no se pudieron cargar las relaciones.");
                }

                var organismoId = miembro.OrganismoId;
                var resumen = await _unitOfWork.GetGenericRepository<Resumen>().GetAllList().FirstOrDefaultAsync(r => r.OrganismoId == organismoId);

                if (resumen == null)
                {
                    throw new InvalidOperationException("No se encontró el Resumen relacionado.");
                }

                pago.Activo = true;
                pago.ResumenId = resumen.Id;
                pago.MiembroId = miembro.Id;


                // Asignar el Código y Monto del Pago
                var ultimoCodigoPago = await _unitOfWork.GetGenericRepository<Pago>()
                    .GetAllList()
                    .OrderByDescending(o => o.Codigo)
                    .FirstOrDefaultAsync();
                pago.Codigo = (ultimoCodigoPago != null) ? ultimoCodigoPago.Codigo + 1 : 1;
                pago.Total = listaDetalles.Sum(d => d.Monto);

                // Crear la nueva Autorización de pago
                var estadoPendiente = await _unitOfWork.GetGenericRepository<EstadoAutorizacion>()
                    .GetAllList()
                    .FirstOrDefaultAsync(r => r.Id == 2);

                if (estadoPendiente == null)
                {
                    throw new System.Exception("El estado 'Pendiente' no existe.");
                }

                var nuevaAutorizacion = new AutorizacionPago
                {
                    Observacion = "Pago pendiente de autorización.",
                    Fecha = DateTime.Now,
                    Autorizado = false, // Inicialmente no autorizado
                    EstadoAutorizacionId = 2
                };

 

                // Guardar la nueva Autorización de pago primero
                await _unitOfWork.GetGenericRepository<AutorizacionPago>().CreateEntityAsync(nuevaAutorizacion);
                await _unitOfWork.CommitAsync();

                // Asignar la AutorizaciónPago al Pago
                pago.Autorizacion = nuevaAutorizacion;

                // Crear el nuevo Pago
                await _unitOfWork.GetGenericRepository<Pago>().CreateEntityAsync(pago);
                await _unitOfWork.CommitAsync();


                if (pago.MiembroId != null)
                {
                    var dbContext = _unitOfWork.GetDbContext();

                    var deuda = await _unitOfWork.GetGenericRepository<Deuda>()
                        .GetAllList()
                        .FirstOrDefaultAsync(d => d.MiembroId == pago.MiembroId);

                    if (deuda != null)
                    {
                        deuda.DeudaPendiente = false;

                        // Marcar el objeto como modificado manualmente
                        dbContext.Entry(deuda).State = EntityState.Modified;

                        // Guardar los cambios en la base de datos
                        await _unitOfWork.CommitAsync();
                    }
                }

                // Generar el recibo
                var ultimoCodigoRecibo = await _unitOfWork.GetGenericRepository<Recibo>().GetAllList()
                    .OrderByDescending(o => o.Codigo).FirstOrDefaultAsync();
                int nuevoCodigoRecibo = (ultimoCodigoRecibo != null) ? ultimoCodigoRecibo.Codigo + 1 : 1;

                var recibo = new Recibo
                {
                    Fecha = DateTime.Now,
                    Codigo = nuevoCodigoRecibo,
                    Total = listaDetalles.Sum(detalle => detalle.Monto),
                    PagoId = pago.Id
                };

                await _unitOfWork.GetGenericRepository<Recibo>().CreateEntityAsync(recibo);
                await _unitOfWork.CommitAsync();

                // Crear detalles de pago

                foreach (var item in listaDetalles)
                {
                    var nuevoDetalle = new DetallePago
                    {
                        CategoriaPagoId = item.CategoriaPagoId,
                        Monto = item.Monto,
                        Pagoid = pago.Id
                    };
                    pago.ListaDetalles.Add(nuevoDetalle);
                    await _unitOfWork.GetGenericRepository<DetallePago>().CreateEntityAsync(nuevoDetalle);
                    //await UpdateDeuda(nuevoDetalle);
                }

                await _unitOfWork.CommitAsync();
                await _unitOfWork.CommitTransactionAsync();
                _toasty.AddSuccessToastMessage(NotificationMessagesWebApplication.AddMessage(Section), new ToastrOptions { Title = NotificationMessagesWebApplication.SuccessedTitle });
            }
            catch (SystemException ex)
            {
                await _unitOfWork.RollbackTransactionAsync();
                throw;
            }
        }

     
        public async Task DeleteEntityAsync(int id)
        {
            var pago = await _pagoRepository.GetEntityByIdAsync(id);
            pago.Activo = false;

            await _unitOfWork.CommitAsync();
            _toasty.AddWarningToastMessage(NotificationMessagesWebApplication.DeleteMessage(Section), new ToastrOptions { Title = NotificationMessagesWebApplication.SuccessedTitle });
        }

        public async Task UpdateEntityAsync(VMPago entity)
        {
            var pago = _mapper.Map<Pago>(entity);
            _pagoRepository.Update(pago);
            var result = await _unitOfWork.CommitAsync();

            if (!result)
            {
                throw new ClientSideExceptions(ExceptionMessages.ConcurencyException);
            }
            _toasty.AddInfoToastMessage(NotificationMessagesWebApplication.UpdateMessage(Section), new ToastrOptions { Title = NotificationMessagesWebApplication.SuccessedTitle });
        }

        public async Task<VMPago> GetPagoById(int id)
        {
            var pago = await _pagoRepository
                .Where(c => c.Id == id)
                .Include(p => p.ModalidadPago)
                .Include(p => p.Autorizacion)
                .ThenInclude(p => p.EstadoAutorizacion)
                .Include(p => p.Recibo)
                .Include(p => p.Miembro)
                .ThenInclude(p => p.Categoria)
                .Include(p => p.ListaDetalles)
                .ThenInclude(dp => dp.CategoriaPago)
                .Select(p => new VMPago
                {
                    Id = p.Id,
                    Codigo = p.Codigo,
                    Total = p.Total,
                    TipoModalidad = p.TipoModalidad,
                    Monto = p.Total,
                    FechaDePago = p.ModalidadPago.FechaDePago,
                    Observacion = p.ModalidadPago.Observacion,

                    Miembro = new VMMiembro
                    {
                        Id = p.Miembro.Id,
                        Nombre = p.Miembro.Nombre,
                        Apellido = p.Miembro.Apellido,
                        Dni = p.Miembro.Dni,

                        Categoria = new VMCategoria
                        {
                            Nombre = p.Miembro.Categoria.Nombre
                        }
                    },
                    Recibo = new VMRecibo
                    {
                        Id = p.Miembro.Id,
                        Codigo = p.Recibo.Codigo,
                        Fecha = p.Recibo.Fecha,
                        Total = p.Total
                    },

                    Autorizacion = new VMPagoAutorizacion
                    {
                        Id = p.Autorizacion.Id,
                        Autorizado = p.Autorizacion.Autorizado,
                        Fecha = p.Autorizacion.Fecha,
                        EstadoAutorizacion = new VMEstadoAutorizacion
                        {
                            Id = p.Autorizacion.EstadoAutorizacion.Id,
                            Estado = p.Autorizacion.EstadoAutorizacion.Estado
                        },
                    },

                    ListaDetalles = p.ListaDetalles.Select(dp => new VMDetallePago
                    {
                        Id = dp.Id,
                        Monto = dp.Monto,
                        CategoriaPago = dp.CategoriaPago != null
                        ? new VMCategoriaPago
                        {
                            Id = dp.CategoriaPago.Id,
                            CategoriaNombre = dp.CategoriaPago.CategoriaNombre
                        }
                    : null
                    }).ToList()

                }).SingleOrDefaultAsync();
            return pago;
        }

        public async Task<IEnumerable<VMCategoriaPago>> GetCategoriasAsync()
        {
            var categoriasVM = await _unitOfWork.GetGenericRepository<CategoriaPago>().GetAllList().ProjectTo<VMCategoriaPago>(_mapper.ConfigurationProvider).ToListAsync();
            return categoriasVM;
        }

        public async Task<bool> CambiarEstadoAsync(int idPago, int nuevoEstadoId)
        {
            var pago = await _unitOfWork.GetGenericRepository<Pago>().GetAllList()
        .Include(x => x.ListaDetalles)
        .Include(x => x.Autorizacion)
        .ThenInclude(x => x.EstadoAutorizacion)
        .Include(x => x.Miembro) // Incluir la relación con Miembro
        .ThenInclude(m => m.Deuda) // Incluir la relación con Deuda
        .FirstOrDefaultAsync(p => p.Id == idPago);

            if (pago == null)
            {
                return false;
            }

            // Acceder a la autorización
            var autorizacion = pago.Autorizacion;
            var antiguaAutorizacionId = pago.Autorizacion.EstadoAutorizacionId;

            if (autorizacion == null)
            {
                return false;
            }

            autorizacion.EstadoAutorizacionId = nuevoEstadoId;
            _unitOfWork.GetDbContext().Entry(autorizacion).State = EntityState.Modified;
            await _unitOfWork.CommitAsync();

            if(nuevoEstadoId == 6)
            {
                foreach (var detalle in pago.ListaDetalles)
                {
                    await RestaurarDeudaYResumenSiRechazado(detalle);
                }
            }
            else if(nuevoEstadoId == 1)
            {
                foreach (var detalle in pago.ListaDetalles)
                {
                    await UpdateDeuda(detalle);
                    await ActualizarSaldoSiAutorizado(detalle);

                    if (pago.Miembro?.Deuda != null)
                    {
                        var dbContext = _unitOfWork.GetDbContext();

                        // Obtener la deuda desde el contexto para evitar duplicados
                        var deuda = await dbContext.Set<Deuda>().FindAsync(pago.Miembro.Deuda.Id);

                        if (deuda != null)
                        {
                            deuda.FechaVencimiento = DateTime.Now.AddMinutes(2);

                            dbContext.Entry(deuda).State = EntityState.Modified;
                            await _unitOfWork.CommitAsync();
                        }
                    }
                }
            }

            _toasty.AddSuccessToastMessage("Estado actualizado correctamente.", new ToastrOptions { Title = "Éxito" });

            return true;
        }



        public async Task RenovarDeudasVencidasAsync()
        {
            const int CategoriaSeguroAcompanante = 6;
            const string EstadoAutorizado = "Autorizado"; // Estado requerido para renovar deuda

            // 🔹 Obtener deudas vencidas cuyos pagos estén autorizados
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
                deuda.DeudaPendiente = true;

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



        public async Task UpdateDeuda(DetallePago detalle)
        {
            //await RenovarDeudasVencidasAsync(detalle);

            var deuda = await _unitOfWork.GetGenericRepository<Deuda>().Where(d => d.MiembroId == detalle.Pago.MiembroId)/*.Include(x => x.Organismo)*/.FirstOrDefaultAsync();


            if (deuda == null)
            {
                throw new InvalidOperationException($"No se encontró una deuda para el miembro con ID: {detalle.Pagoid}");
            }

            // Guardamos los valores originales de la deuda por si el pago es rechazado
            decimal deudaOriginalAfiliacion = deuda.MontoAfiliacion;
            decimal deudaOriginalSeguro = deuda.MontoSeguroAcompañante;

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

            _unitOfWork.GetGenericRepository<Deuda>().Update(deuda);
            await _unitOfWork.CommitAsync();

            // Guardamos los valores originales en caso de rechazo
            detalle.DeudaOriginalAfiliacion = deudaOriginalAfiliacion;
            detalle.DeudaOriginalSeguro = deudaOriginalSeguro;
        }

        //Se ejecuta solo si el pago es autorizado
        public async Task ActualizarSaldoSiAutorizado(DetallePago detalle)
        {
            if(detalle.CategoriaPagoId == 1)
            {
                await _cuentaCorrienteService.GestionarSaldosPagos(detalle.Monto, 0); // afiliacion
            }
            else if (detalle.CategoriaPagoId == 2)
            {
                await _cuentaCorrienteService.GestionarSaldosPagos(0, detalle.Monto);
            }
        }


        public async Task RestaurarDeudaSiRechazado(DetallePago detalle)
        {
            var deuda = await _unitOfWork.GetGenericRepository<Deuda>()
                .Where(d => d.MiembroId == detalle.Pago.MiembroId)
                .FirstOrDefaultAsync();

            if (deuda == null)
            {
                throw new InvalidOperationException($"No se encontró una deuda para el miembro con ID: {detalle.Pagoid}");
            }

            // Convertimos los valores nullable a decimal (si son null, toman el valor 0 por defecto)
            deuda.MontoAfiliacion = detalle.DeudaOriginalAfiliacion.GetValueOrDefault();
            deuda.MontoSeguroAcompañante = detalle.DeudaOriginalSeguro.GetValueOrDefault();
            deuda.Tiene = (deuda.MontoAfiliacion > 0 || deuda.MontoSeguroAcompañante > 0);

            _unitOfWork.GetGenericRepository<Deuda>().Update(deuda);
            await _unitOfWork.CommitAsync();
        }

        public async Task RestaurarDeudaYResumenSiRechazado(DetallePago detalle)
        {
            var deuda = await _unitOfWork.GetGenericRepository<Deuda>()
                .Where(d => d.MiembroId == detalle.Pago.MiembroId)
                .FirstOrDefaultAsync();

            if (deuda == null)
            {
                throw new InvalidOperationException($"No se encontró una deuda para el miembro con ID: {detalle.Pago.MiembroId}");
            }

            // Restaurar valores de la deuda
            deuda.MontoAfiliacion = detalle.DeudaOriginalAfiliacion.GetValueOrDefault();
            deuda.MontoSeguroAcompañante = detalle.DeudaOriginalSeguro.GetValueOrDefault();
            deuda.Tiene = (deuda.MontoAfiliacion > 0 || deuda.MontoSeguroAcompañante > 0);

            _unitOfWork.GetGenericRepository<Deuda>().Update(deuda);

            //var resumen = await _unitOfWork.GetGenericRepository<Resumen>().GetAllList().AsNoTracking().SingleOrDefaultAsync();


            //if (resumen == null)
            //{
            //    throw new InvalidOperationException($"No se encontró un resumen para el organismo con ID:");
            //}

            //// 🔹 Usamos propiedades existentes en "Resumen"
            //resumen.Debito += detalle.Monto;  // Restar el monto rechazado del débito
            //resumen.Credito -= detalle.Monto; // Volver a sumar el crédito disponible
            //resumen.SaldoTotal -= detalle.Monto; // Ajustar el saldo total

            //if (detalle.CategoriaPagoId == 1)
            //{
            //    resumen.DebitoAfiliacion += detalle.Monto;
            //    resumen.CreditoAfiliacion -= detalle.Monto;
            //    resumen.SaldoAfiliacion = detalle.Monto;
            //}
            //else if (detalle.CategoriaPagoId == 2)
            //{
            //    resumen.DebitoSeguroAcompañante += detalle.Monto;
            //    resumen.CreditoSeguroAcompañante -= detalle.Monto;

            //    resumen.SaldoSeguroAcompañante -= detalle.Monto;
            //}

            //_unitOfWork.GetGenericRepository<Resumen>().Update(resumen);

            await _unitOfWork.CommitAsync();
        }



        public async Task<IEnumerable<VMEstadoAutorizacion>> GetEstadosAutorizacionAsync()
        {
            var estadosVM = await _unitOfWork
                .GetGenericRepository<EstadoAutorizacion>()
                .GetAllList()
                .ProjectTo<VMEstadoAutorizacion>(_mapper.ConfigurationProvider)
                .ToListAsync(); 
            
            return estadosVM;
        }

        public async Task DeleteDetalleAsync(int id)
        {
            var detallPago = await _pagoRepository.GetEntityByIdAsync(id);
            _pagoRepository.Delete(detallPago);
            await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<VMPagoModalidad>> GetModalidadesAsync()
        {
            var modalidadesVM = await _unitOfWork.GetGenericRepository<ModalidadPago>().GetAllList().ProjectTo<VMPagoModalidad>(_mapper.ConfigurationProvider).ToListAsync();
            return modalidadesVM;
        }
    }
}