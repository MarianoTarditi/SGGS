using Entity.Identity.Entities;
using Entity.WebAplication.Entities;
using Entity.WebAplication.ViewModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Entity.Identity.Entities.BaseEntities;

namespace DAL.Context
{
    public class dbContext : IdentityDbContext<AppUser, AppRole, string>
    {
        public dbContext(DbContextOptions options) : base(options)
        {

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
        public DbSet<Recibo> Recibos { get; set; }
  
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Funcion> Funciones { get; set; }
        public DbSet<Provincia> Provincias { get; set; }
        public DbSet<Localidad> Localidades { get; set; }
        public DbSet<Idioma> Idiomas { get; set; }
        public DbSet<Discapacidad> Discapacidades { get; set; }
        public DbSet<Deuda> Deudas { get; set; }
        //public DbSet<Asociacion> Asociaciones { get; set; }
        public DbSet<ModalidadPago> ModalidadPagos { get; set; }
        public DbSet<Educador> Educadores { get; set; }
        public DbSet<EstadoAutorizacion> EstadoAutorizaciones { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<AutorizacionPago>().Property(x => x.RowVersion).IsRowVersion();
            modelBuilder.Entity<AutorizacionPago>().Property(x => x.CreatedDate).IsRequired().HasMaxLength(10);
            modelBuilder.Entity<AutorizacionPago>().Property(x => x.UpdatedDate).HasMaxLength(10);


            modelBuilder.Entity<Categoria>().Property(x => x.RowVersion).IsRowVersion();
            modelBuilder.Entity<Categoria>().Property(x => x.CreatedDate).IsRequired().HasMaxLength(10);
            modelBuilder.Entity<Categoria>().Property(x => x.UpdatedDate).HasMaxLength(10);

            modelBuilder.Entity<CategoriaPago>().Property(x => x.RowVersion).IsRowVersion();
            modelBuilder.Entity<CategoriaPago>().Property(x => x.CreatedDate).IsRequired().HasMaxLength(10);
            modelBuilder.Entity<CategoriaPago>().Property(x => x.UpdatedDate).HasMaxLength(10);

            modelBuilder.Entity<Deposito>().Property(x => x.RowVersion).IsRowVersion();
            modelBuilder.Entity<Deposito>().Property(x => x.CreatedDate).IsRequired().HasMaxLength(10);
            modelBuilder.Entity<Deposito>().Property(x => x.UpdatedDate).HasMaxLength(10);

            modelBuilder.Entity<DetallePago>().Property(x => x.RowVersion).IsRowVersion();
            modelBuilder.Entity<DetallePago>().Property(x => x.CreatedDate).IsRequired().HasMaxLength(10);
            modelBuilder.Entity<DetallePago>().Property(x => x.UpdatedDate).HasMaxLength(10);

            modelBuilder.Entity<Deuda>().Property(x => x.RowVersion).IsRowVersion();
            modelBuilder.Entity<Deuda>().Property(x => x.CreatedDate).IsRequired().HasMaxLength(10);
            modelBuilder.Entity<Deuda>().Property(x => x.UpdatedDate).HasMaxLength(10);

            modelBuilder.Entity<Discapacidad>().Property(x => x.RowVersion).IsRowVersion();
            modelBuilder.Entity<Discapacidad>().Property(x => x.CreatedDate).IsRequired().HasMaxLength(10);
            modelBuilder.Entity<Discapacidad>().Property(x => x.UpdatedDate).HasMaxLength(10);

            modelBuilder.Entity<Educador>().Property(x => x.RowVersion).IsRowVersion();
            modelBuilder.Entity<Educador>().Property(x => x.CreatedDate).IsRequired().HasMaxLength(10);
            modelBuilder.Entity<Educador>().Property(x => x.UpdatedDate).HasMaxLength(10);

            modelBuilder.Entity<Efectivo>().Property(x => x.RowVersion).IsRowVersion();
            modelBuilder.Entity<Efectivo>().Property(x => x.CreatedDate).IsRequired().HasMaxLength(10);
            modelBuilder.Entity<Efectivo>().Property(x => x.UpdatedDate).HasMaxLength(10);

            modelBuilder.Entity<Estudio>().Property(x => x.RowVersion).IsRowVersion();
            modelBuilder.Entity<Estudio>().Property(x => x.CreatedDate).IsRequired().HasMaxLength(10);
            modelBuilder.Entity<Estudio>().Property(x => x.UpdatedDate).HasMaxLength(10);

            modelBuilder.Entity<Funcion>().Property(x => x.RowVersion).IsRowVersion();
            modelBuilder.Entity<Funcion>().Property(x => x.CreatedDate).IsRequired().HasMaxLength(10);
            modelBuilder.Entity<Funcion>().Property(x => x.UpdatedDate).HasMaxLength(10);

            modelBuilder.Entity<Idioma>().Property(x => x.RowVersion).IsRowVersion();
            modelBuilder.Entity<Idioma>().Property(x => x.CreatedDate).IsRequired().HasMaxLength(10);
            modelBuilder.Entity<Idioma>().Property(x => x.UpdatedDate).HasMaxLength(10);

            modelBuilder.Entity<Localidad>().Property(x => x.RowVersion).IsRowVersion();
            modelBuilder.Entity<Localidad>().Property(x => x.CreatedDate).IsRequired().HasMaxLength(10);
            modelBuilder.Entity<Localidad>().Property(x => x.UpdatedDate).HasMaxLength(10);

            modelBuilder.Entity<Miembro>(entity =>
            {
                entity.Property(x => x.CreatedDate)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(x => x.RowVersion)
                    .IsRowVersion();

                entity.Property(x => x.UpdatedDate)
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<ModalidadPago>().Property(x => x.RowVersion).IsRowVersion();
            modelBuilder.Entity<ModalidadPago>().Property(x => x.CreatedDate).IsRequired().HasMaxLength(10);
            modelBuilder.Entity<ModalidadPago>().Property(x => x.UpdatedDate).HasMaxLength(10);

            modelBuilder.Entity<Nacionalidad>().Property(x => x.RowVersion).IsRowVersion();
            modelBuilder.Entity<Nacionalidad>().Property(x => x.CreatedDate).IsRequired().HasMaxLength(10);
            modelBuilder.Entity<Nacionalidad>().Property(x => x.UpdatedDate).HasMaxLength(10);

            modelBuilder.Entity<Organismo>().Property(x => x.RowVersion).IsRowVersion();
            modelBuilder.Entity<Organismo>().Property(x => x.CreatedDate).IsRequired().HasMaxLength(10);
            modelBuilder.Entity<Organismo>().Property(x => x.UpdatedDate).HasMaxLength(10);

            modelBuilder.Entity<Provincia>().Property(x => x.RowVersion).IsRowVersion();
            modelBuilder.Entity<Provincia>().Property(x => x.CreatedDate).IsRequired().HasMaxLength(10);
            modelBuilder.Entity<Provincia>().Property(x => x.UpdatedDate).HasMaxLength(10);

            modelBuilder.Entity<Rama>().Property(x => x.RowVersion).IsRowVersion();
            modelBuilder.Entity<Rama>().Property(x => x.CreatedDate).IsRequired().HasMaxLength(10);
            modelBuilder.Entity<Rama>().Property(x => x.UpdatedDate).HasMaxLength(10);

            modelBuilder.Entity<Recibo>().Property(x => x.RowVersion).IsRowVersion();
            modelBuilder.Entity<Recibo>().Property(x => x.CreatedDate).IsRequired().HasMaxLength(10);
            modelBuilder.Entity<Recibo>().Property(x => x.UpdatedDate).HasMaxLength(10);

            modelBuilder.Entity<Religion>().Property(x => x.RowVersion).IsRowVersion();
            modelBuilder.Entity<Religion>().Property(x => x.CreatedDate).IsRequired().HasMaxLength(10);
            modelBuilder.Entity<Religion>().Property(x => x.UpdatedDate).HasMaxLength(10);

            modelBuilder.Entity<Resumen>().Property(x => x.RowVersion).IsRowVersion();
            modelBuilder.Entity<Resumen>().Property(x => x.CreatedDate).IsRequired().HasMaxLength(10);
            modelBuilder.Entity<Resumen>().Property(x => x.UpdatedDate).HasMaxLength(10);

            modelBuilder.Entity<Sexo>().Property(x => x.RowVersion).IsRowVersion();
            modelBuilder.Entity<Sexo>().Property(x => x.CreatedDate).IsRequired().HasMaxLength(10);
            modelBuilder.Entity<Sexo>().Property(x => x.UpdatedDate).HasMaxLength(10);

            modelBuilder.Entity<Transferencia>().Property(x => x.RowVersion).IsRowVersion();
            modelBuilder.Entity<Transferencia>().Property(x => x.CreatedDate).IsRequired().HasMaxLength(10);
            modelBuilder.Entity<Transferencia>().Property(x => x.UpdatedDate).HasMaxLength(10);

            modelBuilder.Entity<Pago>().Property(x => x.RowVersion).IsRowVersion();
            modelBuilder.Entity<Pago>().Property(x => x.CreatedDate).IsRequired().HasMaxLength(10);
            modelBuilder.Entity<Pago>().Property(x => x.UpdatedDate).HasMaxLength(10);

            modelBuilder.Entity<EstadoCivil>().Property(x => x.RowVersion).IsRowVersion();
            modelBuilder.Entity<EstadoCivil>().Property(x => x.CreatedDate).IsRequired().HasMaxLength(10);
            modelBuilder.Entity<EstadoCivil>().Property(x => x.UpdatedDate).HasMaxLength(10);

            modelBuilder.Entity<EstadoAutorizacion>().Property(x => x.RowVersion).IsRowVersion();
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


            modelBuilder.Entity<Recibo>()
         .HasOne(r => r.Pago)
         .WithOne(p => p.Recibo)
         .OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<Pago>()
            .HasOne(p => p.Autorizacion)
            .WithMany(a => a.Pagos)
            .HasForeignKey(p => p.AutorizacionPagoId);

            modelBuilder.Entity<Pago>()
         .HasOne(p => p.Recibo)
         .WithOne(r => r.Pago)
         .HasForeignKey<Recibo>(r => r.PagoId); // PagoId es la clave foránea en Recibo

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

            //modelBuilder.Entity<Asociacion>().HasData(
            //new Asociacion
            //{
            //    Id = 1,
            //    CreatedDate = "05/05/2025",
            //    ValorAfiliacion = 1000,
            //    AsociacionNombre = "ScoutsArgentina",
            //    ValorSeguro = 2000
            //});

            modelBuilder.Entity<Sexo>().HasData(
            new Sexo
            {
                Id = 1,
                CreatedDate = "05/05/2025",
                Nombre = "Masculino"
            });

            modelBuilder.Entity<Recibo>().HasData(
            new Recibo
            {
                Id = 1,
                CreatedDate = "05/05/2025",
                Fecha = DateTime.Now,
                Codigo = 1012,
                Total = 3000,
                PagoId = 1,
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

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var item in ChangeTracker.Entries()) // Itera sobre todas las entidades que han sido modificadas en el contexto de cambio.
            {
                if (item.Entity is BaseEntity entity) // Verifica si la entidad es del tipo BaseEntity.
                {
                    // Dependiendo del estado de la entidad, se asignan las fechas de creación y actualización.
                    switch (item.State)
                    {
                        // Si la entidad ha sido añadida, se asigna la fecha de creación.
                        case EntityState.Added:
                            entity.CreatedDate = DateTime.Now.ToString("d");
                            break;

                        // Si la entidad ha sido modificada, no se modifica la fecha de creación y se asigna la fecha de actualización.
                        case EntityState.Modified:
                            Entry(entity).Property(x => x.CreatedDate).IsModified = false;
                            entity.UpdatedDate = DateTime.Now.ToString("d");
                            break;

                        default:
                            break;
                    }
                }
            }
            return base.SaveChangesAsync(cancellationToken); // Llama al método base para realizar la acción de guardar los cambios.
        }
    }
}
