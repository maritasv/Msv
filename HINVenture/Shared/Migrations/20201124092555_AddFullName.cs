using Microsoft.EntityFrameworkCore.Migrations;

namespace HINVenture.Shared.Migrations
{
    public partial class AddFullName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "296d8d9b-3dd9-437a-b649-a04b713db08f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d763f81-c499-44d8-a3a4-6a90e5c34eb3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dec2fab1-a4ca-4812-88af-ab42edb26ad4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ec41838d-388f-4ef3-a866-e874adf1ec28");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3af37fe3-7559-457e-8ce1-071ae39368bf", "0d7b3978-4a38-4c0f-9ad2-0d3dec531e1a", "freelancer", "FREELANCER" },
                    { "e91a96f5-f669-43ce-b6d5-543c7c7c1f92", "ec2ca425-a67f-4d48-b8b4-0c004f2adcc1", "customer", "CUSTOMER" },
                    { "b743dd18-e3af-40d0-b7ef-9ccff7cc4a13", "b6afc799-d651-4661-9ba6-646c51b3622b", "senior", "SENIOR" },
                    { "5bfd6188-bbfd-4863-a2a0-7c0843769599", "fb7648c5-5eb5-491c-9ce4-a9161af497d4", "admin", "ADMIN" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3af37fe3-7559-457e-8ce1-071ae39368bf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5bfd6188-bbfd-4863-a2a0-7c0843769599");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b743dd18-e3af-40d0-b7ef-9ccff7cc4a13");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e91a96f5-f669-43ce-b6d5-543c7c7c1f92");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5d763f81-c499-44d8-a3a4-6a90e5c34eb3", "37619d5b-4696-4260-8c7e-aa637acae354", "freelancer", "FREELANCER" },
                    { "dec2fab1-a4ca-4812-88af-ab42edb26ad4", "94bdf15b-34b3-4954-a2c9-54b99ecfe346", "customer", "CUSTOMER" },
                    { "ec41838d-388f-4ef3-a866-e874adf1ec28", "ba3d09f8-d363-41aa-83b3-338580887572", "senior", "SENIOR" },
                    { "296d8d9b-3dd9-437a-b649-a04b713db08f", "5d7faf6d-b163-4b61-896d-b311a25885d3", "admin", "ADMIN" }
                });
        }
    }
}
