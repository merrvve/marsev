using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace marsev.Migrations
{
    /// <inheritdoc />
    public partial class beforeUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "$2a$11$sAJHMG5j2Y2zrbtJm5TxFuc4gi7Wvqn/bab7FOmk10d67xwIYVzW6");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "$2a$11$diPw0DDjlb5hKWbwW96UUemyvRmGKe1O9LueFUuZIdVQfDsufWhzO");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
