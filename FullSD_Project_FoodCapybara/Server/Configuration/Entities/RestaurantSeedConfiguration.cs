using FullSD_Project_FoodCapybara.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FullSD_Project_FoodCapybara.Server.Configuration.Entities
{
    public class RestaurantSeedConfiguration : IEntityTypeConfiguration<Restaurant>
    {

        public void Configure(EntityTypeBuilder<Restaurant> builder)
        {

            builder.HasData(
                new Restaurant
                {
                    Id = 1,
                    RestName = "Papa's Pizzeria",
                    RestAddress = "TastyVille Street 69 Papa's Mall #01-123",
                    RestDescription = "Be it for delivery or takeaway from the nearest Papa's pizzeria outlet," +
                    " we have pizza makers ready to make fresh and hot pizzas to satisfy your cravings. " +
                    " Enjoy freshly made and oven-baked pizzas by Papa's Pizzeria!",
                    RestCategory = "Fast Food"
                    
                },
                new Restaurant
                {
                    Id = 2,
                    RestName = "Papa's Bakeria",
                    RestAddress = "TastyVille Street 69 Papa's Mall #01-124",
                    RestDescription = "Experience the art of baking at Papa's Bakeria, where each pastry is crafted with passion and expertise. " +
                    "Indulge in our delightful cakes, fresh bread, and savory pastries, " +
                    "we guarantee a journey of exquisite flavors and quality ingredients! " +
                    "Enjoy the warmth of our ovens as we bring you the finest baked goods in TastyVille.",
                    RestCategory = "Bakeries"

                }
        );

            
        }
    }
}

// Restaurants:
//Id
//RestName
//RestAddress
//RestDescription
//RestCategory
//List<Food>? Menu

