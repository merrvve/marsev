using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace marsev.Migrations
{
    /// <inheritdoc />
    public partial class BaseAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Kitaplar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Etkinlikler",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Kitaplar");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Etkinlikler");
        }
    }
}
