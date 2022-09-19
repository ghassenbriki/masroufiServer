using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace masroufiServer.migrations
{
    /// <inheritdoc />
    public partial class @new : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "vidSource",
                table: "Missions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fd0f723e-8179-482e-8530-5807e8cf305f", "AQAAAAEAACcQAAAAEFZjnAsRP8nwWdtxAHl1VxbYKAVOke8yIDbKsX56pp/s66SFOTM47MM3FovcxaMSTw==", "e0883858-637b-4f4b-89cd-264c38ac2b1f" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "vidSource",
                table: "Missions");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3aeec4b2-33ef-4334-9ea7-b4f14239c832", "AQAAAAEAACcQAAAAEC7HMZMQStmta8h+LH/I48ZBN/waWLRN3cBJ6kmkou63elHOJTYlyXkn59YY9T6/HA==", "b4a5a749-e5c4-4d2f-8517-c5e07a2d7ba7" });
        }
    }
}
