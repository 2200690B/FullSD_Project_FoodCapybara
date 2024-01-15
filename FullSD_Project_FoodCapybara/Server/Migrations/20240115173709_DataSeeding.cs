using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FullSD_Project_FoodCapybara.Server.Migrations
{
    /// <inheritdoc />
    public partial class DataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "adminGUID-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "staffGUID-20db-474f-8407-5a6b159518bb", null, "Staff", "STAFF" },
                    { "userGUID-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3700efa7-66dc-47f0-860f-e506d04102e4", 0, "d2f0c1b1-2780-4311-bb6e-d53f695efb25", "staff@localhost.com", false, "Staff", "User", false, null, "STAFF@LOCALHOST.COM", "STAFF@LOCALHOST.COM", "AQAAAAIAAYagAAAAELBDBnZPb2B6AgyfTJQ4ruMEw77xP1ABgzFuu4sJB+2TaIoxUF3kCTvHSw2y0Z/dMw==", null, false, "b24a33f6-81d9-44ce-9703-e400a3b7b79c", false, "staff@localhost.com" },
                    { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "211c4243-ba2b-4881-8e1f-ae8cdfde2cb8", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEIxiZ7AooMvxYuOs50Ipj2HUeFjcU5j1m38H61lNbim3Ae0JzirTcd4aHnzR7lhTRg==", null, false, "793aaa68-6766-4065-91d7-7dd08ab5f9a9", false, "admin@localhost.com" }
                });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "RestAddress", "RestCategory", "RestDescription", "RestName" },
                values: new object[,]
                {
                    { 1, "TastyVille Street 69 Papa's Mall #01-123", "Fast Food", "Be it for delivery or takeaway from the nearest Papa's pizzeria outlet, we have pizza makers ready to make fresh and hot pizzas to satisfy your cravings.  Enjoy freshly made and oven-baked pizzas by Papa's Pizzeria!", "Papa's Pizzeria" },
                    { 2, "TastyVille Street 69 Papa's Mall #01-124", "Bakeries", "Experience the art of baking at Papa's Bakeria, where each pastry is crafted with passion and expertise. Indulge in our delightful cakes, fresh bread, and savory pastries, we guarantee a journey of exquisite flavors and quality ingredients! Enjoy the warmth of our ovens as we bring you the finest baked goods in TastyVille.", "Papa's Bakeria" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "staffGUID-20db-474f-8407-5a6b159518bb", "3700efa7-66dc-47f0-860f-e506d04102e4" },
                    { "adminGUID-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "userGUID-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "staffGUID-20db-474f-8407-5a6b159518bb", "3700efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "adminGUID-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "adminGUID-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "staffGUID-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3700efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}
