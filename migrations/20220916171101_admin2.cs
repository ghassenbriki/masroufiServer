using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace masroufiServer.migrations
{
    /// <inheritdoc />
    public partial class admin2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "35f1d0d4-f6e1-444c-ab65-af5d819e9541", "admin", "AQAAAAEAACcQAAAAEN93TzUiAC2sxWRTaZuuoL6ZCnCiexaeDTmQIP1EXgCa6Kec++pNCTynVBU14A3Rhg==", "c59f8729-0b87-4787-a1d5-974ac0b966a2" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1a6b10bc-4c44-4612-87d6-bd6406c729b3", null, "AQAAAAEAACcQAAAAEDducIUy3MQ9cedGwgNub6GqVpFGv7T4SVHWa/aJEtGJhgkxlQM7So9H9zieEvX7cw==", "3d6f2666-6cce-492b-90b7-c8a51aab64d2" });
        }
    }
}
