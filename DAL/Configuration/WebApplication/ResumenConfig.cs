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
//    public class ResumenConfig : IEntityTypeConfiguration<Resumen>
//    {
//        public void Configure(EntityTypeBuilder<Resumen> builder)
//        {
//            builder.Property(x => x.RowVersion).IsRowVersion();
//            builder.Property(x => x.CreatedDate).IsRequired().HasMaxLength(10);
//            builder.Property(x => x.UpdatedDate).HasMaxLength(10);

//            builder.HasData(
//            new Resumen
//            {
//                Id = 9,
//                CreatedDate = "05/05/2025",
//                Credito = 200,
//                Debito = 200,
//                OrganismoId = 9,
//                Saldo = 500,

//            });
//        }
//    }
//}
