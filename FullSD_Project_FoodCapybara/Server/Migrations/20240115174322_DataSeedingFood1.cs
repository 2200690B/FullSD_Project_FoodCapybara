using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FullSD_Project_FoodCapybara.Server.Migrations
{
    /// <inheritdoc />
    public partial class DataSeedingFood1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3700efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5c4f79b6-46ca-49a7-928c-64ad61e8f597", "AQAAAAIAAYagAAAAEABdX08d56JR0+7i9j3DRlUbPKz2FOUnN6WZ2hDt5T38/z+XwC66afFmTV5KlIT2Mw==", "d4a70a5a-2b17-4ce5-b6f6-12bd726ffa20" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3b0608a7-36f3-433e-b3a1-d2d82a11e391", "AQAAAAIAAYagAAAAEGMwIcwu7wM9AvxgL9PxQzOInzOy21Zf3xj8jMFQ0wc/U+6fNxO4gU7OrQSKtPDfQw==", "c1d74e4d-4f62-4af5-872a-f2d717ef079b" });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "FoodCost", "FoodDesc", "FoodName", "FoodRating", "RestId" },
                values: new object[,]
                {
                    { 1, 12.99m, "Classic pizza with tomato, mozzarella, and basil.", "Margherita  Pizza", 5, 1 },
                    { 2, 14.99m, "Pizza with pepperoni and cheese.", "Pepperoni Pizza", 4, 1 },
                    { 3, 7.99m, "Crispy breadsticks with garlic butter.", "Garlic Breadsticks", 4, 1 },
                    { 4, 2.49m, "Classic carbonated beverage.", "Soda", 3, 1 },
                    { 5, 1.99m, "Refreshing iced tea.", "Iced Tea", 3, 1 },
                    { 6, 3.99m, "A flaky and buttery croissant filled with rich chocolate.", "Chocolate Croissant", 4, 2 },
                    { 7, 2.49m, "Soft and moist muffin bursting with juicy blueberries.", "Blueberry Muffin", 5, 2 },
                    { 8, 4.49m, "Classic croissant with a sweet almond filling and crunchy almonds on top.", "Almond Croissant", 4, 2 },
                    { 9, 3.79m, "Spiraled pastry with layers of cinnamon sugar and topped with cream cheese icing.", "Cinnamon Roll", 5, 2 },
                    { 10, 3.29m, "Delicate pastry filled with sweet cream cheese filling.", "Cheese Danish", 4, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3700efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c4d5852-6888-4d11-881f-a3f069ec6595", "AQAAAAIAAYagAAAAEId2q0Mfk47owb964Q3jmweg3JoKfhbBbt0J8ITJYHy2SQwaTudiGc6rfLjpypLVRA==", "05c8a872-e060-4af0-aeb3-cdd7b085d6ad" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6f975851-7a4c-46c6-b5f4-c37cc5ae7d9e", "AQAAAAIAAYagAAAAEM5t/AZZmi2i6HAT9NF/tnQf1hUsrpI4xTj4N0xueq1nALOtoDOSHTHPeB0xrNqGdQ==", "57593842-b32a-4409-bdff-d19f127c6eba" });
        }
    }
}
