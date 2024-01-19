using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FullSD_Project_FoodCapybara.Server.Migrations
{
    /// <inheritdoc />
    public partial class Edited_FoodsController : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3700efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fc32e169-bdc1-4d01-a561-3ea16c12a886", "AQAAAAIAAYagAAAAEGl9zl4LHDv3fwveOVOa1P1dPOHuiErquz9vSPcMK94yV2eGDwXoE3N400IVnvxwTA==", "ffa53d74-f7b1-4487-9f4f-5a5d193a2f55" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4a1b9010-46b6-4ecd-b5f2-c9bb67e4d663", "AQAAAAIAAYagAAAAELxG852va/CQuU3QG1VzT4RwFvCjzHNHBCL1nwO3YgFGSTWLL21LAbtH+vT0+TFHRA==", "1e51f464-01b8-47ce-abcd-f4dd2b7b7f78" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
