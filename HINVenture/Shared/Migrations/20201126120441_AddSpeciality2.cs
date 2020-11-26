using Microsoft.EntityFrameworkCore.Migrations;

namespace HINVenture.Shared.Migrations
{
    public partial class AddSpeciality2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Specialities_Specialities_SpecialityId",
                table: "Specialities");

            migrationBuilder.DropIndex(
                name: "IX_Specialities_SpecialityId",
                table: "Specialities");

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1e077bd1-b8b0-4648-ab6f-20c7d0c57ac9", "b43dfcd8-618c-4cd8-b1af-45d78acf1cda", "freelancer", "FREELANCER" },
                    { "1db601f7-5228-42a1-9a2a-5afccaddac9b", "3c178fff-1589-479d-83d4-9e77b5634f63", "customer", "CUSTOMER" },
                    { "18d78bb8-5a54-4e3c-b065-303da9698fbe", "4665f161-9595-444a-b3bd-ac8a0521db75", "senior", "SENIOR" },
                    { "a7912066-eea4-4566-ac68-7c3e61c20fd5", "ef8109f5-93e6-4b6e-acb2-c522dddea42f", "admin", "ADMIN" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "18d78bb8-5a54-4e3c-b065-303da9698fbe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1db601f7-5228-42a1-9a2a-5afccaddac9b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1e077bd1-b8b0-4648-ab6f-20c7d0c57ac9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a7912066-eea4-4566-ac68-7c3e61c20fd5");

            migrationBuilder.AddColumn<int>(
                name: "SpecialityId",
                table: "Specialities",
                type: "int",
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

            migrationBuilder.AddForeignKey(
                name: "FK_Specialities_Specialities_SpecialityId",
                table: "Specialities",
                column: "SpecialityId",
                principalTable: "Specialities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
