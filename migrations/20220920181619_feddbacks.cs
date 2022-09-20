using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace masroufiServer.migrations
{
    /// <inheritdoc />
    public partial class feddbacks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b2e6658-6dfc-47fc-8f14-61b33b1e7704", "AQAAAAEAACcQAAAAEBDFm3sXlmNyWurkYU7QQlzWoKiW2Ql6OaOPrY81ga7LLSY2F7ELwnICc09iT3W2/Q==", "8369e36c-37f1-4aa1-9653-7f3b141c6494" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31bb2779-9d89-4dd2-b156-08e697f3d4a2", "AQAAAAEAACcQAAAAEAliU+WUO9CB8gNDBCcw5Gqom91JwQi52wsfvuaMLzpSZ6v3VvB9+V+gMZ7Ui/WWHQ==", "a66ec182-bfd9-4e6a-9380-93662896f874" });
        }
    }
}
