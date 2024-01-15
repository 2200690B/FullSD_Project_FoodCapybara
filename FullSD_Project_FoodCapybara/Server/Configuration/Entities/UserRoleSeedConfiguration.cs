using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace FullSD_Project_FoodCapybara.Server.Configuration.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
            new IdentityUserRole<string>
            {
                RoleId = "adminGUID-20db-474f-8407-5a6b159518ba",
                UserId = "3781efa7-66dc-47f0-860f-e506d04102e4"
            },
            new IdentityUserRole<string>
            {
                RoleId = "staffGUID-20db-474f-8407-5a6b159518bb",
                UserId = "3700efa7-66dc-47f0-860f-e506d04102e4"
            }
            );
        }
    }
}
