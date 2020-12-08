using Microsoft.EntityFrameworkCore.Migrations;

namespace HINVenture.Shared.Migrations
{
    public partial class CheckAfterMerge : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "FreelancerSpeciality");

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

            //migrationBuilder.AddColumn<int>(
            //    name: "SpecsId",
            //    table: "FreelancerUsers",
            //    nullable: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_FreelancerUsers_SpecsId",
            //    table: "FreelancerUsers",
            //    column: "SpecsId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_FreelancerUsers_Specialities_SpecsId",
            //    table: "FreelancerUsers",
            //    column: "SpecsId",
            //    principalTable: "Specialities",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FreelancerUsers_Specialities_SpecsId",
                table: "FreelancerUsers");

            migrationBuilder.DropIndex(
                name: "IX_FreelancerUsers_SpecsId",
                table: "FreelancerUsers");

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
                    { "24e565e1-18d0-4738-aac0-834a2c974397", "10b5aba8-9c42-4059-90f2-96e09e4116e8", "freelancer", "FREELANCER" },
                    { "a334e068-73c4-4a5d-b697-f3a6c819093d", "47b524c3-6fa3-4de3-b03c-6fac2aa20b89", "customer", "CUSTOMER" },
                    { "477d180e-63df-4b44-be1c-6aad5a90f5a1", "6d6adc92-bdda-48e1-83c6-1632d123d131", "senior", "SENIOR" },
                    { "11e00184-1356-42c8-9fd2-c0a4c96e8409", "cff71e52-350e-442f-a198-e781dcf053f9", "admin", "ADMIN" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FreelancerSpeciality_SpecialityId",
                table: "FreelancerSpeciality",
                column: "SpecialityId");
        }
    }
}
