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
//    public class ModalidadDepositoConfig : IEntityTypeConfiguration<Deposito>
//    {
//        public void Configure(EntityTypeBuilder<Deposito> builder)
//        {
//            builder.Property(x => x.RowVersion).IsRowVersion();
//            builder.Property(x => x.CreatedDate).IsRequired().HasMaxLength(10);
//            builder.Property(x => x.UpdatedDate).HasMaxLength(10);

//            builder.HasData(
//                new Deposito
//                {
//                    Id = 3,
//                    CreatedDate = "05/05/2025",
//                    NumeroSucursal = "1234",
//                    NumeroOperacion = "5678",
//                    NumeroCuenta = "9876",
//                    FechaDePago = DateTime.Now,
//                    Observacion = "sad",
//                    PagoId = 1,
//                    NombreCompleto = "Mariano"
//                }
//            );
//        }
//    }

//}
