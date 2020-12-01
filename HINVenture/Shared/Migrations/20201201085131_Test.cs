using Microsoft.EntityFrameworkCore.Migrations;

namespace HINVenture.Shared.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "27a8b316-2209-4def-aa82-22c2ecbc8dad");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f738d4c6-5bea-40d4-8982-dc5913d66c04");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fecd6dbe-ec30-48fd-8315-856714632cf4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ffd561f9-2f37-4e96-8783-87506647f0e2");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ffd561f9-2f37-4e96-8783-87506647f0e2", "6d8d893e-6103-490f-a3c0-dddef859f860", "freelancer", "FREELANCER" },
                    { "27a8b316-2209-4def-aa82-22c2ecbc8dad", "b691a185-0472-4198-912e-38ba9e29e50b", "customer", "CUSTOMER" },
                    { "fecd6dbe-ec30-48fd-8315-856714632cf4", "62fbe613-d397-4e59-a6ef-6aadaac64731", "senior", "SENIOR" },
                    { "f738d4c6-5bea-40d4-8982-dc5913d66c04", "c03f6a3f-b66a-414c-b301-6e005d9012e6", "admin", "ADMIN" }
                });
        }
    }
}
