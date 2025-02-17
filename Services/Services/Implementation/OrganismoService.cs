using AutoMapper;
using AutoMapper.QueryableExtensions;
using Azure.Core;
using CoreLayer.Enumerators;
using DAL.Context;
using DAL.Repositories.Interfaces;
using DAL.UnitOfWork.Interfaces;
using Entity.WebAplication.Entities;
using Entity.WebAplication.ViewModels;
using Microsoft.EntityFrameworkCore;
using NToastNotify;
using ServiceLayer.Exception.WebApplication;
using ServiceLayer.Messages.WebApplication;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Implementation
{
    public class OrganismoService : IOrganismoService
    {
        private readonly IGenericRepository<Organismo> _repository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IToastNotification _toasty;
        private const string Section = "El organismo";


        public OrganismoService(IGenericRepository<Organismo> repository, IUnitOfWork unitOfWork, IMapper mapper, IToastNotification toasty)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _toasty = toasty;
        }

        public async Task<List<VMOrganismo>> GetAllListAsync()
        {

            var organismoListaVM = await _unitOfWork.GetGenericRepository<Organismo>()
             .GetAllList()
             .Include(o => o.Deudas)
             .Include(o => o.Localidad)
             .ThenInclude(l => l.Provincia)
             .Select(o => new VMOrganismo
             {
                 Id = o.Id,
                 Nombre = o.Nombre,
                 Activo = o.Activo,
                 Codigo = o.Codigo,
                 FechaCreacion = o.FechaCreacion,
                 Descripcion = o.Descripcion,
                 Direccion = o.Direccion,
                 CodigoPostal = o.CodigoPostal,

                 Deudas = o.Deudas.Select(o => new VMDeuda
                 {
                     Id = o.Id,
                     FechaVencimiento = o.FechaVencimiento,
                     Tiene = o.Tiene

                 }).ToList(),
                 Localidad = o.Localidad != null ? new VMLocalidad
                 {
                     Id = o.Localidad.Id,
                     Nombre = o.Localidad.Nombre,
                     Provincia = o.Localidad.Provincia != null ? new VMProvincia
                     {
                         Id = o.Localidad.Provincia.Id,
                         Nombre = o.Localidad.Provincia.Nombre
                     } : null
                 } : null
             })
             .ToListAsync();


            return organismoListaVM;
        }

        public async Task CreateEntityAsync(VMOrganismo entity)
        {
            var organismo = _mapper.Map<Organismo>(entity);

            var resumen = new Resumen
            {
              
            };


            var ultimoOrganismo = await _unitOfWork.GetGenericRepository<Organismo>().GetAllList().OrderByDescending(o => o.Codigo).FirstOrDefaultAsync();

            int nuevoCodigo = (ultimoOrganismo != null) ? ultimoOrganismo.Codigo + 1 : 1;

            organismo.Activo = true;
            organismo.Codigo = nuevoCodigo;

            // Guardar el Organismo (y su Resumen debido a la relación)
            await _unitOfWork.GetGenericRepository<Organismo>().CreateEntityAsync(organismo);
            await _unitOfWork.CommitAsync();
            _toasty.AddSuccessToastMessage(NotificationMessagesWebApplication.AddMessage(Section), new ToastrOptions { Title = NotificationMessagesWebApplication.SuccessedTitle });
        }


        public async Task DeleteEntityAsync(int id)
        {
            var organismo = await _repository.GetEntityByIdAsync(id);
            organismo.Activo = false;
            var result = await _unitOfWork.CommitAsync();

            if (!result)
            {
                throw new ClientSideExceptions(ExceptionMessages.ConcurencyException);
            }

            _toasty.AddWarningToastMessage(NotificationMessagesWebApplication.DeleteMessage(Section), new ToastrOptions { Title = NotificationMessagesWebApplication.SuccessedTitle });

        }

        public async Task UpdateEntityAsync(VMOrganismo entity)
        {
            // Buscar el organismo existente en la base de datos
            var existingOrganismo = await _repository.GetEntityByIdAsync(entity.Id);
            if (existingOrganismo == null)
            {
                throw new ClientSideExceptions("El organismo no existe en la base de datos.");
            } 

            _mapper.Map(entity, existingOrganismo);

            _repository.Update(existingOrganismo);
            var result = await _unitOfWork.CommitAsync();

            if (!result)
            {
                throw new ClientSideExceptions(ExceptionMessages.ConcurencyException);
            }

            _toasty.AddInfoToastMessage(NotificationMessagesWebApplication.UpdateMessage(Section), new ToastrOptions { Title = NotificationMessagesWebApplication.SuccessedTitle });
        }


        public async Task<VMOrganismo> GetOrganmismoById(int id)
        {
            var organismo = await _repository
                .Where(c => c.Id == id)
                .AsNoTracking()
                .Include(c => c.Miembros)
                .Include(c => c.Deudas)
                .Include(o => o.Localidad)
                .ThenInclude(l => l.Provincia)
                .Select(x => new VMOrganismo()
                {
                    Id = x.Id,
                    FechaCreacion = x.FechaCreacion,
                    Activo = x.Activo,
                    Codigo = x.Codigo, 
                    Descripcion = x.Descripcion,
                    Direccion = x.Direccion,
                    Nombre = x.Nombre,
                    CodigoPostal = x.CodigoPostal,
                    Celular = x.Celular,
                    Email = x.Email,
                    Latitud = x.Latitud,
                    Longitud = x.Longitud,
                    Telefono = x.Telefono,
                    ValorAfiliacion = x.ValorAfiliacion,
                    ValorSeguro = x.ValorSeguro,    

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

                    //Resumen = new VMResumen
                    //{
                    //    Saldo = x.Resumen.Saldo,
                    //},

                    Deudas = x.Deudas.Select(o => new VMDeuda
                    {
                        Id = o.Id,
                        FechaVencimiento = o.FechaVencimiento,
                        Tiene = o.Tiene

                    }).ToList(),

                    Miembros = x.Miembros.Select(dp => new VMMiembro
                    {
                        Id = dp.Id,
                        Nombre = dp.Nombre,
                        Apellido = dp.Apellido,
                        Dni = dp.Dni,
                        FechaNacimiento = dp.FechaNacimiento,
                        Email = dp.Email,
                        Activo = dp.Activo,
                        CodigoPostal = dp.CodigoPostal,
                        Telefono = dp.Telefono,
                        

                        Sexo = new VMSexo
                        {
                            Id = dp.SexoId,
                            Nombre = dp.Sexo.Nombre,
                        },

                        EstadoCivil = new VMEstadoCivil
                        {
                            Id = dp.EstadoCivilId,
                            Nombre = dp.EstadoCivil.Nombre,
                        },

                        Localidad = new VMLocalidad
                        {
                            Id = dp.Localidad.Id,
                            Nombre = dp.Localidad.Nombre,
                            Provincia = new VMProvincia
                            {
                                Id = dp.Localidad.Provincia.Id,
                                Nombre = dp.Localidad.Provincia.Nombre
                            },
                        },

                        Discapacidad = new VMDiscapacidad
                        {
                            Id = dp.DiscapacidadId ?? 0, // Aquí 0 es el valor predeterminado si dp.DiscapacidadId es nulo
                            Nombre = dp.Discapacidad.Nombre,
                        },





                    }).ToList()
                })
                .SingleAsync();
             return organismo;
        }





        public async Task<List<VMProvincia>> GetProvinciasAsync()
        {
            // Obtiene la lista de provincias desde el repositorio usando UnitOfWork
            var provinciasVM = await _unitOfWork.GetGenericRepository<Provincia>().GetAllList().ProjectTo<VMProvincia>(_mapper.ConfigurationProvider).ToListAsync();
            return provinciasVM;
        }

        public async Task<IEnumerable<VMNacionalidad>> GetNacionalidadesAsync()
        {
            // Lógica para obtener la lista de países desde la base de datos
            var miembroNacionalidadVM = await _unitOfWork.GetGenericRepository<Nacionalidad>().GetAllList().ProjectTo<VMNacionalidad>(_mapper.ConfigurationProvider).ToListAsync();
            return miembroNacionalidadVM;
        }

        public async Task<IEnumerable<VMDiscapacidad>> GetDiscapacidadesAsync()
        {
            // Lógica para obtener la lista de países desde la base de datos
            var discapacidadesVM = await _unitOfWork.GetGenericRepository<Discapacidad>().GetAllList().ProjectTo<VMDiscapacidad>(_mapper.ConfigurationProvider).ToListAsync();
            return discapacidadesVM;
        }

        public async Task<IEnumerable<VMEstadoCivil>> GetEstadosCivilesAsync()
        {
            // Lógica para obtener la lista de países desde la base de datos
            var estadosCivilesVM = await _unitOfWork.GetGenericRepository<EstadoCivil>().GetAllList().ProjectTo<VMEstadoCivil>(_mapper.ConfigurationProvider).ToListAsync();
            return estadosCivilesVM;
        }

        public async Task<IEnumerable<VMMiembroEstudio>> GetEstudiosAsync()
        {
            // Lógica para obtener la lista de países desde la base de datos
            var estudiosVM = await _unitOfWork.GetGenericRepository<Estudio>().GetAllList().ProjectTo<VMMiembroEstudio>(_mapper.ConfigurationProvider).ToListAsync();
            return estudiosVM;
        }

        public async Task<IEnumerable<VMReligion>> GetReligionesAsync()
        {
            // Lógica para obtener la lista de países desde la base de datos
            var religionesVM = await _unitOfWork.GetGenericRepository<Religion>().GetAllList().ProjectTo<VMReligion>(_mapper.ConfigurationProvider).ToListAsync();
            return religionesVM;
        }
        public async Task<IEnumerable<VMSexo>> GetSexosAsync()
        {
            // Lógica para obtener la lista de países desde la base de datos
            var sexosVM = await _unitOfWork.GetGenericRepository<Sexo>().GetAllList().ProjectTo<VMSexo>(_mapper.ConfigurationProvider).ToListAsync();
            return sexosVM;
        }
        public async Task<IEnumerable<VMIdioma>> GetIdiomasAsync()
        {
            // Lógica para obtener la lista de países desde la base de datos
            var idiomasVM = await _unitOfWork.GetGenericRepository<Idioma>().GetAllList().ProjectTo<VMIdioma>(_mapper.ConfigurationProvider).ToListAsync();
            return idiomasVM;
        }

        public async Task<IEnumerable<VMRama>> GetRamas()
        {
            var ramasVM = await _unitOfWork.GetGenericRepository<Rama>().GetAllList().ProjectTo<VMRama>(_mapper.ConfigurationProvider).ToListAsync();
            return ramasVM;
        }

        public async Task<IEnumerable<VMCategoria>> GetCategorias()
        {
            var categoriasVM = await _unitOfWork.GetGenericRepository<Categoria>().GetAllList().ProjectTo<VMCategoria>(_mapper.ConfigurationProvider).ToListAsync();
            return categoriasVM;
        }

        public async Task<IEnumerable<VMFuncion>> GetFunciones()
        {
            var funcionesVM = await _unitOfWork.GetGenericRepository<Funcion>().GetAllList().ProjectTo<VMFuncion>(_mapper.ConfigurationProvider).ToListAsync();
            return funcionesVM;
        }

        public async Task<(decimal afiliacion, decimal seguro)> GetPreciosAfiliacionesAsync()
        {
            var organismo = await _unitOfWork.GetGenericRepository<Organismo>().GetAllList().SingleOrDefaultAsync();

            return (organismo.ValorAfiliacion, organismo.ValorSeguro);
        }

        public async Task<List<VMLocalidad>> GetLocalidadesByProvinciaAsync(int provinciaId)
        {
            var localidades = await _unitOfWork.GetGenericRepository<Localidad>().Where(l => l.ProvinciaId == provinciaId).ToListAsync();

            return localidades.Select(l => new VMLocalidad
            {
                Id = l.Id,
                Nombre = l.Nombre,
                ProvinciaId = l.ProvinciaId
            }).ToList();
        }
    }
}
