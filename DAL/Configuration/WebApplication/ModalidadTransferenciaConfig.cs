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
//    public class ModalidadTransferenciaConfig : IEntityTypeConfiguration<Transferencia>
//    {
//        public void Configure(EntityTypeBuilder<Transferencia> builder)
//        {
//            builder.ToTable("ModalidadTransferencia");

//            builder.Property(x => x.BancoOrigen).HasMaxLength(50);
//            builder.Property(x => x.NroCuentaOrigenFondo).HasMaxLength(20);
//            builder.Property(x => x.NumeroOperacion).HasMaxLength(20);
//            builder.Property(x => x.Dni).HasMaxLength(15);

//            builder.HasData(
//                new Transferencia
//                {
//                    Id = 5,
//                    CreatedDate = "05/05/2025",
//                    BancoOrigen = "sadas",
//                    NroCuentaOrigenFondo = "24213",
//                    NumeroOperacion = "343",
//                    Dni = "4545",
//                    FechaDePago = DateTime.Now,
//                    Observacion = "sad",
//                    PagoId = 3,
//                    NombreCompleto = "Mariano"
//                }
//            );
//        }
//    }

//}
