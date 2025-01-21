using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsApp2.Migrations
{
    /// <inheritdoc />
    public partial class AddOwnerPhoneAndProductAddress : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OwnerPhone",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ProductAddress",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OwnerPhone",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductAddress",
                table: "Products");
        }
    }
}
