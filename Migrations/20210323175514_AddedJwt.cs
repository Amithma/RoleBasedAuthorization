using Microsoft.EntityFrameworkCore.Migrations;

namespace AuthDemo.Migrations
{
    public partial class AddedJwt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "37adf1e6-1ddf-49c0-aa3e-1553c192a701");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "8edb1a37-f052-45f0-a7e0-d363a68405f2");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "ffe58e61-617a-4885-a947-7ecc54309c7d");

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Users",
                nullable: true);

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "80a1b83c-4588-4ea7-96c0-4c20d2633bec", "d0891d6e-4c22-4e07-bf1c-b8c57703132e", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "98cb4802-c035-4ff9-8690-5b3d2d038a77", "9ac47b61-8afc-4d89-a8e4-7cedc1ec28ef", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "52e6fb0e-83e0-48dd-a14c-de55ea98ab2a", "3ede748c-07d0-45d0-b8ab-379e8f5feeca", "Lecturer", "LECTURER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "52e6fb0e-83e0-48dd-a14c-de55ea98ab2a");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "80a1b83c-4588-4ea7-96c0-4c20d2633bec");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "98cb4802-c035-4ff9-8690-5b3d2d038a77");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "Users");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8edb1a37-f052-45f0-a7e0-d363a68405f2", "dbfe3b96-690e-4308-9782-d4bc0da5b44c", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "37adf1e6-1ddf-49c0-aa3e-1553c192a701", "9006c22c-4859-4538-9764-b538ad61b31d", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ffe58e61-617a-4885-a947-7ecc54309c7d", "b148ba18-0da1-4d8f-b069-ce166fed6aa7", "Lecturer", "LECTURER" });
        }
    }
}
