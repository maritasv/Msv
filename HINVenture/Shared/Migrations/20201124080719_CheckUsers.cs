using Microsoft.EntityFrameworkCore.Migrations;

namespace HINVenture.Shared.Migrations
{
    public partial class CheckUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerUser_AspNetUsers_Id",
                table: "CustomerUser");

            migrationBuilder.DropForeignKey(
                name: "FK_FreelancerUser_AspNetUsers_Id",
                table: "FreelancerUser");

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

            migrationBuilder.DropPrimaryKey(
                name: "PK_FreelancerUser",
                table: "FreelancerUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomerUser",
                table: "CustomerUser");

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

            migrationBuilder.RenameTable(
                name: "FreelancerUser",
                newName: "FreelancerUsers");

            migrationBuilder.RenameTable(
                name: "CustomerUser",
                newName: "CustomerUsers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FreelancerUsers",
                table: "FreelancerUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomerUsers",
                table: "CustomerUsers",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5d763f81-c499-44d8-a3a4-6a90e5c34eb3", "37619d5b-4696-4260-8c7e-aa637acae354", "freelancer", "FREELANCER" },
                    { "dec2fab1-a4ca-4812-88af-ab42edb26ad4", "94bdf15b-34b3-4954-a2c9-54b99ecfe346", "customer", "CUSTOMER" },
                    { "ec41838d-388f-4ef3-a866-e874adf1ec28", "ba3d09f8-d363-41aa-83b3-338580887572", "senior", "SENIOR" },
                    { "296d8d9b-3dd9-437a-b649-a04b713db08f", "5d7faf6d-b163-4b61-896d-b311a25885d3", "admin", "ADMIN" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerUsers_AspNetUsers_Id",
                table: "CustomerUsers",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FreelancerUsers_AspNetUsers_Id",
                table: "FreelancerUsers",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_CustomerUsers_CustomerId",
                table: "Messages",
                column: "CustomerId",
                principalTable: "CustomerUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_FreelancerUsers_FreelancerId",
                table: "Messages",
                column: "FreelancerId",
                principalTable: "FreelancerUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderProgresses_FreelancerUsers_FreelancerId",
                table: "OrderProgresses",
                column: "FreelancerId",
                principalTable: "FreelancerUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_FreelancerUsers_CurrentFreelancerId",
                table: "Orders",
                column: "CurrentFreelancerId",
                principalTable: "FreelancerUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_CustomerUsers_CustomerId",
                table: "Orders",
                column: "CustomerId",
                principalTable: "CustomerUsers",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerUsers_AspNetUsers_Id",
                table: "CustomerUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_FreelancerUsers_AspNetUsers_Id",
                table: "FreelancerUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_CustomerUsers_CustomerId",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_FreelancerUsers_FreelancerId",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderProgresses_FreelancerUsers_FreelancerId",
                table: "OrderProgresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_FreelancerUsers_CurrentFreelancerId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_CustomerUsers_CustomerId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Specialities_FreelancerUsers_FreelancerUserId",
                table: "Specialities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FreelancerUsers",
                table: "FreelancerUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomerUsers",
                table: "CustomerUsers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "296d8d9b-3dd9-437a-b649-a04b713db08f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d763f81-c499-44d8-a3a4-6a90e5c34eb3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dec2fab1-a4ca-4812-88af-ab42edb26ad4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ec41838d-388f-4ef3-a866-e874adf1ec28");

            migrationBuilder.RenameTable(
                name: "FreelancerUsers",
                newName: "FreelancerUser");

            migrationBuilder.RenameTable(
                name: "CustomerUsers",
                newName: "CustomerUser");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FreelancerUser",
                table: "FreelancerUser",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomerUser",
                table: "CustomerUser",
                column: "Id");

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
                name: "FK_CustomerUser_AspNetUsers_Id",
                table: "CustomerUser",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FreelancerUser_AspNetUsers_Id",
                table: "FreelancerUser",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
    }
}
