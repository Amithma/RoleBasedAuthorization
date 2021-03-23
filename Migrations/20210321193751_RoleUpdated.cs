using Microsoft.EntityFrameworkCore.Migrations;

namespace AuthDemo.Migrations
{
    public partial class RoleUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "04dd4381-d33f-463f-869f-c2390ee23c38");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "7b441899-27b6-44dc-8268-443b72edba15");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "cfa46b07-ff94-4c44-a11c-27af5a0b5bcc");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cfa46b07-ff94-4c44-a11c-27af5a0b5bcc", "dc328671-13a1-4c51-a37a-5091ee482f04", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7b441899-27b6-44dc-8268-443b72edba15", "21f4f2bf-f95b-4279-be6c-afb11592679c", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "04dd4381-d33f-463f-869f-c2390ee23c38", "0f30a495-d0df-4002-be9b-e3b06e86f312", "Lecturer", "LECTURER" });
        }
    }
}
