using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace masroufiServer.migrations
{
    /// <inheritdoc />
    public partial class lasttt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31bb2779-9d89-4dd2-b156-08e697f3d4a2", "AQAAAAEAACcQAAAAEAliU+WUO9CB8gNDBCcw5Gqom91JwQi52wsfvuaMLzpSZ6v3VvB9+V+gMZ7Ui/WWHQ==", "a66ec182-bfd9-4e6a-9380-93662896f874" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "20cf2db0-95d7-4069-8ab1-5dbc9296af09", "AQAAAAEAACcQAAAAEETFL5kI3rPB6AJYfpT1a8CFufJrFAyrOwz2liY38Uh2Y+TM/yViJ5uz4hOJWBmDYg==", "63e3e5ef-b0bd-44e4-9cdc-b7a34f216f3d" });
        }
    }
}
