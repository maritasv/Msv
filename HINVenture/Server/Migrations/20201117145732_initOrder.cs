using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HINVenture.Server.Migrations
{
    public partial class initOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "SpecialityId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Rate",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostedDate = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    CustomerId = table.Column<string>(nullable: true),
                    CurrentFreelancerId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_CurrentFreelancerId",
                        column: x => x.CurrentFreelancerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Message",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(nullable: true),
                    CustomerId = table.Column<string>(nullable: true),
                    FreelancerId = table.Column<string>(nullable: true),
                    PostedDate = table.Column<DateTime>(nullable: false),
                    Text = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Message", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Message_AspNetUsers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Message_AspNetUsers_FreelancerId",
                        column: x => x.FreelancerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Message_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderProgress",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(nullable: true),
                    ReadyLine = table.Column<int>(nullable: false),
                    FreelancerId = table.Column<string>(nullable: true),
                    Month = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderProgress", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderProgress_AspNetUsers_FreelancerId",
                        column: x => x.FreelancerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderProgress_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Speciality",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    FreelancerUserId = table.Column<string>(nullable: true),
                    OrderId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speciality", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Speciality_AspNetUsers_FreelancerUserId",
                        column: x => x.FreelancerUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Speciality_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7b6ae83f-7415-4019-a968-91996ffeefd8", "ba81feef-316b-4928-a2cb-42b4f47bcee2", "freelancer", "FREELANCER" },
                    { "b770cad3-db85-4f3c-acf3-fe485a6a7af5", "4c029cf0-e5ea-4535-93f7-ecead879baa7", "customer", "CUSTOMER" },
                    { "0c50926f-a218-40e5-ba80-21d0062f3072", "c77250b6-cca3-4a07-83f3-ceb4a8faeeb3", "senior", "SENIOR" },
                    { "3a299381-a50c-4c71-a350-006050077585", "7a9f45b8-e3c0-4c90-bd5c-ccef38393fb4", "admin", "ADMIN" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_SpecialityId",
                table: "AspNetUsers",
                column: "SpecialityId");

            migrationBuilder.CreateIndex(
                name: "IX_Message_CustomerId",
                table: "Message",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Message_FreelancerId",
                table: "Message",
                column: "FreelancerId");

            migrationBuilder.CreateIndex(
                name: "IX_Message_OrderId",
                table: "Message",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProgress_FreelancerId",
                table: "OrderProgress",
                column: "FreelancerId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProgress_OrderId",
                table: "OrderProgress",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CurrentFreelancerId",
                table: "Orders",
                column: "CurrentFreelancerId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Speciality_FreelancerUserId",
                table: "Speciality",
                column: "FreelancerUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Speciality_OrderId",
                table: "Speciality",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Speciality_SpecialityId",
                table: "AspNetUsers",
                column: "SpecialityId",
                principalTable: "Speciality",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Speciality_SpecialityId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Message");

            migrationBuilder.DropTable(
                name: "OrderProgress");

            migrationBuilder.DropTable(
                name: "Speciality");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_SpecialityId",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c50926f-a218-40e5-ba80-21d0062f3072");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a299381-a50c-4c71-a350-006050077585");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7b6ae83f-7415-4019-a968-91996ffeefd8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b770cad3-db85-4f3c-acf3-fe485a6a7af5");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SpecialityId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Rate",
                table: "AspNetUsers");

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
    }
}
