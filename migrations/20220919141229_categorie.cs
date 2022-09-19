using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace masroufiServer.migrations
{
    /// <inheritdoc />
    public partial class categorie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "catégorie",
                table: "Missions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0c28b8ab-2d08-446d-ad4f-67330770773a", "AQAAAAEAACcQAAAAEKh+veF66pT0I817AGrretKxQdGy3Nxyt9cbRxdJt3YNph4PWLDp2VsXNn3MfMLBEw==", "0627eb25-6d41-4eaf-82c3-0ca6b1228307" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "catégorie",
                table: "Missions");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cf1be166-6958-4395-9730-919cc27510d9", "AQAAAAEAACcQAAAAEBja/kMkbkLAWsdjIv1vcrX6fcQqTCmf31BqRyOI0OHphS6/lU0IyLL6mVVRcKOJAg==", "c9838519-b048-458d-acad-f6ffd96c867c" });
        }
    }
}
