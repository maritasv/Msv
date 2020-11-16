using Microsoft.EntityFrameworkCore.Migrations;

namespace HINVenture.Server.Migrations
{
    public partial class addedrolesinregisterlogincontrollers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ee7db7d2-283f-4578-a10d-13c087e16d8f", "7f1f1bd6-a3e6-48d1-ac49-dac598a63532", "freelancer", "FREELANCER" },
                    { "17286a08-c6eb-403a-bc34-40035fb98b69", "58f16e37-40a4-41e3-a9bd-f6b2e4341f62", "customer", "CUSTOMER" },
                    { "850d6d7f-a445-4a0e-a0aa-c572de9ce881", "214dde62-6b92-4af5-96a7-4766d960ba4f", "senior", "SENIOR" },
                    { "4a6652aa-60d8-4b0e-854f-88aeb019f55e", "cdf926c2-54f5-47ec-8e5b-0cfdb54d8ac1", "admin", "ADMIN" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "17286a08-c6eb-403a-bc34-40035fb98b69");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a6652aa-60d8-4b0e-854f-88aeb019f55e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "850d6d7f-a445-4a0e-a0aa-c572de9ce881");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ee7db7d2-283f-4578-a10d-13c087e16d8f");
        }
    }
}
