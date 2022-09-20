using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace masroufiServer.migrations
{
    /// <inheritdoc />
    public partial class usersmisssions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MissionUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9628b0ab-79cf-4057-996a-ab85e3f548e9", "AQAAAAEAACcQAAAAEEu6GX5ns1iPeBHnnCvbHU0ILqWKpJppGniRRdI75OvgNXU8W/oExD9/nNpvgiTj9Q==", "3eb7e3c5-d241-4520-8f69-d27b2489e942" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MissionUsers",
                columns: table => new
                {
                    MissionId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MissionUsers", x => new { x.MissionId, x.UserId });
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6d22b00f-8d74-47a0-b0d9-97f1accfc0ff", "AQAAAAEAACcQAAAAEOVjQ5B5EuRUlJL05iH0e9dzdD0vcRVjRUgtzwNhQ3Jg7eqW4nYh6QSms+WDf4NzLw==", "aa95bd17-5277-4929-8393-9983937baa47" });
        }
    }
}
