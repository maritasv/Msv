using Microsoft.EntityFrameworkCore.Migrations;

namespace HINVenture.Shared.Migrations
{
    public partial class SeedSpeciality : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "18da1629-18ab-4c92-b736-f952b4ac6359");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "92518b39-cc15-4878-9a1f-6060df6f758e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c9623da8-551a-42a5-bc21-9c6680140020");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca3a6e54-ac5b-4ce7-8336-d85913815e99");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c8d7fab2-b03d-475c-9147-abbcd9474c96", "44c1f2be-1f0c-41fb-b9bb-0b1dd8f6af6c", "freelancer", "FREELANCER" },
                    { "f997dccf-be5d-4a03-b002-38970c2bb26d", "a7b21195-105f-45d3-a9e3-a02b29a55277", "customer", "CUSTOMER" },
                    { "9a58f9ca-6596-4051-8362-990f8adbd64e", "e9216aac-3749-4f79-bbc9-c2d6b19ec055", "senior", "SENIOR" },
                    { "1a75d2fa-b4d5-46aa-8377-f04c7047f3a0", "3bd93291-7d0a-4216-8536-b335888c801f", "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Specialities",
                columns: new[] { "Id", "FreelancerUserId", "Name", "OrderId" },
                values: new object[,]
                {
                    { 1, null, "C# developer", null },
                    { 2, null, "Python developer", null },
                    { 3, null, "Java developer", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a75d2fa-b4d5-46aa-8377-f04c7047f3a0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9a58f9ca-6596-4051-8362-990f8adbd64e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c8d7fab2-b03d-475c-9147-abbcd9474c96");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f997dccf-be5d-4a03-b002-38970c2bb26d");

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c9623da8-551a-42a5-bc21-9c6680140020", "5b620022-4d88-49a4-ba02-375e4c1bca02", "freelancer", "FREELANCER" },
                    { "18da1629-18ab-4c92-b736-f952b4ac6359", "f9805e9b-6567-4f28-98b6-041d6b1c1cf3", "customer", "CUSTOMER" },
                    { "ca3a6e54-ac5b-4ce7-8336-d85913815e99", "e826d3d8-8142-4b58-8b6b-81b7e1ef7266", "senior", "SENIOR" },
                    { "92518b39-cc15-4878-9a1f-6060df6f758e", "81448651-243b-4042-b930-1e68bdb18427", "admin", "ADMIN" }
                });
        }
    }
}
