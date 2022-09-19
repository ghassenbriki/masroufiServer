using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace masroufiServer.migrations
{
    /// <inheritdoc />
    public partial class missionsponsor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Sponsor",
                table: "Missions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cf1be166-6958-4395-9730-919cc27510d9", "AQAAAAEAACcQAAAAEBja/kMkbkLAWsdjIv1vcrX6fcQqTCmf31BqRyOI0OHphS6/lU0IyLL6mVVRcKOJAg==", "c9838519-b048-458d-acad-f6ffd96c867c" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sponsor",
                table: "Missions");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fd0f723e-8179-482e-8530-5807e8cf305f", "AQAAAAEAACcQAAAAEFZjnAsRP8nwWdtxAHl1VxbYKAVOke8yIDbKsX56pp/s66SFOTM47MM3FovcxaMSTw==", "e0883858-637b-4f4b-89cd-264c38ac2b1f" });
        }
    }
}
