using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FullSD_Project_FoodCapybara.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultUsers : Migration
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
                    { "3700efa7-66dc-47f0-860f-e506d04102e4", 0, "2b9fa891-8770-4fe4-a728-a39827668af5", "staff@localhost.com", false, "Staff", "User", false, null, "STAFF@LOCALHOST.COM", "STAFF@LOCALHOST.COM", "AQAAAAIAAYagAAAAEMV3TAhGE85pYf+iUTblOlODFmGecQElCIOt5Q3RZgeOkhA04gO0HaaXpB2c5H1c/w==", null, false, "719e83f6-2fee-4109-9418-010b927b8b52", false, "staff@localhost.com" },
                    { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "13d14c97-16a8-4475-92d8-13e1e7882c7c", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEGQnZ3dprLSIAYImy0oGJEV3oE/v6gLUEuNb8ApjfVOFhIJov/nhQsgrLzv6B1ZCwQ==", null, false, "29ad0870-d3b0-466e-a968-400db839d5cc", false, "admin@localhost.com" }
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
