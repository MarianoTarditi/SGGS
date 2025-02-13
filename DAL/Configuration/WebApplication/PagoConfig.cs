//using Entity.WebAplication.Entities;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using System.Reflection.Emit;

//namespace RepositoryLayer.Configuration.WebApplication
//{
//    public class PagoConfig : IEntityTypeConfiguration<Pago>
//    {
//        public void Configure(EntityTypeBuilder<Pago> builder)
//        {
//            builder.Property(x => x.RowVersion).IsRowVersion();
//            builder.Property(x => x.CreatedDate).IsRequired().HasMaxLength(10);
//            builder.Property(x => x.UpdatedDate).HasMaxLength(10);

//            builder.HasOne(x => x.Miembro).WithMany(z => z.Pagos).HasForeignKey(x => x.MiembroId).OnDelete(DeleteBehavior.Restrict);
//            builder.HasOne(p => p.Recibo) .WithOne(r => r.Pago).HasForeignKey<Recibo>(r => r.PagoId);
//            builder.HasOne(p => p.Autorizacion).WithOne(a => a.Pago) .HasForeignKey<AutorizacionPago>(a => a.PagoId);
            
//            builder.HasData(
//            new Pago
//            {
//                Id = 99,
//                Codigo = 1,
//                ResumenId = 9,
//                Total = 10000,
//                TipoModalidad = "Efectivo",
//                MiembroId = 4,
//                Activo = true,
//                CreatedDate = "05/05/2025",
                
//            });
//        }
//    }
//}
