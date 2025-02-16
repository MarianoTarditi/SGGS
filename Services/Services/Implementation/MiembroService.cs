using AutoMapper;
using AutoMapper.QueryableExtensions;
using Azure.Core;
using DAL.Context;
using DAL.Repositories.Interfaces;
using DAL.UnitOfWork.Interfaces;
using Entity.WebAplication.Entities;
using Entity.WebAplication.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using NToastNotify;
using ServiceLayer.Exception.WebApplication;
using ServiceLayer.Messages.WebApplication;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace ServiceLayer.Services.Implementation
{
    public class MiembroService : IMiembroService
    {
        private readonly IGenericRepository<Miembro> _repository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IToastNotification _toasty;
        private readonly ICuentaCorrienteService _cuentaCorrienteService;
        private readonly IPagoService _pagoService;
        private const string Section = "El miembro";


        public MiembroService(IGenericRepository<Miembro> repository, IUnitOfWork unitOfWork, IMapper mapper, IToastNotification toasty, ICuentaCorrienteService cuentaCorrienteService, IPagoService pagoService)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _toasty = toasty;
            _cuentaCorrienteService = cuentaCorrienteService;
            _pagoService = pagoService;
        }


        public async Task<List<VMMiembro>> GetAllListAsync()
        {
            var miembroListaVM = await _unitOfWork.GetGenericRepository<Miembro>()
                .GetAllList()
                .Where(p => p.Activo == true)
                .Include(p => p.Organismo)
                .Include(p => p.Categoria)
                .Include(p => p.Rama)
                .Include(p => p.Funcion)
                .Include(p => p.Sexo)
                .Include(p => p.Pagos)
                .ThenInclude(p => p.ListaDetalles) // Incluye los detalles de pago dentro de cada pago
                .ThenInclude(dp => dp.CategoriaPago)
                .Select(p => new VMMiembro
                {
                    Id = p.Id,
                    Nombre = p.Nombre,
                    Apellido = p.Apellido,
                    Dni = p.Dni,
                    SexoNombre = p.Sexo.Nombre,
                    FechaNacimiento = p.FechaNacimiento,
                    Telefono = p.Telefono,
                    Email = p.Email,
                    Activo = p.Activo,
                    OrganismoNombre = p.Organismo.Nombre,

                    Categoria = new VMCategoria
                    {
                        Id = p.Id,
                        Nombre = p.Categoria.Nombre,
                    },

                    Localidad = new VMLocalidad
                    {
                        Id = p.Id,
                        Nombre = p.Localidad.Nombre
                    },

                    Deuda = new VMDeuda
                    {
                        FechaVencimiento = p.Deuda.FechaVencimiento,
                        FechaCreacion = p.Deuda.FechaCreacion
                    }
                })
                .ToListAsync();

            return miembroListaVM;
        }

        public async Task<List<VMMiembro>> GetAllInactiveListAsync()
        {
            var miembroListaVM = await _unitOfWork.GetGenericRepository<Miembro>()
                .GetAllList()
                .Where(p => p.Activo == false)
                .Include(p => p.Organismo)
                .Include(p => p.Categoria)
                .Include(p => p.Rama)
                .Include(p => p.Funcion)
                .Include(p => p.Sexo)
                .Select(p => new VMMiembro
                {
                    Id = p.Id,
                    Nombre = p.Nombre,
                    Apellido = p.Apellido,
                    Dni = p.Dni,
                    SexoNombre = p.Sexo.Nombre,
                    FechaNacimiento = p.FechaNacimiento,
                    Telefono = p.Telefono,
                    Email = p.Email,
                    Activo = p.Activo,
                    OrganismoNombre = p.Organismo.Nombre,

                      Categoria = new VMCategoria
                      {
                          Id = p.Id,
                          Nombre = p.Categoria.Nombre,
                      },

                    Localidad = new VMLocalidad
                    {
                        Id = p.Id,
                        Nombre = p.Localidad.Nombre
                    }
                })
                .ToListAsync();

            return miembroListaVM;
        }

        public async Task CreateEntityAsync(VMMiembro entity)
        {
            var miembro = _mapper.Map<Miembro>(entity);

            miembro.Activo = true;

            // Obtener las entidades relacionadas
            miembro.Discapacidad = await _unitOfWork.GetGenericRepository<Discapacidad>().GetEntityByIdAsync(entity.MiembroDiscapacidadId.Value);
            miembro.Estudio = await _unitOfWork.GetGenericRepository<Estudio>().GetEntityByIdAsync(entity.EstudioId.Value);
            miembro.Sexo = await _unitOfWork.GetGenericRepository<Sexo>().GetEntityByIdAsync(entity.SexoId.Value);
            miembro.EstadoCivil = await _unitOfWork.GetGenericRepository<EstadoCivil>().GetEntityByIdAsync(entity.EstadoCivilId.Value);
            miembro.Religion = await _unitOfWork.GetGenericRepository<Religion>().GetEntityByIdAsync(entity.ReligionId.Value);
            miembro.Localidad = await _unitOfWork.GetGenericRepository<Localidad>().GetEntityByIdAsync(entity.LocalidadId.Value);

            miembro.Categoria = await _unitOfWork.GetGenericRepository<Categoria>().GetEntityByIdAsync(entity.CategoriaId);

            if (entity.RamaId.HasValue)
            {
                miembro.Rama = await _unitOfWork.GetGenericRepository<Rama>().GetEntityByIdAsync(entity.RamaId.Value);
            }
            if (entity.FuncionId.HasValue)
            {
                var jefeGrupoExiste = await _unitOfWork.GetGenericRepository<Miembro>().Where(x => x.FuncionId == 4).SingleOrDefaultAsync();
                miembro.InsigniaMadera = entity.InsigniaMadera;


                if (jefeGrupoExiste == null)
                {
                    miembro.Funcion = await _unitOfWork.GetGenericRepository<Funcion>().GetEntityByIdAsync(entity.FuncionId.Value);
                }
                else
                {
                    _toasty.AddErrorToastMessage("Ya existe un miembro con la función de 'Jefe de Grupo'.",
                    new ToastrOptions
                    {
                        Title = NotificationMessagesWebApplication.FailedTitle,
                        ProgressBar = true,
                        PositionClass = ToastPositions.BottomCenter
                    });
                     throw new InvalidOperationException("Ya existe un miembro con la función de 'Jefe de Grupo'.");
                }
            }

            // Obtener Organismo
            var organismo = await _unitOfWork.GetGenericRepository<Organismo>().GetEntityByIdAsync(entity.OrganismoId.Value);

            if (organismo != null && organismo.Activo)
            {
                miembro.Organismo = organismo;
            }

            // Crear el Miembro en la BD (esto genera el MiembroId)
            await _unitOfWork.GetGenericRepository<Miembro>().CreateEntityAsync(miembro);
            await _unitOfWork.CommitAsync(); // Guardar cambios para obtener el MiembroId


            //var miembroAcompañante = await _unitOfWork.GetGenericRepository<Miembro>().Where(x => x.CategoriaId == 6).SingleAsync();

            if (miembro.CategoriaId == 6) // Si el miembro es acompañante se le asigna unicamente la deuda de Seguro Acompañante
            {
                var deuda = new Deuda
                {
                    FechaCreacion = DateTime.Now,
                    FechaVencimiento = DateTime.Now,
                    MiembroId = miembro.Id,
                    OrganismoId = organismo?.Id,
                    Organismo = organismo,
                    MontoAfiliacion = 0,
                    MontoSeguroAcompañante = organismo.ValorSeguro,
                    Tiene = (organismo?.ValorAfiliacion > 0 || organismo?.ValorSeguro > 0),
                    DeudaPendiente = true
                };
                await _unitOfWork.GetGenericRepository<Deuda>().CreateEntityAsync(deuda);
                await _unitOfWork.CommitAsync();
                await _cuentaCorrienteService.GestionarSaldosMiembros(deuda.MontoAfiliacion, deuda.MontoSeguroAcompañante);

            }
            else // Si el miembro es Protagonista/Educador se le asigna unicamente la deuda de Afiliacion
            {
                var deuda = new Deuda
                {
                    FechaVencimiento = DateTime.Now,
                    FechaCreacion = DateTime.Now,
                    MiembroId = miembro.Id,
                    OrganismoId = organismo?.Id,
                    Organismo = organismo,
                    MontoAfiliacion = organismo.ValorAfiliacion,
                    MontoSeguroAcompañante = 0,
                    Tiene = (organismo?.ValorAfiliacion > 0 || organismo?.ValorSeguro > 0),
                    DeudaPendiente = true,
                };
                await _unitOfWork.GetGenericRepository<Deuda>().CreateEntityAsync(deuda);
                await _unitOfWork.CommitAsync();
                await _cuentaCorrienteService.GestionarSaldosMiembros(deuda.MontoAfiliacion, deuda.MontoSeguroAcompañante);
            }

            _toasty.AddSuccessToastMessage(NotificationMessagesWebApplication.AddMessage(Section),
                new ToastrOptions { Title = NotificationMessagesWebApplication.SuccessedTitle });
        }


        public async Task DeleteEntityAsync(int id)
        {
            var miembro = await _repository.GetEntityByIdAsync(id);

            if(miembro.Activo == true)
            {
                miembro.Activo = false;
            }
            else
            {
                miembro.Activo = true;
            }
            await _unitOfWork.CommitAsync();
            _toasty.AddErrorToastMessage(NotificationMessagesWebApplication.DeleteMessage(Section), new ToastrOptions { Title = NotificationMessagesWebApplication.SuccessedTitle });
        }


        public async Task UpdateEntityAsync(VMMiembro entity)
        {
            // Buscar el organismo existente en la base de datos
            var existingMiembro = await _repository.GetEntityByIdAsync(entity.Id);

            if (existingMiembro == null)
            {
                throw new ClientSideExceptions("El organismo no existe en la base de datos.");
            }

            _mapper.Map(entity, existingMiembro);

            existingMiembro.Activo = true;

            _repository.Update(existingMiembro);
            var result = await _unitOfWork.CommitAsync();

            if (!result)
            {
                throw new ClientSideExceptions(ExceptionMessages.ConcurencyException);
            }

            _toasty.AddInfoToastMessage(NotificationMessagesWebApplication.UpdateMessage(Section), new ToastrOptions { Title = NotificationMessagesWebApplication.SuccessedTitle });
        }

        public async Task<IEnumerable<VMMiembro>> GetMiembrosDeudas()
        {

            var miembrosConDeudas = await _unitOfWork.GetGenericRepository<Miembro>()
                .GetAllList()
                .Include(m => m.Deuda)
                .Where(m => m.Deuda != null && m.Deuda.DeudaPendiente == true && m.Activo == true)
                .Select(m => new VMMiembro
                {
                    Id = m.Id,
                    Nombre = m.Nombre,
                    Apellido = m.Apellido,
                    MontoAfiliacion = m.Deuda.Organismo.ValorAfiliacion,
                    MontoSeguroAcompañante = m.Deuda.Organismo.ValorSeguro,
                    DeudaFechaVencimiento = m.Deuda.FechaVencimiento,
                    DeudaTiene = m.Deuda.Tiene,                   
                })
                .ToListAsync();

            return miembrosConDeudas;
        }

        public async Task<Miembro?> GetMiembroConDeudaPorDNI(string dni)
        {
            return await _repository.Where(m => m.Dni == dni && m.Deuda != null && m.Deuda.Tiene).Include(m => m.Deuda).FirstOrDefaultAsync();
        }

        public async Task<VMMiembro> ObtenerDetallesMiembro(int miembroId)
        {
                var miembro = await _repository.GetEntityByIdAsync(miembroId);

                if (miembro == null)
                {
                    return null;
                }

                return _mapper.Map<VMMiembro>(miembro);
        }

        public async Task<VMMiembro> GetMiembroById(int id)
        {
            var miembro = await _repository.Where(c => c.Id == id)
                .AsNoTracking()
                .Include(x => x.Localidad)  
                .Include(x => x.Discapacidad)  
                .Include(x => x.Idioma)  
                .Include(x => x.Sexo)                
                .Include(x => x.Religion)  
                .Include(x => x.Nacionalidad)
                .Include(x => x.EstadoCivil)
                .Include(x => x.Categoria)
                .Include(x => x.Funcion)
                .Include(x => x.Rama)
                .Include(x => x.Estudio)
                .Include(x => x.Deuda)
                .ThenInclude(x => x.Organismo)
                .Select(x => new VMMiembro
                {
                    Id = x.Id,
                    Nombre = x.Nombre,
                    Apellido = x.Apellido,
                    Dni = x.Dni,
                    Activo = x.Activo,
                    FechaNacimiento = x.FechaNacimiento,
                    CodigoPostal = x.CodigoPostal,
                    Telefono = x.Telefono,
                    Email = x.Email,
                    Titulo = x.Titulo,
                    DescripcionDiscapacidad = x.DescripcionDiscapacidad,
                    InsigniaMadera = x.InsigniaMadera,

                    Localidad = new VMLocalidad
                    {
                        Id = x.Localidad.Id,  
                        Nombre = x.Localidad.Nombre,  
                        Provincia = new VMProvincia
                        {
                            Id = x.Localidad.Provincia.Id,  
                            Nombre = x.Localidad.Provincia.Nombre  
                        },
                    },
                    Discapacidad = new VMDiscapacidad
                    {
                        Nombre = x.Discapacidad.Nombre
                    },
                    Idioma =  new VMIdioma
                    {
                        Nombre = x.Idioma.Nombre
                    },
                    Sexo =  new VMSexo
                    {
                        Nombre = x.Sexo.Nombre
                    },
                    Religion = new VMReligion
                    {
                        Nombre = x.Religion.Nombre
                    },
                    Nacionalidad = new VMNacionalidad
                    {
                        Pais = x.Nacionalidad.Pais
                    },
                    Rama = new VMRama
                    {
                        Nombre = x.Rama.Nombre
                    },
                    Categoria = new VMCategoria
                    {
                        Id = x.Id,
                        Nombre = x.Categoria.Nombre,
                    },
                    Funcion = new VMFuncion
                    {
                        Id = x.Id,
                        Nombre = x.Funcion.Nombre,
                    },
                    Organismo = new VMOrganismo
                    {
                        Nombre = x.Organismo.Nombre,
                        ValorSeguro = x.Organismo.ValorSeguro,
                        ValorAfiliacion = x.Organismo.ValorAfiliacion,
                        Id = x.Id
                    },
                    EstadoCivil = new VMEstadoCivil
                    {
                        Nombre = x.EstadoCivil.Nombre
                    },
                    Deuda = new VMDeuda
                    {
                        Tiene = x.Deuda.Tiene,
                        FechaVencimiento = x.Deuda.FechaVencimiento,
                        FechaCreacion = x.Deuda.FechaCreacion,
                        MiembroId = x.Id,
                        OrganismoId = x.OrganismoId,  
                        Organismo = x.Organismo,
                        MontoAfiliacion = x.Deuda.MontoAfiliacion,
                        MontoSeguroAcompañante = x.Deuda.MontoSeguroAcompañante
                    },
                    Estudio = x.Estudio != null ? new VMMiembroEstudio
                    {
                        Nivel = x.Estudio.Nivel,
                    } : null,

                })
                .SingleAsync();


            return miembro;
        }

        public async Task<Dictionary<string, int>> GetMiembrosPorRama()
        {
            var miembros = await _unitOfWork.GetGenericRepository<Miembro>()
                .GetAllList()
                .Include(m => m.Rama)
                .Where(m => m.Categoria.Nombre == "Protagonista" &&
                           (m.Rama.Nombre == "Rover" ||
                            m.Rama.Nombre == "Caminante" ||
                            m.Rama.Nombre == "Manada" ||
                            m.Rama.Nombre == "Scout"))
                .GroupBy(m => m.Rama.Nombre)
                .Select(g => new { Rama = g.Key, Cantidad = g.Count() })
                .ToListAsync();

            return miembros.ToDictionary(m => m.Rama, m => m.Cantidad);
        }

        public async Task<Dictionary<string, int>> GetMiembrosPorCategoria()
        {
            var miembros = await _unitOfWork.GetGenericRepository<Miembro>()
                .GetAllList()
                .Include(m => m.Rama)
                .Where(m => m.Categoria.Nombre == "Protagonista" &&
                           (m.Rama.Nombre == "Rover" ||
                            m.Rama.Nombre == "Caminante" ||
                            m.Rama.Nombre == "Manada" ||
                            m.Rama.Nombre == "Scout"))
                .GroupBy(m => m.Rama.Nombre)
                .Select(g => new { Rama = g.Key, Cantidad = g.Count() })
                .ToListAsync();

            return miembros.ToDictionary(m => m.Rama, m => m.Cantidad);
        }

        //public async Task<Dictionary<string, int>> GetCategoriaMiembroAsync()
        //{
        //    var categoriasCount = new Dictionary<string, int>
        //    {
        //        { "Protagonista", 0 },
        //        { "Educador", 0 },
        //        { "Acompañante", 0 }
        //    };

        //    // Obtener todos los miembros desde la base de datos, incluyendo la categoría asociada a cada miembro
        //    var miembros = await _unitOfWork.GetGenericRepository<Miembro>().GetAllList().Include(x => x.Categoria).ToListAsync();

        //    // Contar cuántos miembros pertenecen a cada categoría
        //    foreach (var miembro in miembros)
        //    {
        //        if (miembro.Categoria != null && categoriasCount.ContainsKey(miembro.Categoria.Nombre))
        //        {
        //            categoriasCount[miembro.Categoria.Nombre]++;
        //        }
        //    }

        //    return categoriasCount;
        //}

    }
}
