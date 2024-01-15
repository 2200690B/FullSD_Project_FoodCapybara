using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FullSD_Project_FoodCapybara.Server.Migrations
{
    /// <inheritdoc />
    public partial class DataSeedingFood : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3700efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d2f0c1b1-2780-4311-bb6e-d53f695efb25", "AQAAAAIAAYagAAAAELBDBnZPb2B6AgyfTJQ4ruMEw77xP1ABgzFuu4sJB+2TaIoxUF3kCTvHSw2y0Z/dMw==", "b24a33f6-81d9-44ce-9703-e400a3b7b79c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "211c4243-ba2b-4881-8e1f-ae8cdfde2cb8", "AQAAAAIAAYagAAAAEIxiZ7AooMvxYuOs50Ipj2HUeFjcU5j1m38H61lNbim3Ae0JzirTcd4aHnzR7lhTRg==", "793aaa68-6766-4065-91d7-7dd08ab5f9a9" });
        }
    }
}
