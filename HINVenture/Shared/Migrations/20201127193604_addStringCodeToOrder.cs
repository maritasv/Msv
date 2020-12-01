using Microsoft.EntityFrameworkCore.Migrations;

namespace HINVenture.Shared.Migrations
{
    public partial class addStringCodeToOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11afdd1e-e41a-45cd-88c2-1955dc8e078e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2016baca-0f5f-4ff1-8411-4cd5f269ba0c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d2667a3-7f1a-46b4-9639-35c8f3060b63");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "697efaf1-c647-4cfa-8e95-17900ee73cb6");

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Orders",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Code",
                table: "Orders");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "11afdd1e-e41a-45cd-88c2-1955dc8e078e", "fe410b3e-ace1-46fc-9267-291d4d33febc", "freelancer", "FREELANCER" },
                    { "697efaf1-c647-4cfa-8e95-17900ee73cb6", "bc5d63c5-56b6-4aee-af47-8cd9eacbfe76", "customer", "CUSTOMER" },
                    { "2016baca-0f5f-4ff1-8411-4cd5f269ba0c", "d7a86d5d-8420-4968-8715-2d4fe4f63af9", "senior", "SENIOR" },
                    { "5d2667a3-7f1a-46b4-9639-35c8f3060b63", "905f5b39-4f76-4b6b-a2d2-92ec97e8cf40", "admin", "ADMIN" }
                });
        }
    }
}
