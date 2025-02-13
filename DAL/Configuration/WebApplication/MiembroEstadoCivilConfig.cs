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
//    public class MiembroEstadoCivilConfig : IEntityTypeConfiguration<EstadoCivil>
//    {
//        public void Configure(EntityTypeBuilder<EstadoCivil> builder)
//        {
//            builder.Property(x => x.RowVersion).IsRowVersion();
//            builder.Property(x => x.CreatedDate).IsRequired().HasMaxLength(10);
//            builder.Property(x => x.UpdatedDate).HasMaxLength(10);

//            builder.HasData(
//            new EstadoCivil
//            {
//                Id = 1,
//                CreatedDate = "05/05/2025",
//                Nombre = "Masculino"
//            },
//            new EstadoCivil
//            {
//                Id = 2,
//                CreatedDate = "05/05/2025",
//                Nombre = "Femenino"
//            },  new EstadoCivil
//            {
//                Id = 3,
//                CreatedDate = "05/05/2025",
//                Nombre = "X"
//            });
//        }
//    }
//}
