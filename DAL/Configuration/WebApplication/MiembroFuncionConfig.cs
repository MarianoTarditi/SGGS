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
//    public class MiembroFuncionConfig : IEntityTypeConfiguration<Funcion>
//    {
//        public void Configure(EntityTypeBuilder<Funcion> builder)
//        {
//            builder.Property(x => x.RowVersion).IsRowVersion();
//            builder.Property(x => x.CreatedDate).IsRequired().HasMaxLength(10);
//            builder.Property(x => x.UpdatedDate).HasMaxLength(10);

//            builder.HasData(
//            new Funcion
//            {
//                Id = 1,
//                CreatedDate = "05/05/2025",
//                Nombre = "Protagonista"
//            });
//        }
//    }
//}
