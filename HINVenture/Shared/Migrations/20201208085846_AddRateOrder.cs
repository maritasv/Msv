using Microsoft.EntityFrameworkCore.Migrations;

namespace HINVenture.Shared.Migrations
{
    public partial class AddRateOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a14b865-87c1-4036-8460-2345ab29409a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "41f83b71-f1d8-497c-b41a-97f0a91ed41d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6cae1a7b-56f1-4903-8049-e75b789a4aee");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "80014153-0d2c-4514-966d-46283fc9b0e4");

            migrationBuilder.AddColumn<int>(
                name: "Rate",
                table: "Orders",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "24e565e1-18d0-4738-aac0-834a2c974397", "10b5aba8-9c42-4059-90f2-96e09e4116e8", "freelancer", "FREELANCER" },
                    { "a334e068-73c4-4a5d-b697-f3a6c819093d", "47b524c3-6fa3-4de3-b03c-6fac2aa20b89", "customer", "CUSTOMER" },
                    { "477d180e-63df-4b44-be1c-6aad5a90f5a1", "6d6adc92-bdda-48e1-83c6-1632d123d131", "senior", "SENIOR" },
                    { "11e00184-1356-42c8-9fd2-c0a4c96e8409", "cff71e52-350e-442f-a198-e781dcf053f9", "admin", "ADMIN" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11e00184-1356-42c8-9fd2-c0a4c96e8409");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "24e565e1-18d0-4738-aac0-834a2c974397");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "477d180e-63df-4b44-be1c-6aad5a90f5a1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a334e068-73c4-4a5d-b697-f3a6c819093d");

            migrationBuilder.DropColumn(
                name: "Rate",
                table: "Orders");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "80014153-0d2c-4514-966d-46283fc9b0e4", "52ea3da8-1f66-4d41-99bd-3c22600e084c", "freelancer", "FREELANCER" },
                    { "3a14b865-87c1-4036-8460-2345ab29409a", "d3ea0491-4c94-4edb-a13a-6609063a901e", "customer", "CUSTOMER" },
                    { "41f83b71-f1d8-497c-b41a-97f0a91ed41d", "f911da70-f646-48b8-a044-1f94453463bd", "senior", "SENIOR" },
                    { "6cae1a7b-56f1-4903-8049-e75b789a4aee", "df73013d-fd04-497c-9dfe-581483864d69", "admin", "ADMIN" }
                });
        }
    }
}
