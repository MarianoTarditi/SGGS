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
//    public class ProvinciaConfig : IEntityTypeConfiguration<Provincia>
//    {
//        public void Configure(EntityTypeBuilder<Provincia> builder)
//        {
//            builder.Property(x => x.RowVersion).IsRowVersion();
//            builder.Property(x => x.CreatedDate).IsRequired().HasMaxLength(10);
//            builder.Property(x => x.UpdatedDate).HasMaxLength(10);

//            builder.HasData(
//                    new Provincia { Id = 1,
//                        CreatedDate = "05/05/2025",
//                        Nombre = "Buenos Aires" },
//                    new Provincia { Id = 2,
//                        CreatedDate = "05/05/2025",
//                        Nombre = "Buenos Aires-GBA" },
//                    new Provincia { Id = 3,
//                        CreatedDate = "05/05/2025",
//                        Nombre = "Catamarca" },
//                    new Provincia { Id = 4,
//                        CreatedDate = "05/05/2025",
//                        Nombre = "Chaco" },
//                    new Provincia { Id = 5,
//                        CreatedDate = "05/05/2025",
//                        Nombre = "Chubut" },
//                    new Provincia { Id = 6,
//                        CreatedDate = "05/05/2025",
//                        Nombre = "Córdoba" },
//                    new Provincia { Id = 7,
//                        CreatedDate = "05/05/2025",
//                        Nombre = "Corrientes" },
//                    new Provincia { Id = 8,
//                        CreatedDate = "05/05/2025",
//                        Nombre = "Entre Ríos" },
//                    new Provincia { Id = 9,
//                        CreatedDate = "05/05/2025",
//                        Nombre = "Formosa" },
//                    new Provincia { Id = 10,
//                        CreatedDate = "05/05/2025",
//                        Nombre = "Jujuy" },
//                    new Provincia { Id = 11,
//                        CreatedDate = "05/05/2025",
//                        Nombre = "La Pampa" },
//                    new Provincia { Id = 12,
//                        CreatedDate = "05/05/2025",
//                        Nombre = "La Rioja" },
//                    new Provincia { Id = 13,
//                        CreatedDate = "05/05/2025",
//                        Nombre = "Mendoza" },
//                    new Provincia { Id = 14,
//                        CreatedDate = "05/05/2025",
//                        Nombre = "Misiones" },
//                    new Provincia { Id = 15, CreatedDate = "05/05/2025", Nombre = "Neuquén" },
//                    new Provincia { Id = 16,
//                        CreatedDate = "05/05/2025",
//                        Nombre = "Río Negro" },
//                    new Provincia { Id = 17,
//                        CreatedDate = "05/05/2025",
//                        Nombre = "Salta" },
//                    new Provincia { Id = 18,
//                        CreatedDate = "05/05/2025",
//                        Nombre = "San Juan" },
//                    new Provincia { Id = 19,
//                        CreatedDate = "05/05/2025",
//                        Nombre = "San Luis" },
//                    new Provincia { Id = 20,
//                        CreatedDate = "05/05/2025",
//                        Nombre = "Santa Cruz" },
//                    new Provincia { Id = 21,
//                        CreatedDate = "05/05/2025",
//                        Nombre = "Santa Fe" },
//                    new Provincia { Id = 22,
//                        CreatedDate = "05/05/2025",
//                        Nombre = "Santiago del Estero" },
//                    new Provincia { Id = 23,
//                        CreatedDate = "05/05/2025",
//                        Nombre = "Tierra del Fuego" },
//                    new Provincia { Id = 24,
//                        CreatedDate = "05/05/2025",
//                        Nombre = "Tucumán" }
//               );
//        }
//    }
//}
