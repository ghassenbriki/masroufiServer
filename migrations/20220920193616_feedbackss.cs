using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace masroufiServer.migrations
{
    /// <inheritdoc />
    public partial class feedbackss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "date",
                table: "FeedBacks",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Date");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db8a7ab9-d134-40d9-a943-78c990d42014", "AQAAAAEAACcQAAAAEKp4A0rDCN+x9TpRLTvSbpUYR7W8WWYox0OT8eAISgDXCdY+x1q60B9GMLBuO4c5Hg==", "9426fc01-aa4a-4a45-9822-371174df30ee" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "date",
                table: "FeedBacks",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d45a610f-fce8-4bfe-9b29-5adb34e1f9fb", "AQAAAAEAACcQAAAAEMGP1y8zwPynB54HoXAsrzZoRjwRh7DjXB2OYmGfPnYP47EK+QU3+Rb3Mw3hb4avHg==", "76229fdd-d2ee-4e6c-b8ab-9c9ea0201ee3" });
        }
    }
}
