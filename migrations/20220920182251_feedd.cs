using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace masroufiServer.migrations
{
    /// <inheritdoc />
    public partial class feedd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0697924e-c333-4605-be45-ffc24f1d16d3", "AQAAAAEAACcQAAAAENXA69txhLc3eJL3AXmC9TmY+RfSrSrypN3WjEF5nvkUSx5DNUWlrSdZx7l3tAgkAQ==", "beae564c-d6e0-49bd-b722-c4983933f8e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b2e6658-6dfc-47fc-8f14-61b33b1e7704", "AQAAAAEAACcQAAAAEBDFm3sXlmNyWurkYU7QQlzWoKiW2Ql6OaOPrY81ga7LLSY2F7ELwnICc09iT3W2/Q==", "8369e36c-37f1-4aa1-9653-7f3b141c6494" });
        }
    }
}
