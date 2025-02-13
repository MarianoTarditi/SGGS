//using Entity.WebAplication.Entities;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Reflection.Emit;

//namespace DAL.Configuration.WebApplication
//{
//    public class MiembroConfig : IEntityTypeConfiguration<Miembro>
//    {
//        public void Configure(EntityTypeBuilder<Miembro> builder)
//        {
//            builder.Property(x => x.RowVersion).IsRowVersion();
//            builder.Property(x => x.CreatedDate).IsRequired().HasMaxLength(10);
//            builder.Property(x => x.UpdatedDate).HasMaxLength(10);

//            builder.HasOne(m => m.Organismo).WithMany(o => o.Miembros).HasForeignKey(m => m.OrganismoId).OnDelete(DeleteBehavior.NoAction);

//            builder.HasData(
//            new Miembro
//            {
//                Id = 1,
//                CreatedDate = "05/05/2025",
//                Activo = true,
//                Apellido = "Martinez",
//                CodigoPostal = 2705,
//                Dni = "45621359",
//                FechaNacimiento = DateTime.Now,
//                Email = "marianotarditi2004@gmail.com",
//                LocalidadId = 1,
//                IdiomaId = 1,
//                Nombre = "Lautaro",
//                NacionalidadId = 1,
//                SexoId = 1,
//                DiscapacidadId = 1,
//                ReligionId = 1,
//                EstadoCivilId = 1,
//                OrganismoId = 1,
//                EstudioId = 1,
//                RamaId = 1,
//                FuncionId = 1,
//            });
//        }
//    }
//}
