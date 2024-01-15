using FullSD_Project_FoodCapybara.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FullSD_Project_FoodCapybara.Server.Configuration.Entities
{
    public class StaffSeedConfiguration : IEntityTypeConfiguration<Restaurant>
    {
        public void Configure(EntityTypeBuilder<Restaurant> builder)
        {
            builder.HasData(
                new Staff
                {
                    Id = 1,
                    StaffUsername = "Anthony",
                    StaffPassword = "Adminpassword!",
                    StaffEmail = "admin@staff.com",
                    StaffPhone = 91000001,
                    StaffPosition = "Admin",
                    IsAdmin = true,
                },
                new Staff
                {
                    Id = 2,
                    StaffUsername = "Dorothy",
                    StaffPassword = "Driverpassword!",
                    StaffEmail = "driver@staff.com",
                    StaffPhone = 91000011,
                    StaffPosition = "Driver",
                    IsAdmin = false,
                }
                );
        }
    }
}

// int Id 
//string? StaffUsername 
//string? StaffPassword 
// string? StaffEmail 
// int StaffPhone 
// string? StaffPosition 
//  bool? IsAdmin 
