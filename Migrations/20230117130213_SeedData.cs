using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace marsev.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Name", "Password", "Role", "UserName" },
                values: new object[,]
                {
                    { 1, null, "$2a$11$ULl5mtierBvnonIzxs4Etu5ynyomKMwpRVQsQfWZdddKBGQ.i4AOy", 1, "admin" },
                    { 2, null, "$2a$11$tE2a.0MGl0hTArxpBgFMsORVE3eTydhHKnGjRiBxq.AZ1hiTpbrxG", 2, "merve" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
