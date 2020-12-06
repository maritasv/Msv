using Microsoft.EntityFrameworkCore.Migrations;

namespace HINVenture.Shared.Migrations
{
    public partial class AddSenderUserName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3feba2d7-66b8-4c36-97ce-39069cb062d6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aa8035ef-792b-4298-a16c-dc8348e7e5be");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7bca109-127d-4296-ab71-8fdb861cfffe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fc911bb2-0d79-4f75-a0f5-d7b8c84338f7");

            migrationBuilder.AddColumn<string>(
                name: "SenderUsername",
                table: "Messages",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "SenderUsername",
                table: "Messages");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "aa8035ef-792b-4298-a16c-dc8348e7e5be", "2ca0066b-3bb5-40b6-aa07-fa7adba40ef4", "freelancer", "FREELANCER" },
                    { "c7bca109-127d-4296-ab71-8fdb861cfffe", "f86c7259-c4eb-4966-a899-c0e104d5079e", "customer", "CUSTOMER" },
                    { "fc911bb2-0d79-4f75-a0f5-d7b8c84338f7", "8e5dca4e-27e0-4d6a-bd83-ba6605155d5a", "senior", "SENIOR" },
                    { "3feba2d7-66b8-4c36-97ce-39069cb062d6", "66fdacf9-cb1d-42c0-acfb-778bfd13ea07", "admin", "ADMIN" }
                });
        }
    }
}
