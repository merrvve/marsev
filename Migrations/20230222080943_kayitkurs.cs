using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace marsev.Migrations
{
    /// <inheritdoc />
    public partial class kayitkurs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "kursId",
                table: "Kayitlar");

            migrationBuilder.AddColumn<string>(
                name: "Kurs",
                table: "Kayitlar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Kurs",
                table: "Kayitlar");

            migrationBuilder.AddColumn<int>(
                name: "kursId",
                table: "Kayitlar",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "$2a$11$TL8s62Ik3JvkVWYCeku.r.hCFAJBqmP3Xa3vIHOCA.MXC0N9KfNSO");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "$2a$11$vD4fm/e4l4tPSBALv1EVa.li5PwbdeWyBlnJKgpLo0pul1nKjRz4y");
        }
    }
}
