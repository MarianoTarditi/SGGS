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
//    public class MiembroDiscapacidadConfig : IEntityTypeConfiguration<Discapacidad>
//    {
//        public void Configure(EntityTypeBuilder<Discapacidad> builder)
//        {
//            builder.Property(x => x.RowVersion).IsRowVersion();
//            builder.Property(x => x.CreatedDate).IsRequired().HasMaxLength(10);
//            builder.Property(x => x.UpdatedDate).HasMaxLength(10);

//            builder.HasData(
//            new Discapacidad
//            {
//                Id = 1,
//                CreatedDate = "05/05/2025",
//                Nombre = "Diselxia",
//            });
//        }
//    }
//}
