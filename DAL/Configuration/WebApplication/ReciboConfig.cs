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
//    public class ReciboConfig : IEntityTypeConfiguration<Recibo>
//    {
//        public void Configure(EntityTypeBuilder<Recibo> builder)
//        {
//            builder.Property(x => x.RowVersion).IsRowVersion();
//            builder.Property(x => x.CreatedDate).IsRequired().HasMaxLength(10);
//            builder.Property(x => x.UpdatedDate).HasMaxLength(10);

//            builder.HasOne(r => r.Pago).WithOne(p => p.Recibo).OnDelete(DeleteBehavior.Cascade);

//            builder.HasData(
//            new Recibo
//            {
//                Id = 1,
//                CreatedDate = "05/05/2025",
//                Fecha = DateTime.Now,
//                Codigo = 1012,
//                Total = 3000,
//                PagoId = 1,
//            });
//        }
//    }
//}
