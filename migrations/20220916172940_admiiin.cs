using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace masroufiServer.migrations
{
    /// <inheritdoc />
    public partial class admiiin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "0c02a863-0bca-4a4a-a315-61e60c98af43", "AQAAAAEAACcQAAAAEOtP6BFb5/TfWlJkEPlRO+OLYvLLaoSQqqvQB3RsdB5BVRt31t9pJNzd9QY5CygMxQ==", "7b43c34c-2da6-4ad7-9b9a-49e5697124ff", "admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "35f1d0d4-f6e1-444c-ab65-af5d819e9541", "AQAAAAEAACcQAAAAEN93TzUiAC2sxWRTaZuuoL6ZCnCiexaeDTmQIP1EXgCa6Kec++pNCTynVBU14A3Rhg==", "c59f8729-0b87-4787-a1d5-974ac0b966a2", "admin00" });
        }
    }
}
