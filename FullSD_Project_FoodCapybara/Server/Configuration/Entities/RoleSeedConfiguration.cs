using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace FullSD_Project_FoodCapybara.Server.Configuration.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
            new IdentityRole
            {
                Id = "adminGUID-20db-474f-8407-5a6b159518ba",
                Name = "Administrator",
                NormalizedName = "ADMINISTRATOR"
            },
            new IdentityRole
            {
                Id = "staffGUID-20db-474f-8407-5a6b159518bb",
                Name = "Staff",
                NormalizedName = "STAFF"
            },
            new IdentityRole
            {
                Id = "userGUID-20db-474f-8407-5a6b159518bb",
                Name = "User",
                NormalizedName = "USER"
            }
            );
            
        }
    }
}

