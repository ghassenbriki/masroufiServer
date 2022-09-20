using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace masroufiServer.migrations
{
    /// <inheritdoc />
    public partial class last : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "20cf2db0-95d7-4069-8ab1-5dbc9296af09", "AQAAAAEAACcQAAAAEETFL5kI3rPB6AJYfpT1a8CFufJrFAyrOwz2liY38Uh2Y+TM/yViJ5uz4hOJWBmDYg==", "63e3e5ef-b0bd-44e4-9cdc-b7a34f216f3d" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9628b0ab-79cf-4057-996a-ab85e3f548e9", "AQAAAAEAACcQAAAAEEu6GX5ns1iPeBHnnCvbHU0ILqWKpJppGniRRdI75OvgNXU8W/oExD9/nNpvgiTj9Q==", "3eb7e3c5-d241-4520-8f69-d27b2489e942" });
        }
    }
}
