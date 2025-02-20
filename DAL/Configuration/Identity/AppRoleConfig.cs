using Entity.Identity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RepositoryLayer.Configuration.Identity
{
    public class AppRoleConfig : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            builder.HasData(new AppRole
            {
                Id = Guid.Parse("9B67832B-7091-48E8-AA0A-F1B3BAECA418").ToString(),
                Name = "SuperAdmin",
                NormalizedName = "SUPERADMIN",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
            }, new AppRole
            {
                Id = Guid.Parse("AFFEDC34-9713-423A-880E-4A61CEEFB7B1").ToString(),
                Name = "Member",
                NormalizedName = "MEMBER",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
            }, new AppRole
            {
                Id = Guid.Parse("A086370D-A143-42D2-AD86-1D32EB9E7546").ToString(),
                Name = "External Member",
                NormalizedName = "EXTERNAL MEMBER",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
            });

        }
    }
}
