using Microsoft.EntityFrameworkCore.Migrations;

namespace AuthDemo.Migrations
{
    public partial class RolesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "5e188d3e-73f3-4eb2-80be-a5056755c7f8");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "8714f2cc-5a3d-4e12-a08f-9ce1a69bb3b3");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "5e188d3e-73f3-4eb2-80be-a5056755c7f8", "5e8e02fc-5e63-47af-80d1-905f856c9614", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8714f2cc-5a3d-4e12-a08f-9ce1a69bb3b3", "139432e1-f5f5-4614-a8da-6829fda7c2b8", "Administrator", "ADMINISTRATOR" });
        }
    }
}
