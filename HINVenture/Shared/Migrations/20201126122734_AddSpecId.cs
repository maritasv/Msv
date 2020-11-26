using Microsoft.EntityFrameworkCore.Migrations;

namespace HINVenture.Shared.Migrations
{
    public partial class AddSpecId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Specialities_SpecialityId",
                table: "Orders");

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

            migrationBuilder.AlterColumn<int>(
                name: "SpecialityId",
                table: "Orders",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Specialities_SpecialityId",
                table: "Orders",
                column: "SpecialityId",
                principalTable: "Specialities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Specialities_SpecialityId",
                table: "Orders");

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

            migrationBuilder.AlterColumn<int>(
                name: "SpecialityId",
                table: "Orders",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

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

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Specialities_SpecialityId",
                table: "Orders",
                column: "SpecialityId",
                principalTable: "Specialities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
