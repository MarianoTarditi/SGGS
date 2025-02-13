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
//    public class PagoModalidadConfig : IEntityTypeConfiguration<ModalidadPago>
//    {
//        public void Configure(EntityTypeBuilder<ModalidadPago> builder)
//        {
//            builder.ToTable("PagoModalidad");

//            builder.HasKey(x => x.Id); // Define la clave primaria en la clase base.

//            builder.Property(x => x.RowVersion).IsRowVersion();
//            builder.Property(x => x.CreatedDate)
//                .IsRequired()
//                .HasMaxLength(10);
//            builder.Property(x => x.UpdatedDate)
//                .HasMaxLength(10);

//            //   builder.HasOne(x => x.Pago)
//            //.WithOne(x => x.ModalidadPago)
//            //.OnDelete(DeleteBehavior.Restrict);

//            // No es necesario agregar datos de la clase base.

//            builder.HasData(
//            new ModalidadPago
//            {
//                Id = 1,
//                CreatedDate = "05/05/2025",
//                FechaDePago = DateTime.Now,
//                Observacion = "sad",
//                PagoId = 99,
//                NombreCompleto = "Mariano"
//            }
//            );
//        }
//    }
//}

