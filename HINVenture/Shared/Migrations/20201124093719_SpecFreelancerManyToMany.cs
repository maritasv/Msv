using Microsoft.EntityFrameworkCore.Migrations;

namespace HINVenture.Shared.Migrations
{
    public partial class SpecFreelancerManyToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Specialities_SpecialityId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Specialities_FreelancerUsers_FreelancerUserId",
                table: "Specialities");

            migrationBuilder.DropIndex(
                name: "IX_Specialities_FreelancerUserId",
                table: "Specialities");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_SpecialityId",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3af37fe3-7559-457e-8ce1-071ae39368bf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5bfd6188-bbfd-4863-a2a0-7c0843769599");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b743dd18-e3af-40d0-b7ef-9ccff7cc4a13");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e91a96f5-f669-43ce-b6d5-543c7c7c1f92");

            migrationBuilder.DropColumn(
                name: "FreelancerUserId",
                table: "Specialities");

            migrationBuilder.DropColumn(
                name: "SpecialityId",
                table: "AspNetUsers");

            migrationBuilder.CreateTable(
                name: "FreelancerSpeciality",
                columns: table => new
                {
                    FreelancerUserId = table.Column<string>(nullable: false),
                    SpecialityId = table.Column<int>(nullable: false)
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
                    { "abefa3b4-0e1a-4e65-81bb-0e1265162cc5", "dfab55be-2863-4d58-b952-85e9c3e9ad76", "freelancer", "FREELANCER" },
                    { "e7d361b0-cd0b-4e04-9117-6ade97f25f09", "dd17753f-9fca-48b7-8442-2c75c618a276", "customer", "CUSTOMER" },
                    { "dfc405a7-3144-41b2-9024-12ec9cadd65f", "8bc3bf73-0059-40f5-a41e-f7c5558ce22a", "senior", "SENIOR" },
                    { "f32eb71d-29fa-4427-b2a7-658d474f29a3", "14ffb597-4176-45fa-9c89-7a81dcd42618", "admin", "ADMIN" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FreelancerSpeciality_SpecialityId",
                table: "FreelancerSpeciality",
                column: "SpecialityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FreelancerSpeciality");

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

            migrationBuilder.AddColumn<string>(
                name: "FreelancerUserId",
                table: "Specialities",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SpecialityId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3af37fe3-7559-457e-8ce1-071ae39368bf", "0d7b3978-4a38-4c0f-9ad2-0d3dec531e1a", "freelancer", "FREELANCER" },
                    { "e91a96f5-f669-43ce-b6d5-543c7c7c1f92", "ec2ca425-a67f-4d48-b8b4-0c004f2adcc1", "customer", "CUSTOMER" },
                    { "b743dd18-e3af-40d0-b7ef-9ccff7cc4a13", "b6afc799-d651-4661-9ba6-646c51b3622b", "senior", "SENIOR" },
                    { "5bfd6188-bbfd-4863-a2a0-7c0843769599", "fb7648c5-5eb5-491c-9ce4-a9161af497d4", "admin", "ADMIN" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Specialities_FreelancerUserId",
                table: "Specialities",
                column: "FreelancerUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_SpecialityId",
                table: "AspNetUsers",
                column: "SpecialityId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Specialities_SpecialityId",
                table: "AspNetUsers",
                column: "SpecialityId",
                principalTable: "Specialities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Specialities_FreelancerUsers_FreelancerUserId",
                table: "Specialities",
                column: "FreelancerUserId",
                principalTable: "FreelancerUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
