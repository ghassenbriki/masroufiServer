using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace masroufiServer.migrations
{
    /// <inheritdoc />
    public partial class usermisssions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           /* migrationBuilder.CreateTable(
                name: "ApplicationUserMission",
                columns: table => new
                {
                    missionsId = table.Column<int>(type: "int", nullable: false),
                    usersId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserMission", x => new { x.missionsId, x.usersId });
                    table.ForeignKey(
                        name: "FK_ApplicationUserMission_AspNetUsers_usersId",
                        column: x => x.usersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationUserMission_Missions_missionsId",
                        column: x => x.missionsId,
                        principalTable: "Missions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
           */
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

           /* migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserMission_usersId",
                table: "ApplicationUserMission",
                column: "usersId");*/
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
           /* migrationBuilder.DropTable(
                name: "ApplicationUserMission");

            migrationBuilder.DropTable(
                name: "MissionUsers");
           */
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd17d474-ccc1-4984-a48c-45e0af704838", "AQAAAAEAACcQAAAAEBZFXBZv4Ett0db8PixNflejCIpdmwPNvcPTNdlOhDSkVinPJGtP0npZ3M+VJvcu2Q==", "a4a3a39c-494f-46c4-9e57-45ea0860d1f6" });
        }
    }
}
