using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace marsev.Migrations
{
    /// <inheritdoc />
    public partial class kayit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
