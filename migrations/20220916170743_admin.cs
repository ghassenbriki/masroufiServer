using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace masroufiServer.migrations
{
    /// <inheritdoc />
    public partial class admin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1a6b10bc-4c44-4612-87d6-bd6406c729b3", "AQAAAAEAACcQAAAAEDducIUy3MQ9cedGwgNub6GqVpFGv7T4SVHWa/aJEtGJhgkxlQM7So9H9zieEvX7cw==", "3d6f2666-6cce-492b-90b7-c8a51aab64d2" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dca26035-e412-4aca-b99a-a62a57139c9a", "AQAAAAEAACcQAAAAEPVZdtELCync9U9uyrb/TnudA4imzYRklahjxiyFSsMV+yFLI0C9/mTnamubz7vc9Q==", "35768a09-0025-438d-b079-dd88007d9cfe" });
        }
    }
}
