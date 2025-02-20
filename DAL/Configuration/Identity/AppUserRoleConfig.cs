using Entity.Identity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RepositoryLayer.Configuration.Identity
{
    public class AppUserRoleConfig : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            builder.HasData(new AppUserRole
            {
                UserId = Guid.Parse("070A9212-D4A9-44DA-8479-4EC813B63621").ToString(),
                RoleId = Guid.Parse("9B67832B-7091-48E8-AA0A-F1B3BAECA418").ToString()
            }, new AppUserRole
            {
                UserId = Guid.Parse("6B0E483C-EBAE-4ED3-827E-8ED27F7D9131").ToString(),
                RoleId = Guid.Parse("AFFEDC34-9713-423A-880E-4A61CEEFB7B1").ToString()
            }, new AppUserRole
            {
                UserId = Guid.Parse("F906A15B-50F8-4E47-B44F-DF9AC87DEE9A").ToString(),
                RoleId = Guid.Parse("A086370D-A143-42D2-AD86-1D32EB9E7546").ToString()
            });
        }
    }
}
