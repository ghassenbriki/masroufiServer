using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace masroufiServer.migrations
{
    /// <inheritdoc />
    public partial class feedbacks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FeedBacks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date = table.Column<DateTime>(type: "Date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeedBacks", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d45a610f-fce8-4bfe-9b29-5adb34e1f9fb", "AQAAAAEAACcQAAAAEMGP1y8zwPynB54HoXAsrzZoRjwRh7DjXB2OYmGfPnYP47EK+QU3+Rb3Mw3hb4avHg==", "76229fdd-d2ee-4e6c-b8ab-9c9ea0201ee3" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FeedBacks");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0697924e-c333-4605-be45-ffc24f1d16d3", "AQAAAAEAACcQAAAAENXA69txhLc3eJL3AXmC9TmY+RfSrSrypN3WjEF5nvkUSx5DNUWlrSdZx7l3tAgkAQ==", "beae564c-d6e0-49bd-b722-c4983933f8e4" });
        }
    }
}
