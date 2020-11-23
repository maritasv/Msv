using Microsoft.EntityFrameworkCore.Migrations;

namespace HINVenture.Shared.Migrations
{
    public partial class AddOneToOneUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_AspNetUsers_CustomerId",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_AspNetUsers_FreelancerId",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderProgresses_AspNetUsers_FreelancerId",
                table: "OrderProgresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_CurrentFreelancerId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_CustomerId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Specialities_AspNetUsers_FreelancerUserId",
                table: "Specialities");

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

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Rate",
                table: "AspNetUsers");

            migrationBuilder.CreateTable(
                name: "CustomerUser",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerUser_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FreelancerUser",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Rate = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FreelancerUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FreelancerUser_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3e1494ad-f065-4802-8b47-9b1e17471ec7", "2636887f-9bb8-4b72-8d2e-c8af95551b1a", "freelancer", "FREELANCER" },
                    { "0d046923-6890-4e2a-a29d-7cdc44e2dd1e", "0b47c6b5-592c-4642-b01e-516a763d99cb", "customer", "CUSTOMER" },
                    { "56f5e664-821e-4793-b0a0-63a33b1de6f8", "9575aacd-68c1-47dd-9eee-05a0ee088e72", "senior", "SENIOR" },
                    { "0b11086a-dac7-43a3-9eb8-b43242da8f69", "1c6a7bca-a0db-47be-b955-cea53c8bc34a", "admin", "ADMIN" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_CustomerUser_CustomerId",
                table: "Messages",
                column: "CustomerId",
                principalTable: "CustomerUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_FreelancerUser_FreelancerId",
                table: "Messages",
                column: "FreelancerId",
                principalTable: "FreelancerUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderProgresses_FreelancerUser_FreelancerId",
                table: "OrderProgresses",
                column: "FreelancerId",
                principalTable: "FreelancerUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_FreelancerUser_CurrentFreelancerId",
                table: "Orders",
                column: "CurrentFreelancerId",
                principalTable: "FreelancerUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_CustomerUser_CustomerId",
                table: "Orders",
                column: "CustomerId",
                principalTable: "CustomerUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Specialities_FreelancerUser_FreelancerUserId",
                table: "Specialities",
                column: "FreelancerUserId",
                principalTable: "FreelancerUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_CustomerUser_CustomerId",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_FreelancerUser_FreelancerId",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderProgresses_FreelancerUser_FreelancerId",
                table: "OrderProgresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_FreelancerUser_CurrentFreelancerId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_CustomerUser_CustomerId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Specialities_FreelancerUser_FreelancerUserId",
                table: "Specialities");

            migrationBuilder.DropTable(
                name: "CustomerUser");

            migrationBuilder.DropTable(
                name: "FreelancerUser");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0b11086a-dac7-43a3-9eb8-b43242da8f69");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0d046923-6890-4e2a-a29d-7cdc44e2dd1e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e1494ad-f065-4802-8b47-9b1e17471ec7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "56f5e664-821e-4793-b0a0-63a33b1de6f8");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "AspNetUsers",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Rate",
                table: "AspNetUsers",
                type: "real",
                nullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_AspNetUsers_CustomerId",
                table: "Messages",
                column: "CustomerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_AspNetUsers_FreelancerId",
                table: "Messages",
                column: "FreelancerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderProgresses_AspNetUsers_FreelancerId",
                table: "OrderProgresses",
                column: "FreelancerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_CurrentFreelancerId",
                table: "Orders",
                column: "CurrentFreelancerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_CustomerId",
                table: "Orders",
                column: "CustomerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Specialities_AspNetUsers_FreelancerUserId",
                table: "Specialities",
                column: "FreelancerUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
