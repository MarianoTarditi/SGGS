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
//    public class PagoAutorizacionConfig : IEntityTypeConfiguration<AutorizacionPago>
//    {
//        public void Configure(EntityTypeBuilder<AutorizacionPago> builder)
//        {
//            builder.Property(x => x.RowVersion).IsRowVersion();
//            builder.Property(x => x.CreatedDate).IsRequired().HasMaxLength(10);
//            builder.Property(x => x.UpdatedDate).HasMaxLength(10);

//            builder.HasData(
//            new AutorizacionPago
//            {
//                Id = 1,
//                CreatedDate = "05/05/2025",
//                Fecha = DateTime.Now,
//                Autorizado = true,
//                PagoId = 2,
//            });
//        }
//    }
//}
