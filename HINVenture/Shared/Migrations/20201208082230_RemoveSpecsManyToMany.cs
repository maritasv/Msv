using Microsoft.EntityFrameworkCore.Migrations;

namespace HINVenture.Shared.Migrations
{
    public partial class RemoveSpecsManyToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FreelancerSpeciality");

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
                name: "SpecsId",
                table: "FreelancerUsers",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0023cca2-b46b-4ce9-8db6-d4164aa861a2", "5dba768b-e51b-45f1-a578-2ca7ec6688d0", "freelancer", "FREELANCER" },
                    { "948f3daa-ca70-4da1-8275-c827ef8f8ea8", "56be6130-6ece-4d9b-ac95-f78520a2018d", "customer", "CUSTOMER" },
                    { "0df74050-849c-490d-a199-0c34fae739aa", "aecba915-0229-4717-88e9-b3b1ee16932d", "senior", "SENIOR" },
                    { "2017a8a2-929d-429f-bdca-a546c9b743fa", "4558ddb7-d56c-4274-8503-600302dc404b", "admin", "ADMIN" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FreelancerUsers_SpecsId",
                table: "FreelancerUsers",
                column: "SpecsId");

            migrationBuilder.AddForeignKey(
                name: "FK_FreelancerUsers_Specialities_SpecsId",
                table: "FreelancerUsers",
                column: "SpecsId",
                principalTable: "Specialities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FreelancerUsers_Specialities_SpecsId",
                table: "FreelancerUsers");

            migrationBuilder.DropIndex(
                name: "IX_FreelancerUsers_SpecsId",
                table: "FreelancerUsers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0023cca2-b46b-4ce9-8db6-d4164aa861a2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0df74050-849c-490d-a199-0c34fae739aa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2017a8a2-929d-429f-bdca-a546c9b743fa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "948f3daa-ca70-4da1-8275-c827ef8f8ea8");

            migrationBuilder.DropColumn(
                name: "SpecsId",
                table: "FreelancerUsers");

            migrationBuilder.CreateTable(
                name: "FreelancerSpeciality",
                columns: table => new
                {
                    FreelancerUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SpecialityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FreelancerSpeciality", x => new { x.FreelancerUserId, x.SpecialityId });
                    table.ForeignKey(
                        name: "FK_FreelancerSpeciality_FreelancerUsers_FreelancerUserId",
                        column: x => x.FreelancerUserId,
                        principalTable: "FreelancerUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FreelancerSpeciality_Specialities_SpecialityId",
                        column: x => x.SpecialityId,
                        principalTable: "Specialities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_FreelancerSpeciality_SpecialityId",
                table: "FreelancerSpeciality",
                column: "SpecialityId");
        }
    }
}
