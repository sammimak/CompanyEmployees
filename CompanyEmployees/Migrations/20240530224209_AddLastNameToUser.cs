using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyEmployees.Migrations
{
    public partial class AddLastNameToUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1cf5edbb-a6a4-49bf-9b63-c06974643164");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8bf074cf-3b33-46f8-8baf-62e6e23c778e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "26415495-7d32-4ebb-8344-a873289bbe25", "8375bdcb-e4bc-4d97-bb8b-adab127ea306", "Manager", "MANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f250abd3-18dd-4e1b-b43e-c2e81c023c11", "23ef1f10-c287-4279-bd28-a5b5e9780c34", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "26415495-7d32-4ebb-8344-a873289bbe25");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f250abd3-18dd-4e1b-b43e-c2e81c023c11");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1cf5edbb-a6a4-49bf-9b63-c06974643164", "94c4e014-714d-4fc8-b785-5876b1531986", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8bf074cf-3b33-46f8-8baf-62e6e23c778e", "e785044a-6419-46f2-a8cd-f980d2386a63", "Manager", "MANAGER" });
        }
    }
}
