using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FullSD_Project_FoodCapybara.Server.Migrations
{
    /// <inheritdoc />
    public partial class updateRestaurantImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3700efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3cfbec17-f9f7-497d-9f45-551c10123fbf", "AQAAAAIAAYagAAAAEKKCJNvA1J7X4OX5m8pXO+LhgEt6uKAfF55r3po4Jz7D/YqoGdOhZLCh7n1IIHcV0w==", "2c01db11-df1c-4d94-b4ce-9ceff6180617" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4637bbe2-1143-4d13-b315-aa64a4b489c0", "AQAAAAIAAYagAAAAEPlHryAMaTy44BNE9nTetheotNcLqZWEprFZraIideqR//+bD0MygAUR1NDsoqxP0A==", "80cdf42f-0177-483c-8fd6-efe3671d4c05" });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1,
                column: "RestImage",
                value: "Rest1.png");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 2,
                column: "RestImage",
                value: "Rest2.png");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3700efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "17a66cc3-eaa4-46dd-a56a-3bdcccbc6454", "AQAAAAIAAYagAAAAEAaAthk1lF2oJYvfJ8MQEbYXwWqEszUrKQcTy3OcKDIDcdQz6IjM9m4Q95D69rNnTQ==", "668ad492-ab5f-4c1b-8b9f-f8767b9ef078" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1406cb75-7430-491d-a75b-dfbc93a885c1", "AQAAAAIAAYagAAAAEI9Pz+omoYr9/JtTaEjgP5ICmPpLMfmdogWE0LhIY47RLvET0EMRASZqBvdUC5GKiA==", "ec3374a8-b96c-49b7-b370-226267275b46" });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1,
                column: "RestImage",
                value: null);

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 2,
                column: "RestImage",
                value: null);
        }
    }
}
