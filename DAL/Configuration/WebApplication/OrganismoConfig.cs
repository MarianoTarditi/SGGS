//using Entity.WebAplication.Entities;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DAL.Configuration.WebApplication
//{
//    public class OrganismoConfig : IEntityTypeConfiguration<Organismo>
//    {
//        public void Configure(EntityTypeBuilder<Organismo> builder)
//        {
//            builder.Property(x => x.RowVersion).IsRowVersion();
//            builder.Property(x => x.CreatedDate).IsRequired().HasMaxLength(10);
//            builder.Property(x => x.UpdatedDate).HasMaxLength(10);

//            builder.HasData(
//            new Organismo
//            {
//                Id = 9,
//                CreatedDate = "05/05/2025",
//                Codigo = 1,
//                FechaCreacion = DateTime.Now,
//                Descripcion = "Grupo Scout de Entre Rios",
//                Nombre = "San isidrio labrador",
//                Direccion = "Dardo rocha 78",
//                CodigoPostal = 2705,
//                LocalidadId = 1,
//                AsociacionId = 1,
//                Activo = true
//            });
//        }
//    }
//}
