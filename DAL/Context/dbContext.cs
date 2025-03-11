using Entity.Identity.Entities;
using Entity.WebAplication.Entities;
using Entity.WebAplication.ViewModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Entity.Identity.Entities.BaseEntities;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Text;
using System.Linq;

namespace DAL.Context
{
    public class dbContext : IdentityDbContext<AppUser, AppRole, string>
    {
        private readonly IHttpContextAccessor _contextAccessor;

        public dbContext(DbContextOptions options, IHttpContextAccessor contextAccessor) : base(options)
        {
            _contextAccessor = contextAccessor;
        }

        protected dbContext()
        {
        }

        public DbSet<DetallePago> DetallesPagos { get; set; }
        public DbSet<Miembro> Miembros { get; set; }
        public DbSet<Nacionalidad> Nacionalidades { get; set; }
        public DbSet<Religion> Religiones { get; set; }
        public DbSet<Sexo> Sexos { get; set; }
        public DbSet<Deposito> Depositos { get; set; }
        public DbSet<Efectivo> Efectivo { get; set; }
        public DbSet<Transferencia> Transferencias { get; set; }
        public DbSet<Pago> Pagos { get; set; }
        public DbSet<Organismo> Organismos { get; set; }
        public DbSet<AutorizacionPago> AutorizacionesPagos { get; set; }  
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Funcion> Funciones { get; set; }
        public DbSet<Provincia> Provincias { get; set; }
        public DbSet<Localidad> Localidades { get; set; }
        public DbSet<Idioma> Idiomas { get; set; }
        public DbSet<Discapacidad> Discapacidades { get; set; }
        public DbSet<Deuda> Deudas { get; set; }
        public DbSet<ModalidadPago> ModalidadPagos { get; set; }
        public DbSet<Educador> Educadores { get; set; }
        public DbSet<EstadoAutorizacion> EstadoAutorizaciones { get; set; }
        public DbSet<AuditLog> AuditsLogs { get; set; }
        public DbSet<AuditLogAuthentication> AuditLogsAuthentications { get; set; } // Nueva tabla de auditoría


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<AutorizacionPago>().Property(x => x.CreatedDate).IsRequired().HasMaxLength(10);
            modelBuilder.Entity<AutorizacionPago>().Property(x => x.UpdatedDate).HasMaxLength(10);


            modelBuilder.Entity<Categoria>().Property(x => x.CreatedDate).IsRequired().HasMaxLength(10);
            modelBuilder.Entity<Categoria>().Property(x => x.UpdatedDate).HasMaxLength(10);

            modelBuilder.Entity<CategoriaPago>().Property(x => x.CreatedDate).IsRequired().HasMaxLength(10);
            modelBuilder.Entity<CategoriaPago>().Property(x => x.UpdatedDate).HasMaxLength(10);

            modelBuilder.Entity<Deposito>().Property(x => x.CreatedDate).IsRequired().HasMaxLength(10);
            modelBuilder.Entity<Deposito>().Property(x => x.UpdatedDate).HasMaxLength(10);

            modelBuilder.Entity<DetallePago>().Property(x => x.CreatedDate).IsRequired().HasMaxLength(10);
            modelBuilder.Entity<DetallePago>().Property(x => x.UpdatedDate).HasMaxLength(10);

            modelBuilder.Entity<Deuda>().Property(x => x.CreatedDate).IsRequired().HasMaxLength(10);
            modelBuilder.Entity<Deuda>().Property(x => x.UpdatedDate).HasMaxLength(10);

            modelBuilder.Entity<Discapacidad>().Property(x => x.CreatedDate).IsRequired().HasMaxLength(10);
            modelBuilder.Entity<Discapacidad>().Property(x => x.UpdatedDate).HasMaxLength(10);

            modelBuilder.Entity<Educador>().Property(x => x.CreatedDate).IsRequired().HasMaxLength(10);
            modelBuilder.Entity<Educador>().Property(x => x.UpdatedDate).HasMaxLength(10);

            modelBuilder.Entity<Efectivo>().Property(x => x.CreatedDate).IsRequired().HasMaxLength(10);
            modelBuilder.Entity<Efectivo>().Property(x => x.UpdatedDate).HasMaxLength(10);

            modelBuilder.Entity<Estudio>().Property(x => x.CreatedDate).IsRequired().HasMaxLength(10);
            modelBuilder.Entity<Estudio>().Property(x => x.UpdatedDate).HasMaxLength(10);

            modelBuilder.Entity<Funcion>().Property(x => x.CreatedDate).IsRequired().HasMaxLength(10);
            modelBuilder.Entity<Funcion>().Property(x => x.UpdatedDate).HasMaxLength(10);

            modelBuilder.Entity<Idioma>().Property(x => x.CreatedDate).IsRequired().HasMaxLength(10);
            modelBuilder.Entity<Idioma>().Property(x => x.UpdatedDate).HasMaxLength(10);

            modelBuilder.Entity<Localidad>().Property(x => x.CreatedDate).IsRequired().HasMaxLength(10);
            modelBuilder.Entity<Localidad>().Property(x => x.UpdatedDate).HasMaxLength(10);

            modelBuilder.Entity<Miembro>(entity =>
            {
                entity.Property(x => x.CreatedDate)
                    .IsRequired()
                    .HasMaxLength(10);
              

                entity.Property(x => x.UpdatedDate)
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<ModalidadPago>().Property(x => x.CreatedDate).IsRequired().HasMaxLength(10);
            modelBuilder.Entity<ModalidadPago>().Property(x => x.UpdatedDate).HasMaxLength(10);

            modelBuilder.Entity<Nacionalidad>().Property(x => x.CreatedDate).IsRequired().HasMaxLength(10);
            modelBuilder.Entity<Nacionalidad>().Property(x => x.UpdatedDate).HasMaxLength(10);

            modelBuilder.Entity<Organismo>().Property(x => x.CreatedDate).IsRequired().HasMaxLength(10);
            modelBuilder.Entity<Organismo>().Property(x => x.UpdatedDate).HasMaxLength(10);

            modelBuilder.Entity<Provincia>().Property(x => x.CreatedDate).IsRequired().HasMaxLength(10);
            modelBuilder.Entity<Provincia>().Property(x => x.UpdatedDate).HasMaxLength(10);

            modelBuilder.Entity<Rama>().Property(x => x.CreatedDate).IsRequired().HasMaxLength(10);
            modelBuilder.Entity<Rama>().Property(x => x.UpdatedDate).HasMaxLength(10);

            modelBuilder.Entity<Religion>().Property(x => x.CreatedDate).IsRequired().HasMaxLength(10);
            modelBuilder.Entity<Religion>().Property(x => x.UpdatedDate).HasMaxLength(10);

            modelBuilder.Entity<Resumen>().Property(x => x.CreatedDate).IsRequired().HasMaxLength(10);
            modelBuilder.Entity<Resumen>().Property(x => x.UpdatedDate).HasMaxLength(10);

            modelBuilder.Entity<Sexo>().Property(x => x.CreatedDate).IsRequired().HasMaxLength(10);
            modelBuilder.Entity<Sexo>().Property(x => x.UpdatedDate).HasMaxLength(10);

            modelBuilder.Entity<Transferencia>().Property(x => x.CreatedDate).IsRequired().HasMaxLength(10);
            modelBuilder.Entity<Transferencia>().Property(x => x.UpdatedDate).HasMaxLength(10);

            modelBuilder.Entity<Pago>().Property(x => x.CreatedDate).IsRequired().HasMaxLength(10);
            modelBuilder.Entity<Pago>().Property(x => x.UpdatedDate).HasMaxLength(10);

            modelBuilder.Entity<EstadoCivil>().Property(x => x.CreatedDate).IsRequired().HasMaxLength(10);
            modelBuilder.Entity<EstadoCivil>().Property(x => x.UpdatedDate).HasMaxLength(10);

            modelBuilder.Entity<EstadoAutorizacion>().Property(x => x.CreatedDate).IsRequired().HasMaxLength(10);
            modelBuilder.Entity<EstadoAutorizacion>().Property(x => x.UpdatedDate).HasMaxLength(10);

            //modelBuilder.Entity<Miembro>()
            //.HasOne(m => m.Organismo)
            //.WithMany(o => o.Miembros)
            //.HasForeignKey(m => m.OrganismoId)
            //.OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Pago>()
           .HasOne(p => p.Miembro)
           .WithMany(m => m.Pagos)
           .HasForeignKey(p => p.MiembroId)
           .OnDelete(DeleteBehavior.Restrict); // Evita cascada


            modelBuilder.Entity<ModalidadPago>()
                .ToTable("PagoModalidad");

            modelBuilder.Entity<Deposito>()
                .ToTable("ModalidadDeposito")
                .HasBaseType<ModalidadPago>();


            modelBuilder.Entity<Transferencia>()
                .ToTable("ModalidadTransferencia")
                .HasBaseType<ModalidadPago>();

            modelBuilder.Entity<Efectivo>()
                .ToTable("ModalidadEfectivo")
                .HasBaseType<ModalidadPago>();


            modelBuilder.Entity<Pago>()
            .HasOne(p => p.Autorizacion)
            .WithMany(a => a.Pagos)
            .HasForeignKey(p => p.AutorizacionPagoId);


            modelBuilder.Entity<Miembro>()
            .HasOne(m => m.Organismo)
            .WithMany(o => o.Miembros)
            .HasForeignKey(m => m.OrganismoId)
            .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Deuda>()
                   .HasOne(d => d.Miembro)
                   .WithOne(m => m.Deuda)
                   .HasForeignKey<Deuda>(d => d.MiembroId)
                   .OnDelete(DeleteBehavior.Cascade); // Si se elimina un Miembro, se elimina su Deuda

            // Relación 1:N entre Organismo y Deuda (un Organismo puede tener muchas Deudas)
            modelBuilder.Entity<Deuda>()
                .HasOne(d => d.Organismo)
                .WithMany(o => o.Deudas) // Aquí aseguramos la relación 1:N
                .HasForeignKey(d => d.OrganismoId)
                .OnDelete(DeleteBehavior.Restrict); // No pe




            modelBuilder.Entity<Idioma>().HasData(
                new Idioma
                {
                    Id = 1,
                    CreatedDate = "05/05/2025",
                    Nombre = "Español"
                });

            modelBuilder.Entity<Deuda>().HasData(
            new Deuda
            {
                Id = 1,
                CreatedDate = "05/05/2025",
                Tiene = true,
                FechaVencimiento = DateTime.Now,
                MiembroId = 1,
                OrganismoId = 1,
                MontoAfiliacion = 1000,
                MontoSeguroAcompañante = 2000,
                FechaCreacion = DateTime.Now,
                DeudaPendiente = true,
                SaldoDebitado = false,
            });

            modelBuilder.Entity<Funcion>().HasData(
            new Funcion
            {
                Id = 1,
                CreatedDate = "05/05/2025",
                Nombre = "Protagonista"
            });

            modelBuilder.Entity<Categoria>().HasData(
            new Categoria
            {
                Id = 1,
                CreatedDate = "05/05/2025",
                Nombre = "Protagonista",
            });

            modelBuilder.Entity<Miembro>().HasData(
            new Miembro
            {
                Id = 1,
                CreatedDate = "05/05/2025",
                Activo = true,
                Apellido = "Martinez",
                CodigoPostal = 2705,
                Dni = "45621359",
                FechaNacimiento = DateTime.Now,
                Email = "marianotarditi2004@gmail.com",
                LocalidadId = 1,
                IdiomaId = 1,
                Nombre = "Lautaro",
                NacionalidadId = 1,
                SexoId = 1,
                DiscapacidadId = 1,
                ReligionId = 1,
                EstadoCivilId = 1,
                OrganismoId = 1,
                EstudioId = 1,
                RamaId = 1,
                CategoriaId = 1,
                FuncionId = 1,
                InsigniaMadera = true
            });



            modelBuilder.Entity<EstadoAutorizacion>().HasData(
            new EstadoAutorizacion { Id = 1, Estado = "Autorizado", CreatedDate = "05/05/2025" },
            new EstadoAutorizacion { Id = 2, Estado = "Pendiente", CreatedDate = "05/05/2025" });
            new EstadoAutorizacion { Id = 3, Estado = "Rechazado", CreatedDate = "05/05/2025" };


            modelBuilder.Entity<AutorizacionPago>().HasData(
            new AutorizacionPago
            {
                Id = 1122,
                CreatedDate = "05/05/2025",
                Autorizado = true,
                Fecha = DateTime.Now,
                Observacion = "Pago Autorizado con exito",
                EstadoAutorizacionId = 1
            });

            modelBuilder.Entity<Pago>().HasData(
            new Pago
            {
                Id = 1,
                CreatedDate = "05/05/2025",
                Codigo = 1,
                ResumenId = 1,
                Total = 10000,
                TipoModalidad = "Efectivo",
                MiembroId = 1,
                Activo = true,
                AutorizacionPagoId = 1122,
            });

            modelBuilder.Entity<Rama>().HasData(
            new Rama
            {
                Id = 1,
                CreatedDate = "05/05/2025",
                Nombre = "sad"
            });

            modelBuilder.Entity<Discapacidad>().HasData(
            new Discapacidad
            {
                Id = 1,
                CreatedDate = "05/05/2025",
                Nombre = "Diselxia",
            });

            modelBuilder.Entity<Sexo>().HasData(
            new Sexo
            {
                Id = 1,
                CreatedDate = "05/05/2025",
                Nombre = "Masculino"
            });


            modelBuilder.Entity<Estudio>().HasData(
            new Estudio
            {
                Id = 1,
                CreatedDate = "05/05/2025",
                Nivel = "asd",
            });

            modelBuilder.Entity<EstadoCivil>().HasData(
            new EstadoCivil { Id = 1, Nombre = "Masculino", CreatedDate = "05/05/2025" },
            new EstadoCivil { Id = 2, Nombre = "Femenino", CreatedDate = "05/05/2025" },
            new EstadoCivil { Id = 3, Nombre = "X", CreatedDate = "05/05/2025" });



            modelBuilder.Entity<Nacionalidad>().HasData(
            new Nacionalidad
            {
                Id = 1,
                CreatedDate = "05/05/2025",
                Pais = "Argentina"
            });

            modelBuilder.Entity<Religion>().HasData(
            new Religion
            {
                Id = 1,
                CreatedDate = "05/05/2025",
                Nombre = "Cristiano"
            });

            modelBuilder.Entity<ModalidadPago>().HasData(
            new ModalidadPago
            {
                Id = 1,
                CreatedDate = "05/05/2025",
                FechaDePago = DateTime.Now,
                Observacion = "Pago hecho con transferencia",
                NombreCompleto = "Mariano Tarditi",
                PagoId = 1,
            });

            modelBuilder.Entity<DetallePago>().HasData(
            new DetallePago
            {
                Id = 1,
                CreatedDate = "05/05/2025",
                Pagoid = 1,
                Monto = 1000,
                CategoriaPagoId = 1,
                DeudaOriginalAfiliacion = 200,
                DeudaOriginalSeguro = 100
            });


            modelBuilder.Entity<Resumen>().HasData(
            new Resumen
            {
                Id = 1,
                CreatedDate = "05/05/2025",
                Credito = 1000,
                Debito = 500,
                SaldoTotal = 100,
                OrganismoId = 1,
                SaldoAfiliacion = 100,
                SaldoSeguroAcompañante = 100,
                DebitoAfiliacion = 100,
                DebitoSeguroAcompañante = 100,
                CreditoAfiliacion = 100,
                CreditoSeguroAcompañante = 100
            });

            modelBuilder.Entity<Organismo>().HasData(
            new Organismo
            {
                Id = 1,
                CreatedDate = "05/05/2025",
                Codigo = 1,
                FechaCreacion = DateTime.Now,
                Descripcion = "Grupo Scout de Entre Rios",
                Nombre = "San isidrio labrador",
                Direccion = "Dardo rocha 78",
                CodigoPostal = 2705,
                LocalidadId = 1,
                Activo = true,
                Longitud = "-59.008276462555",
                Latitud = "-33.03604633935",
                Telefono = 24564534,
                Celular = 24643456,
                Email = "sggs@gmail.com",
                ValorSeguro = 2000,
                ValorAfiliacion = 3000
            });

            modelBuilder.Entity<Provincia>().HasData(
                 new Provincia { Id = 1, Nombre = "Buenos Aires", CreatedDate = "05/05/2025" },
                 new Provincia { Id = 2, Nombre = "Buenos Aires-GBA", CreatedDate = "05/05/2025" },
                 new Provincia { Id = 3, Nombre = "Catamarca", CreatedDate = "05/05/2025" },
                 new Provincia { Id = 4, Nombre = "Chaco", CreatedDate = "05/05/2025" },
                 new Provincia { Id = 5, Nombre = "Chubut", CreatedDate = "05/05/2025" },
                 new Provincia { Id = 6, Nombre = "Córdoba", CreatedDate = "05/05/2025" },
                 new Provincia { Id = 7, Nombre = "Corrientes", CreatedDate = "05/05/2025" },
                 new Provincia { Id = 8, Nombre = "Entre Ríos", CreatedDate = "05/05/2025" },
                 new Provincia { Id = 9, Nombre = "Formosa", CreatedDate = "05/05/2025" },
                 new Provincia { Id = 10, Nombre = "Jujuy", CreatedDate = "05/05/2025" },
                 new Provincia { Id = 11, Nombre = "La Pampa", CreatedDate = "05/05/2025" },
                 new Provincia { Id = 12, Nombre = "La Rioja" , CreatedDate = "05/05/2025" },
                 new Provincia { Id = 13, Nombre = "Mendoza" , CreatedDate = "05/05/2025" },
                 new Provincia { Id = 14, Nombre = "Misiones", CreatedDate = "05/05/2025" },
                 new Provincia { Id = 15, Nombre = "Neuquén" , CreatedDate = "05/05/2025" },
                 new Provincia { Id = 16, Nombre = "Río Negro" , CreatedDate = "05/05/2025" },
                 new Provincia { Id = 17, Nombre = "Salta", CreatedDate = "05/05/2025" },
                 new Provincia { Id = 18, Nombre = "San Juan" , CreatedDate = "05/05/2025" },
                 new Provincia { Id = 19, Nombre = "San Luis", CreatedDate = "05/05/2025" },
                 new Provincia { Id = 20, Nombre = "Santa Cruz" , CreatedDate = "05/05/2025" },
                 new Provincia { Id = 21, Nombre = "Santa Fe", CreatedDate = "05/05/2025" },
                 new Provincia { Id = 22, Nombre = "Santiago del Estero" , CreatedDate = "05/05/2025" },
                 new Provincia { Id = 23, Nombre = "Tierra del Fuego", CreatedDate = "05/05/2025" },
                 new Provincia { Id = 24, Nombre = "Tucumán", CreatedDate = "05/05/2025" }
            );

            modelBuilder.Entity<Localidad>().HasData(
            new Localidad
            {
                Id = 1,
                CreatedDate = "05/05/2025",
                Nombre = "Rojas",
                ProvinciaId = 1,
                Codigo = 1
            });

    



            modelBuilder.Entity<CategoriaPago>().HasData(
            new CategoriaPago
            {
                Id = 1,
                CreatedDate = "05/05/2025",
                CategoriaNombre = "asd",
            });
        }

        //public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        //{
        //    var modifiedEntities = ChangeTracker.Entries<Miembro>()
        //        .Where(e => e.State == EntityState.Added
        //                 || e.State == EntityState.Modified
        //                 || e.State == EntityState.Deleted)
        //        .ToList();

        //    foreach (var modifiedEntity in modifiedEntities)
        //    {
        //        var auditLog = new AuidtLog
        //        {
        //            EntityName = modifiedEntity.Entity.GetType().Name,
        //            UserName = _contextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.Name),
        //            UserEmail = _contextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.Email),
        //            Timestamp = DateTime.Now,
        //            Action = "",
        //            Changes = GetChanges(modifiedEntity)
        //        };

        //        if (modifiedEntity.State == EntityState.Added)
        //        {
        //            auditLog.Action = "Created";
        //            AuditsLogs.Add(auditLog);

        //            // Registrar cambios en entidades asociadas como Deuda
        //            var deudaEntity = ChangeTracker.Entries<Deuda>().FirstOrDefault(e => e.Entity is Deuda && e.State == EntityState.Added);
        //            // Auditoría de Deuda
        //            if (modifiedEntity.Entity is Miembro miembro && miembro.Deuda != null)
        //            {
        //                var deudaAuditLog = new AuidtLog
        //                {
        //                    EntityName = "Deuda",
        //                    UserName = _contextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.Name),
        //                    UserEmail = _contextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.Email),
        //                    Timestamp = DateTime.Now,
        //                    Action = "Added",
        //                    Changes = GetChanges(deudaEntity) // Asegúrate de que deudaEntity no sea null
        //                };
        //                AuditsLogs.Add(deudaAuditLog);
        //            }

        //            // Auditoría de Resumen
        //            if (modifiedEntity.Entity is Miembro miembroResumen && miembroResumen.Organismo?.Resumen != null)
        //            {
        //                // Obtener el EntityEntry de la entidad Resumen
        //                var resumenEntry = ChangeTracker.Entries<Resumen>()
        //                    .FirstOrDefault(e => e.Entity == miembroResumen.Organismo.Resumen);

        //                if (resumenEntry != null)
        //                {
        //                    var resumenAuditLog = new AuidtLog
        //                    {
        //                        EntityName = "Resumen",
        //                        UserName = _contextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.Name),
        //                        UserEmail = _contextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.Email),
        //                        Timestamp = DateTime.Now,
        //                        Action = "Modified",
        //                        Changes = GetChanges(resumenEntry) // Pasamos el EntityEntry de Resumen
        //                    };
        //                    AuditsLogs.Add(resumenAuditLog);
        //                }
        //            }
        //        }
        //    }

        //    foreach (var item in ChangeTracker.Entries()) // Itera sobre todas las entidades que han sido modificadas en el contexto de cambio.
        //    {
        //        if (item.Entity is BaseEntity entity) // Verifica si la entidad es del tipo BaseEntity.
        //        {
        //            // Dependiendo del estado de la entidad, se asignan las fechas de creación y actualización.
        //            switch (item.State)
        //            {
        //                // Si la entidad ha sido añadida, se asigna la fecha de creación.
        //                case EntityState.Added:
        //                    entity.CreatedDate = DateTime.Now.ToString("d");
        //                    break;

        //                // Si la entidad ha sido modificada, no se modifica la fecha de creación y se asigna la fecha de actualización.
        //                case EntityState.Modified:
        //                    Entry(entity).Property(x => x.CreatedDate).IsModified = false;
        //                    entity.UpdatedDate = DateTime.Now.ToString("d");
        //                    break;

        //                default:
        //                    break;
        //            }
        //        }
        //    }

        //    return base.SaveChangesAsync(cancellationToken);
        //}



        // METODO FUNCIONANDO CORRECTAMENTE PARA LAS ENTIDADES QUE YO ELIJA

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var modifiedEntitiesMiembro = ChangeTracker.Entries<Miembro>()
            .Where(e => e.State == EntityState.Added
                     || e.State == EntityState.Modified
                     || e.State == EntityState.Deleted)
            .ToList();  // Esto ya es List<EntityEntry<Miembro>>

            var modifiedEntitiesPago = ChangeTracker.Entries<Pago>()
            .Where(e => e.State == EntityState.Added
                     || e.State == EntityState.Modified
                     || e.State == EntityState.Deleted)
            .ToList();  // Esto también es List<EntityEntry<Pago>>

            var modifiedEntitiesAutorizacion = ChangeTracker.Entries<AutorizacionPago>()
            .Where(e => e.State == EntityState.Added
                     || e.State == EntityState.Modified
                     || e.State == EntityState.Deleted)
            .ToList();  // Esto también es List<EntityEntry<Pago>>

            // Convierte ambos a IEnumerable<EntityEntry> y luego concatena
            var allModifiedEntities = modifiedEntitiesMiembro.Cast<EntityEntry>()
            .Concat(modifiedEntitiesPago.Cast<EntityEntry>())
            .Concat(modifiedEntitiesAutorizacion.Cast<EntityEntry>())
            .ToList();

            foreach (var modifiedEntity in allModifiedEntities)
            {
                // Aquí ya asignamos el valor de Action según el estado de la entidad
                string action = string.Empty;

                var primaryKey = modifiedEntity.Metadata.FindPrimaryKey();
                string entityId = "N/A";

                if (primaryKey != null)
                {
                    var keyValues = primaryKey.Properties
                        .Select(p => modifiedEntity.Property(p.Name).CurrentValue?.ToString())
                        .ToList();

                    entityId = string.Join(",", keyValues); // En caso de claves compuestas
                }

                // Crear el log de auditoría por cada entidad modificada
                var auditLog = new AuditLog
                {
                    EntityName = modifiedEntity.Entity.GetType().Name,
                    UserName = _contextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.Name),
                    UserEmail = _contextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.Email),
                    EntityId = "", // Aquí guardamos el ID de la entidad
                    Timestamp = DateTime.Now,
                    Action = action,
                    Changes = GetChanges(modifiedEntity) // Detalles de los cambios
                };

                if (modifiedEntity.Entity is Miembro miembroEntity)
                {
                    if (modifiedEntity.State == EntityState.Added)
                    {
                        action = "Created"; // Acción para creación de Pago
                        //auditLog.Changes = "Se ha creado un Miembro";
                        auditLog.Changes = GetChanges(modifiedEntity);
                        auditLog.Action = action;
                        AuditsLogs.Add(auditLog);
                    }

                    // Verifica si es una modificación (cambio en un Miembro)
                    else if (modifiedEntity.State == EntityState.Modified)
                    {

                        if (miembroEntity != null)
                        {
                            // Detectar cambio en la propiedad 'Activo' (para baja lógica)
                            var originalActivo = (bool)modifiedEntity.OriginalValues["Activo"];
                            var currentActivo = miembroEntity.Activo;

                            // Si el miembro fue marcado como inactivo (baja lógica)
                            if (originalActivo == true && currentActivo == false)
                            {
                                action = "Deleted"; // Acción para baja lógica
                                auditLog.Action = action;
                                // Concatenar los cambios específicos de la eliminación con los cambios generados por GetChanges
                                auditLog.Changes = "Se ha eliminado un Miembro. Cambios: " + GetChanges(modifiedEntity);
                                auditLog.EntityId = entityId;
                                AuditsLogs.Add(auditLog);
                            }
                            // Si el miembro fue restaurado (cambio de inactivo a activo)
                            else if (originalActivo == false && currentActivo == true)
                            {
                                action = "Modified"; // Acción para modificación
                                auditLog.Action = action;
                                // Concatenar los cambios específicos de la restauración con los cambios generados por GetChanges
                                auditLog.Changes = "Se ha restaurado un Miembro. Cambios: " + GetChanges(modifiedEntity);
                                auditLog.EntityId = entityId;
                                AuditsLogs.Add(auditLog);
                            }

                            else
                            {
                                action = "Modified"; // Acción para otras modificaciones
                                auditLog.Action = action;
                                auditLog.Changes = GetChanges(modifiedEntity); // Detalle del cambio genérico
                                auditLog.EntityId = entityId;
                                AuditsLogs.Add(auditLog);
                            }
                        }
                    }
                    // Si es una eliminación física, se registra como 'Deleted'
                    if (modifiedEntity.State == EntityState.Deleted)
                    {
                        action = "Deleted"; // Acción para eliminación
                        auditLog.Action = action;
                        AuditsLogs.Add(auditLog);
                    }
                }


                // Procesar Pagos (sin baja lógica)
                if (modifiedEntity.Entity is Pago pagoEntity)
                {
                    // Auditoría de los pagos
                    if (modifiedEntity.State == EntityState.Added)
                    {
                        action = "Created"; // Acción para creación de Pago
                        auditLog.Changes = GetChanges(modifiedEntity);
                    }
                    else if (modifiedEntity.State == EntityState.Modified)
                    {
                        action = "Modified"; // Acción para modificación de Pago
                        auditLog.Changes = GetChanges(modifiedEntity); // Detalles genéricos del cambio
                        auditLog.EntityId = entityId;
                    }
                    else
                    {
                        action = "Deleted";
                        auditLog.Changes = GetChanges(modifiedEntity);
                    }

                    auditLog.Action = action;
                    AuditsLogs.Add(auditLog);
                }

                // Procesar Pagos (sin baja lógica)
                if (modifiedEntity.Entity is AutorizacionPago autorizationEntity)
                {
                    // Auditoría de los pagos
                    if (modifiedEntity.State == EntityState.Added)
                    {
                        action = "Created"; // Acción para creación de Pago
                        auditLog.Changes = "Se ha autorizado un pago ";
                    }
                    else if (modifiedEntity.State == EntityState.Modified)
                    {
                        action = "Modified"; // Acción para modificación de Pago
                        auditLog.Changes = "Se ha autorizado un Pago. " + GetChanges(modifiedEntity);
                        auditLog.EntityId = entityId;
                    }
                    else
                    {
                        action = "Deleted";
                        auditLog.Changes = GetChanges(modifiedEntity);
                    }

                    auditLog.Action = action;
                    AuditsLogs.Add(auditLog);
                }
            }

            // Manejo de fechas en BaseEntity (si Miembro hereda de BaseEntity, también se aplicará)
            foreach (var item in ChangeTracker.Entries<BaseEntity>())
            {
                switch (item.State)
                {
                    case EntityState.Added:
                        item.Entity.CreatedDate = DateTime.Now.ToString("d");
                        break;
                    case EntityState.Modified:
                        Entry(item.Entity).Property(x => x.CreatedDate).IsModified = false;
                        item.Entity.UpdatedDate = DateTime.Now.ToString("d");
                        break;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }


        private string GetChanges(EntityEntry modifiedEntity)
        {
            var changes = new StringBuilder();
            string entityName = modifiedEntity.Metadata.DisplayName(); // Obtiene el nombre de la entidad

            if (modifiedEntity.State == EntityState.Added)
            {
                foreach (var property in modifiedEntity.CurrentValues.Properties)
                {
                    var currentValue = modifiedEntity.CurrentValues[property];
                    changes.AppendLine($"{property.Name}: '{currentValue}'"); // Mostrar valores iniciales
                }

                // GET CHANGES CUANDO CREAS: SE HA CREADO UN NUEVO "NOMMBRE-ENTIDAD".
                //changes.AppendLine($"Se ha creado un nuevo {entityName}");
            }
            else if (modifiedEntity.State == EntityState.Deleted)
            {
                foreach (var property in modifiedEntity.OriginalValues.Properties)
                {
                    var originalValue = modifiedEntity.OriginalValues[property];
                    changes.AppendLine($"{property.Name}: Deleted value '{originalValue}'"); // Registrar los valores eliminados
                }
            }
            else
            {
                foreach (var property in modifiedEntity.OriginalValues.Properties)
                {
                    var originalValue = modifiedEntity.OriginalValues[property];
                    var currentValue = modifiedEntity.CurrentValues[property];

                    if (!Equals(originalValue, currentValue))
                    {
                        changes.AppendLine($"{property.Name}: From '{originalValue}' to '{currentValue}'");
                    }
                }
            }

            return changes.ToString();
        }

        //public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        //{
        //    var modifiedEntities = ChangeTracker.Entries()
        //        .Where(e => e.State == EntityState.Added
        //        || e.State == EntityState.Modified
        //        || e.State == EntityState.Deleted)
        //        .ToList();

        //    foreach (var modifiedEntity in modifiedEntities)
        //    {
        //        var auditLog = new AuidtLog
        //        {
        //            EntityName = modifiedEntity.Entity.GetType().Name,
        //            UserName = _contextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Name),
        //            UserEmail = _contextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Email),
        //            Action = modifiedEntity.State.ToString(),
        //            Timestamp = DateTime.Now,
        //            Changes = GetChanges(modifiedEntity)
        //        };
        //        AuditsLogs.Add(auditLog);
        //    }

        //    foreach (var item in ChangeTracker.Entries()) // Itera sobre todas las entidades que han sido modificadas en el contexto de cambio.
        //    {
        //        if (item.Entity is BaseEntity entity) // Verifica si la entidad es del tipo BaseEntity.
        //        {
        //            // Dependiendo del estado de la entidad, se asignan las fechas de creación y actualización.
        //            switch (item.State)
        //            {
        //                // Si la entidad ha sido añadida, se asigna la fecha de creación.
        //                case EntityState.Added:
        //                    entity.CreatedDate = DateTime.Now.ToString("d");
        //                    break;

        //                // Si la entidad ha sido modificada, no se modifica la fecha de creación y se asigna la fecha de actualización.
        //                case EntityState.Modified:
        //                    Entry(entity).Property(x => x.CreatedDate).IsModified = false;
        //                    entity.UpdatedDate = DateTime.Now.ToString("d");
        //                    break;

        //                default:
        //                    break;
        //            }
        //        }
        //    }

        //public void LogSessionActivity(string userId, string userName, string userRole, string userEmail, string action, TimeSpan sessionDuration)
        //{
        //    var auditLog = new AuditLogAuthentication
        //    {
        //        UserId = userId,
        //        UserName = userName,
        //        UserRole = userRole,
        //        UserEmail = userEmail,
        //        Action = action,
        //        Timestamp = DateTime.Now,
        //        SessionDuration = sessionDuration
        //    };

        //    AuditLogsAuthentications.Add(auditLog);
        //    SaveChanges(); // Guardamos el cambio en la base de datos.
        //}

        //public async Task AddAuditLogAsync(AuditLogAuthentication auditLog)
        //{
        //    await AuditLogsAuthentications.AddAsync(auditLog);
        //    await SaveChangesAsync();
        //} 
    }
}
