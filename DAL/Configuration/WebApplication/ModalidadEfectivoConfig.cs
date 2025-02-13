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
//    public class ModalidadEfectivoConfig : IEntityTypeConfiguration<Efectivo>
//    {
//        public void Configure(EntityTypeBuilder<Efectivo> builder)
//        {
//            builder.ToTable("ModalidadEfectivo");

//            builder.HasData(
//                new Efectivo
//                {
//                    Id = 2,
//                    CreatedDate = "05/05/2025",
//                    FechaDePago = DateTime.Now,
//                    Observacion = "sad",
//                    PagoId = 2,
//                    NombreCompleto = "Mariano"
//                }
//            );
//        }
//    }

//}
