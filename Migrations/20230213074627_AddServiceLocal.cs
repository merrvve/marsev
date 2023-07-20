using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace marsev.Migrations
{
    /// <inheritdoc />
    public partial class AddServiceLocal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "$2a$11$NsvlVk2Jer1ljT0AmPUmFeTJMEOEPGvg8gtVQImSMvszMpru9guVm");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "$2a$11$Z4Fuj1VoLPYohNrjJ5YdgOeEy5MTOWkvQMgIHkbyRB3udFVlWuT5q");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "$2a$11$7MbYbnLrjjab37Lhlajziu74WgfYnER7oZQ2MIodIp/TVjZbq6bNm");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "$2a$11$EAU24vKfMTbKyYgt8QYMLeoAXa59z1hpj8m8ys4FuKKu9Tspq.gDm");
        }
    }
}
