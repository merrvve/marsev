using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace marsev.Migrations
{
    /// <inheritdoc />
    public partial class kayitkursodeme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Odeme",
                table: "Kayitlar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "$2a$11$EV28.s3WeAst3.6tNUvddODe0uYgSycf7F7GmHcnJauZAeUbRePji");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "$2a$11$JHOroG7JLcwf.8VXDkNzle2gdyy/nXyhQfe452dngg07niCLW3/3W");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Odeme",
                table: "Kayitlar");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "$2a$11$y3zNygj5V1vtbb//FPu7SuqbOnf5kItSzQgVibqciVbe.C6vZjmiq");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "$2a$11$HMs3Euj8goPriZGhK5.MfOjcFqxcThrR4HW/p/v/WnqaSOdE3ulT2");
        }
    }
}
