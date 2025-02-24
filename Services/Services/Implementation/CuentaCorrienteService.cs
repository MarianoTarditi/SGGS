using AutoMapper;
using AutoMapper.QueryableExtensions;
using DAL.Repositories.Interfaces;
using DAL.UnitOfWork.Interfaces;
using Entity.WebAplication.Entities;
using Entity.WebAplication.ViewModels;
using Microsoft.EntityFrameworkCore;
using NToastNotify;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Implementation
{
    public class CuentaCorrienteService : ICuentaCorrienteService
    {
        private readonly IGenericRepository<Resumen> _resumenRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IToastNotification _toasty;

        public CuentaCorrienteService(IUnitOfWork unitOfWork, IMapper mapper, IToastNotification toasty, IGenericRepository<Resumen> resumenRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _toasty = toasty;
            _resumenRepository = resumenRepository;
        }

        public async Task<Dictionary<string, int>> GetCategoriaMiembroAsync()
        {
            var categoriasCount = new Dictionary<string, int>
            {
                { "Protagonista", 0 },
                { "Educador", 0 },
                { "Acompañante", 0 }
            };

            // Obtener todos los miembros desde la base de datos, incluyendo la categoría asociada a cada miembro
            var miembros = await _unitOfWork.GetGenericRepository<Miembro>().GetAllList().Where(x => x.Activo == true).Include(x => x.Categoria).ToListAsync();

            // Contar cuántos miembros pertenecen a cada categoría
            foreach (var miembro in miembros)
            {
                if (miembro.Categoria != null && categoriasCount.ContainsKey(miembro.Categoria.Nombre))
                {
                    categoriasCount[miembro.Categoria.Nombre]++;
                }
            }

            return categoriasCount;
        }

        public async Task<Dictionary<string, int>> GetEducadoresInsigniaAsync()
        {
            var insigniaCount = new Dictionary<string, int>
            {
                { "Con Insignia", 0 },
                { "Sin Insignia", 0 }
            };

            // Obtener la cantidad de educadores con y sin insignia directamente desde la base de datos
            insigniaCount["Con Insignia"] = await _unitOfWork.GetGenericRepository<Miembro>()
                .GetAllList().Where(x => x.Activo == true)
                .Include(x => x.Categoria)
                .Where(x => x.Categoria.Nombre == "Educador" && x.InsigniaMadera == true)
                .CountAsync();

            insigniaCount["Sin Insignia"] = await _unitOfWork.GetGenericRepository<Miembro>()
                .GetAllList().Where(x => x.Activo == true)
                .Include(x => x.Categoria)
                .Where(x => x.Categoria.Nombre == "Educador" && x.InsigniaMadera == false)
                .CountAsync();

            return insigniaCount;
        }



        public async Task<Dictionary<string, int>> GetFuncionMiembroAsync()
        {
            var funcionCount = new Dictionary<string, int>
            {
                { "Jefe de Grupo", 0 },
                { "Jefe de Rama", 0 },
                { "Ayudante", 0 }
            };

            // Obtener todos los miembros desde la base de datos, incluyendo la categoría asociada a cada miembro
            var miembros = await _unitOfWork.GetGenericRepository<Miembro>().GetAllList().Where(x => x.Activo == true).Include(x => x.Funcion).ToListAsync();

            // Contar cuántos miembros pertenecen a cada categoría
            foreach (var miembro in miembros)
            {
                if (miembro.Funcion != null && funcionCount.ContainsKey(miembro.Funcion.Nombre))
                {
                    funcionCount[miembro.Funcion.Nombre]++;
                }
            }
            return funcionCount;
        }

        public async Task<Dictionary<string, int>> GetRamaMiembroAsync()
        {
            var ramaCount = new Dictionary<string, int>
            {
                { "Rover", 0 },
                { "Caminante", 0 },
                { "Scout", 0 },
                { "Manada", 0 }
            };

            // Obtener todos los miembros desde la base de datos, incluyendo la categoría asociada a cada miembro
            var miembros = await _unitOfWork.GetGenericRepository<Miembro>().GetAllList().Include(x => x.Rama).ToListAsync();

            // Contar cuántos miembros pertenecen a cada categoría
            foreach (var miembro in miembros)
            {
                if (miembro.Rama != null && ramaCount.ContainsKey(miembro.Rama.Nombre))
                {
                    ramaCount[miembro.Rama.Nombre]++;
                }
            }
            return ramaCount;
        }

        public async Task<Dictionary<string, int>> GetReligionMiembroAsync()
        {
            var religionCount = new Dictionary<string, int>
            {
                { "Cristiano", 0 },
                { "Cristiano Evangélico", 0 },
                { "Budista", 0 },
                { "Católica Ortodoxo", 0 },
                { "Islámica", 0 },
                { "Judía", 0 }

            };

            var miembros = await _unitOfWork.GetGenericRepository<Miembro>().GetAllList().Include(x => x.Religion).ToListAsync();

            foreach (var miembro in miembros)
            {
                if (miembro.Religion != null && religionCount.ContainsKey(miembro.Religion.Nombre))
                {
                    religionCount[miembro.Religion.Nombre]++;
                }
            }
            return religionCount;
        }

        public async Task<Dictionary<string, int>> GetEstadosPagosAsync()
        {
            var estadosCount = new Dictionary<string, int>
            {
                { "Autorizado", 0 },
                { "Pendiente", 0 },
                { "Rechazado", 0 }
            };

            // Obtener todos los miembros desde la base de datos, incluyendo la categoría asociada a cada miembro
            var pagos = await _unitOfWork.GetGenericRepository<Pago>().GetAllList().Where(x => x.Activo == true).Include(x => x.Autorizacion).ThenInclude(x => x.EstadoAutorizacion).ToListAsync();

            // Contar cuántos miembros pertenecen a cada categoría
            foreach (var pago in pagos)
            {
                if (pago.Autorizacion.EstadoAutorizacion != null && estadosCount.ContainsKey(pago.Autorizacion.EstadoAutorizacion.Estado))
                {
                    estadosCount[pago.Autorizacion.EstadoAutorizacion.Estado]++;
                }
            }

            return estadosCount;
        }

        public async Task<Dictionary<string, int>> GetCategoriasPagosAsync()
        {
            var estadosCount = new Dictionary<string, int>
            {
                { "Afiliación", 0 },
                { "Seguro de Acompañante", 0 }
            };

            // Obtener todos los pagos activos con sus detalles y categorías
            var pagos = await _unitOfWork.GetGenericRepository<Pago>().GetAllList().Where(p => p.Activo) // Filtrar solo los pagos activos
                .Include(p => p.ListaDetalles)
                .ThenInclude(d => d.CategoriaPago)
                .ToListAsync();

            // Contar los pagos que contienen al menos un detalle con la categoría específica
            foreach (var pago in pagos)
            {
                if (pago.ListaDetalles != null) // Evitar posibles nulos
                {
                    if (pago.ListaDetalles.Any(d => d.CategoriaPago.CategoriaNombre == "Afiliación"))
                    {
                        estadosCount["Afiliación"]++;
                    }
                    if (pago.ListaDetalles.Any(d => d.CategoriaPago.CategoriaNombre == "Seguro de Acompañante"))
                    {
                        estadosCount["Seguro de Acompañante"]++;
                    }
                }
            }

            return estadosCount;
        }

        public async Task<Dictionary<string, int>> GetModalidadesPagosAsync()
        {
            var tipoModalidadCount = new Dictionary<string, int>
            {
                { "Efectivo", 0 },
                { "Transferencia", 0 },
                { "Déposito", 0 }
            };

            // Obtener todos los pagos activos con sus detalles y categorías
            var pagos = await _unitOfWork.GetGenericRepository<Pago>().GetAllList().Where(p => p.Activo) // Filtrar solo los pagos activos
                .ToListAsync();

            // Contar los pagos que contienen al menos un detalle con la categoría específica
            foreach (var pago in pagos)
            {
                if (pago.TipoModalidad != null && tipoModalidadCount.ContainsKey(pago.TipoModalidad))
                {
                    tipoModalidadCount[pago.TipoModalidad]++;
                }
            }

            return tipoModalidadCount;
        }

        public async Task<Tuple<Dictionary<string, int>, int>> GetPagosPorDia(DateTime startDate, DateTime endDate)
        {
            // Crear un diccionario con los últimos 14 días y valores en 0
            var pagosPorDia = Enumerable.Range(0, (endDate - startDate).Days + 1)
                .Select(i => new { Fecha = startDate.AddDays(i).ToString("yyyy-MM-dd"), Cantidad = 0 })
                .ToDictionary(x => x.Fecha, x => x.Cantidad);

            // Obtener los pagos de la base de datos
            var pagos = await _unitOfWork.GetGenericRepository<Pago>()
                .GetAllList()
                .Where(p => !string.IsNullOrEmpty(p.CreatedDate)) // Filtrar nulos o vacíos
                .ToListAsync();

            // Filtrar y agrupar pagos en memoria
            var pagosAgrupados = pagos
                .Where(p => DateTime.TryParse(p.CreatedDate, out _)) // Convertir solo los que son válidos
                .Where(p => DateTime.Parse(p.CreatedDate).Date >= startDate && DateTime.Parse(p.CreatedDate).Date <= endDate) // Filtrar por el rango de fechas
                .GroupBy(p => DateTime.Parse(p.CreatedDate).Date) // Agrupar por fecha sin hora
                .Select(g => new
                {
                    Fecha = g.Key.ToString("yyyy-MM-dd"),
                    Cantidad = g.Count()
                })
                .ToList();

            // Actualizar el diccionario con los valores obtenidos de la BD
            foreach (var pago in pagosAgrupados)
            {
                pagosPorDia[pago.Fecha] = pago.Cantidad;
            }

            // Calcular el valor máximo de pagos en el rango de fechas
            var maxPagos = pagosPorDia.Values.Max();

            return Tuple.Create(pagosPorDia, maxPagos);
        }

        public async Task<Tuple<Dictionary<string, decimal>, decimal>> GetMontoTotalPorDia(DateTime startDate, DateTime endDate)
        {
            // Crear un diccionario con los días en el rango y valores en 0
            var montoPorDia = Enumerable.Range(0, (endDate - startDate).Days + 1)
                .Select(i => new { Fecha = startDate.AddDays(i).ToString("yyyy-MM-dd"), MontoTotal = 0m }) // Usar decimal para representar los montos
                .ToDictionary(x => x.Fecha, x => x.MontoTotal);

            // Obtener los pagos de la base de datos
            var pagos = await _unitOfWork.GetGenericRepository<Pago>()
                .GetAllList().Include(x => x.Recibo)
                .Where(p => !string.IsNullOrEmpty(p.CreatedDate) && p.Recibo.Total > 0) // Filtrar nulos o vacíos y pagos válidos
                .ToListAsync();

            // Filtrar y agrupar pagos por fecha
            var pagosAgrupados = pagos
                .Where(p => DateTime.TryParse(p.CreatedDate, out _)) // Filtrar solo pagos con fecha válida
                .Where(p => DateTime.Parse(p.CreatedDate).Date >= startDate && DateTime.Parse(p.CreatedDate).Date <= endDate) // Filtrar por el rango de fechas
                .GroupBy(p => DateTime.Parse(p.CreatedDate).Date) // Agrupar por fecha sin hora
                .Select(g => new
                {
                    Fecha = g.Key.ToString("yyyy-MM-dd"),
                    MontoTotal = g.Sum(p => p.Recibo != null ? p.Recibo.Total : 0) // Sumar el monto de los pagos (recibo) en ese día
                })
                .ToList();


            // Actualizar el diccionario con los valores obtenidos de la base de datos
            foreach (var pago in pagosAgrupados)
            {
                montoPorDia[pago.Fecha] = pago.MontoTotal;
            }

            // Calcular el valor máximo de monto total en el rango de fechas
            var maxMonto = montoPorDia.Values.Max();

            return Tuple.Create(montoPorDia, maxMonto);
        }

        public async Task GestionarSaldosMiembros(decimal montoAfiliacion, decimal montoSeguro)
        {
            var resumen = await _unitOfWork.GetGenericRepository<Resumen>().GetAllList().SingleOrDefaultAsync();

            if (resumen == null)
            {
                throw new InvalidOperationException("No se encontró un resumen de saldo.");
            }

            if (montoAfiliacion == 0)
            {
                resumen.DebitoSeguroAcompañante += montoSeguro;
                resumen.SaldoSeguroAcompañante -= montoSeguro;
            }
            else
            {
                resumen.DebitoAfiliacion += montoAfiliacion;
                resumen.SaldoAfiliacion -= montoAfiliacion;
            }

            // ✅ Actualizar los valores generales de débito y saldo
            resumen.Debito = resumen.DebitoAfiliacion + resumen.DebitoSeguroAcompañante;
            resumen.SaldoTotal = resumen.SaldoAfiliacion + resumen.SaldoSeguroAcompañante;

            _unitOfWork.GetGenericRepository<Resumen>().Update(resumen);
            await _unitOfWork.CommitAsync();
        }

        public async Task GestionarSaldosPagos(decimal montoAfiliacion, decimal montoSeguro)
        {
            var resumen = await _unitOfWork.GetGenericRepository<Resumen>().GetAllList().SingleOrDefaultAsync();

            if (resumen == null)
            {
                throw new InvalidOperationException("No se encontró un resumen de saldo.");
            }

            if (montoAfiliacion == 0)
            {
                resumen.CreditoSeguroAcompañante += montoSeguro;
                resumen.SaldoSeguroAcompañante += montoSeguro;
            }
            else
            {
                resumen.CreditoAfiliacion += montoAfiliacion;
                resumen.SaldoAfiliacion += montoAfiliacion;
            }

            // ✅ Actualizar los valores generales de crédito y saldo
            resumen.Credito = resumen.CreditoAfiliacion + resumen.CreditoSeguroAcompañante;
            resumen.SaldoTotal = resumen.SaldoAfiliacion + resumen.SaldoSeguroAcompañante;

            _unitOfWork.GetGenericRepository<Resumen>().Update(resumen);
            await _unitOfWork.CommitAsync();
        }

        // ✅ Método para obtener el saldo total de cada categoría y el general
        public async Task<(decimal saldoAfiliacion, decimal saldoSeguroAcompañante, decimal saldoTotal, decimal debito, decimal credito, decimal debitoAfiliacion, decimal debitoSeguro, decimal creditoAfiliacion, decimal creditoSeguro)> ObtenerSaldoTotal()
        {
            var resumen = await _unitOfWork.GetGenericRepository<Resumen>().GetAllList().AsNoTracking().SingleOrDefaultAsync();

            if (resumen == null)
            {
                throw new InvalidOperationException("No se encontró un resumen de saldo.");
            }

            return (resumen.SaldoAfiliacion, resumen.SaldoSeguroAcompañante, resumen.SaldoTotal, resumen.Debito, resumen.Credito, resumen.DebitoAfiliacion, resumen.DebitoSeguroAcompañante, resumen.CreditoAfiliacion, resumen.CreditoSeguroAcompañante);
        }


    

        public bool ActualizarPrecio(string tipo, decimal nuevoPrecio)
        {
            try
            {
                var organismo = _unitOfWork.GetGenericRepository<Organismo>().GetAllList().SingleOrDefault();
                if (organismo == null)
                {
                    return false;
                }

                if (tipo == "afiliacion")
                {
                    organismo.ValorAfiliacion = nuevoPrecio;
                }
                else if (tipo == "seguro")
                {
                    organismo.ValorSeguro = nuevoPrecio;
                }
                else
                {
                    return false;
                }

                _unitOfWork.GetGenericRepository<Organismo>().Update(organismo);
                _unitOfWork.CommitAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
