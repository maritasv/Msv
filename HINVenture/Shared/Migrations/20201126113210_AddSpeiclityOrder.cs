using Microsoft.EntityFrameworkCore.Migrations;

namespace HINVenture.Shared.Migrations
{
    public partial class AddSpeiclityOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Specialities_Orders_OrderId",
                table: "Specialities");

            migrationBuilder.DropIndex(
                name: "IX_Specialities_OrderId",
                table: "Specialities");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "abefa3b4-0e1a-4e65-81bb-0e1265162cc5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dfc405a7-3144-41b2-9024-12ec9cadd65f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e7d361b0-cd0b-4e04-9117-6ade97f25f09");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f32eb71d-29fa-4427-b2a7-658d474f29a3");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Specialities");

            migrationBuilder.AddColumn<int>(
                name: "SpecialityId",
                table: "Specialities",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SpecialityId",
                table: "Orders",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "97f9ec04-610a-4bdd-bf40-0782cef598bd", "948450ca-4071-4d48-9bc5-eec5e94f2262", "freelancer", "FREELANCER" },
                    { "1be71d18-8062-4235-8ac3-844dbe990737", "c212d4d2-764a-4dac-bb06-4418706e5b80", "customer", "CUSTOMER" },
                    { "85172014-eb5a-4f35-ac5a-0ac70a16d8b2", "5e442c3a-a935-4034-b3e9-6e4e303a81fb", "senior", "SENIOR" },
                    { "fabc2f2a-b990-4d41-b246-6e4c0615ec8d", "d3c4e26d-849d-4e2a-9cc1-99fca2f5bfba", "admin", "ADMIN" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Specialities_SpecialityId",
                table: "Specialities",
                column: "SpecialityId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_SpecialityId",
                table: "Orders",
                column: "SpecialityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Specialities_SpecialityId",
                table: "Orders",
                column: "SpecialityId",
                principalTable: "Specialities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Specialities_Specialities_SpecialityId",
                table: "Specialities",
                column: "SpecialityId",
                principalTable: "Specialities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Specialities_SpecialityId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Specialities_Specialities_SpecialityId",
                table: "Specialities");

            migrationBuilder.DropIndex(
                name: "IX_Specialities_SpecialityId",
                table: "Specialities");

            migrationBuilder.DropIndex(
                name: "IX_Orders_SpecialityId",
                table: "Orders");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1be71d18-8062-4235-8ac3-844dbe990737");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "85172014-eb5a-4f35-ac5a-0ac70a16d8b2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "97f9ec04-610a-4bdd-bf40-0782cef598bd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fabc2f2a-b990-4d41-b246-6e4c0615ec8d");

            migrationBuilder.DropColumn(
                name: "SpecialityId",
                table: "Specialities");

            migrationBuilder.DropColumn(
                name: "SpecialityId",
                table: "Orders");

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "Specialities",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "abefa3b4-0e1a-4e65-81bb-0e1265162cc5", "dfab55be-2863-4d58-b952-85e9c3e9ad76", "freelancer", "FREELANCER" },
                    { "e7d361b0-cd0b-4e04-9117-6ade97f25f09", "dd17753f-9fca-48b7-8442-2c75c618a276", "customer", "CUSTOMER" },
                    { "dfc405a7-3144-41b2-9024-12ec9cadd65f", "8bc3bf73-0059-40f5-a41e-f7c5558ce22a", "senior", "SENIOR" },
                    { "f32eb71d-29fa-4427-b2a7-658d474f29a3", "14ffb597-4176-45fa-9c89-7a81dcd42618", "admin", "ADMIN" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Specialities_OrderId",
                table: "Specialities",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Specialities_Orders_OrderId",
                table: "Specialities",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
