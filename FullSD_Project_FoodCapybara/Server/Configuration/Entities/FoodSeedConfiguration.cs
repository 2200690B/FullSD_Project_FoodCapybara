using FullSD_Project_FoodCapybara.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FullSD_Project_FoodCapybara.Server.Configuration.Entities
{
    public class FoodSeedConfiguration : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {
            SeedRestaurant1Foods(builder);
            SeedRestaurant2Foods(builder);
        }

        private void SeedRestaurant1Foods(EntityTypeBuilder<Food> builder)
        {

            builder.HasData(
                new Food
                {
                    Id = 1,
                    RestId = 1,
                    FoodName = "Margherita  Pizza",
                    FoodRating = 5,
                    FoodDesc = "Classic pizza with tomato, mozzarella, and basil.",
                    FoodCost = 12.99m
                },
                new Food
                {
                    Id = 2,
                    RestId = 1,
                    FoodName = "Pepperoni Pizza",
                    FoodRating = 4,
                    FoodDesc = "Pizza with pepperoni and cheese.",
                    FoodCost = 14.99m
                }
                );

        }

        private void SeedRestaurant2Foods(EntityTypeBuilder<Food> builder)
        {
            builder.HasData(
                new Food
                {
                    Id = 6,
                    RestId = 2, // Assuming this corresponds to Papa's Bakeria
                    FoodName = "Chocolate Croissant",
                    FoodRating = 4,
                    FoodDesc = "A flaky and buttery croissant filled with rich chocolate.",
                    FoodCost = 3.99m
                },
                new Food
                {
                    Id = 7,
                    RestId = 2,
                    FoodName = "Blueberry Muffin",
                    FoodRating = 5,
                    FoodDesc = "Soft and moist muffin bursting with juicy blueberries.",
                    FoodCost = 2.49m
                }
        );
        }
    }
}

//Food
// int Id
// int RestId
// string FoodName
// int FoodRating
// string? FoodDesc
// decimal FoodCost
