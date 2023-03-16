using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PRScapstone.Migrations
{
    public partial class changedsomeparamstonullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_RequestLines_RequestLineId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Requests_RequestLines_RequestLineId",
                table: "Requests");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Requests_RequestId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Vendors_Products_ProductId",
                table: "Vendors");

            migrationBuilder.DropIndex(
                name: "IX_Vendors_ProductId",
                table: "Vendors");

            migrationBuilder.DropIndex(
                name: "IX_Users_RequestId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Requests_RequestLineId",
                table: "Requests");

            migrationBuilder.DropIndex(
                name: "IX_Products_RequestLineId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Vendors");

            migrationBuilder.DropColumn(
                name: "RequestId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "RequestLineId",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "RequestLineId",
                table: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Vendors",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldMaxLength: 12);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Vendors",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "RejectionReason",
                table: "Requests",
                type: "nvarchar(80)",
                maxLength: 80,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(80)",
                oldMaxLength: 80);

            migrationBuilder.AlterColumn<string>(
                name: "PhotoPath",
                table: "Products",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.CreateIndex(
                name: "IX_Requests_UserId",
                table: "Requests",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestLines_ProductId",
                table: "RequestLines",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestLines_RequestId",
                table: "RequestLines",
                column: "RequestId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_VendorId",
                table: "Products",
                column: "VendorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Vendors_VendorId",
                table: "Products",
                column: "VendorId",
                principalTable: "Vendors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RequestLines_Products_ProductId",
                table: "RequestLines",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RequestLines_Requests_RequestId",
                table: "RequestLines",
                column: "RequestId",
                principalTable: "Requests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_Users_UserId",
                table: "Requests",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Vendors_VendorId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_RequestLines_Products_ProductId",
                table: "RequestLines");

            migrationBuilder.DropForeignKey(
                name: "FK_RequestLines_Requests_RequestId",
                table: "RequestLines");

            migrationBuilder.DropForeignKey(
                name: "FK_Requests_Users_UserId",
                table: "Requests");

            migrationBuilder.DropIndex(
                name: "IX_Requests_UserId",
                table: "Requests");

            migrationBuilder.DropIndex(
                name: "IX_RequestLines_ProductId",
                table: "RequestLines");

            migrationBuilder.DropIndex(
                name: "IX_RequestLines_RequestId",
                table: "RequestLines");

            migrationBuilder.DropIndex(
                name: "IX_Products_VendorId",
                table: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Vendors",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldMaxLength: 12,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Vendors",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Vendors",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RequestId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RejectionReason",
                table: "Requests",
                type: "nvarchar(80)",
                maxLength: 80,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(80)",
                oldMaxLength: 80,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RequestLineId",
                table: "Requests",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PhotoPath",
                table: "Products",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RequestLineId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vendors_ProductId",
                table: "Vendors",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RequestId",
                table: "Users",
                column: "RequestId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_RequestLineId",
                table: "Requests",
                column: "RequestLineId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_RequestLineId",
                table: "Products",
                column: "RequestLineId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_RequestLines_RequestLineId",
                table: "Products",
                column: "RequestLineId",
                principalTable: "RequestLines",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_RequestLines_RequestLineId",
                table: "Requests",
                column: "RequestLineId",
                principalTable: "RequestLines",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Requests_RequestId",
                table: "Users",
                column: "RequestId",
                principalTable: "Requests",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vendors_Products_ProductId",
                table: "Vendors",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");
        }
    }
}
