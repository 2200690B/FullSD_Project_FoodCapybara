using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FullSD_Project_FoodCapybara.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddedNewImageAttribute_ToRestaurantcs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RestImage",
                table: "Restaurants",
                newName: "ImageUrl");

            migrationBuilder.AddColumn<byte[]>(
                name: "FileContent",
                table: "Restaurants",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FileName",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3700efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa3064ab-0c2c-4e4e-ae8f-7821e40d31b6", "AQAAAAIAAYagAAAAEOF7yjOlteCz9oeqgGEEJ4JMcrmZ5X9T4eXk+hUehzjBMs+clu40O59XvdUGhjPtaw==", "c43aad59-267b-45da-83e4-092a7a01aabf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea6b4015-57d6-4718-be42-4ca6ec9fac86", "AQAAAAIAAYagAAAAECOJhbXs5EDwm/OpzLSxOeXonsTyydR+hWfDq9Qxww37T3pjswUHHefd3U4U/jYBNQ==", "ff2c700c-78cb-4172-854a-fb1803d40e7b" });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FileContent", "FileName", "ImageUrl" },
                values: new object[] { null, "Rest1.png", null });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FileContent", "FileName", "ImageUrl" },
                values: new object[] { null, "Rest2.png", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileContent",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "FileName",
                table: "Restaurants");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Restaurants",
                newName: "RestImage");

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
    }
}
