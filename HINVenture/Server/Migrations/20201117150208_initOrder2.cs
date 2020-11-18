using Microsoft.EntityFrameworkCore.Migrations;

namespace HINVenture.Server.Migrations
{
    public partial class initOrder2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c50926f-a218-40e5-ba80-21d0062f3072");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a299381-a50c-4c71-a350-006050077585");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7b6ae83f-7415-4019-a968-91996ffeefd8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b770cad3-db85-4f3c-acf3-fe485a6a7af5");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Orders",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "beeb2c8f-12e1-437b-81c3-650f0534e6f6", "ce0ce0ea-f467-4eff-a5a4-3e0b64b22da5", "freelancer", "FREELANCER" },
                    { "9025f0a5-2ccc-4698-9918-1dd64fc1845f", "10cc3a5a-9798-4ad9-affb-c558c52f4230", "customer", "CUSTOMER" },
                    { "21b38a54-8ffe-4d2a-ae9b-cb319849d8eb", "2509fb65-1a0d-4722-8e15-e3dc897216b2", "senior", "SENIOR" },
                    { "b978c86f-f9f7-434f-8aac-2ad78b7a93b1", "d1287b77-b839-4846-88ba-856bf8f46e7c", "admin", "ADMIN" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "21b38a54-8ffe-4d2a-ae9b-cb319849d8eb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9025f0a5-2ccc-4698-9918-1dd64fc1845f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b978c86f-f9f7-434f-8aac-2ad78b7a93b1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "beeb2c8f-12e1-437b-81c3-650f0534e6f6");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Orders");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7b6ae83f-7415-4019-a968-91996ffeefd8", "ba81feef-316b-4928-a2cb-42b4f47bcee2", "freelancer", "FREELANCER" },
                    { "b770cad3-db85-4f3c-acf3-fe485a6a7af5", "4c029cf0-e5ea-4535-93f7-ecead879baa7", "customer", "CUSTOMER" },
                    { "0c50926f-a218-40e5-ba80-21d0062f3072", "c77250b6-cca3-4a07-83f3-ceb4a8faeeb3", "senior", "SENIOR" },
                    { "3a299381-a50c-4c71-a350-006050077585", "7a9f45b8-e3c0-4c90-bd5c-ccef38393fb4", "admin", "ADMIN" }
                });
        }
    }
}
