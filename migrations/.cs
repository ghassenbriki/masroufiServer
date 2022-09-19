using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace masroufiServer.migrations
{
    /// <inheritdoc />
    public partial class manytomanyef : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
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

            migrationBuilder.CreateTable(
                name: "UserMissions",
                columns: table => new
                {
                    missuonId = table.Column<int>(type: "int", nullable: false),
                    userId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    missionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserMissions", x => new { x.userId, x.missuonId });
                    table.ForeignKey(
                        name: "FK_UserMissions_AspNetUsers_userId",
                        column: x => x.userId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserMissions_Missions_missionId",
                        column: x => x.missionId,
                        principalTable: "Missions",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "788a9d2a-f947-4f1a-935f-c49b051c4548", "AQAAAAEAACcQAAAAEEJxGjm9FZruVW/ZT2iI8T0UMrCujfwuwfYDPkIl9jY5IO1U27TTE6wX44jS4i6v8g==", "3aea125c-20a9-4d2f-a5ce-36a3b92a446b" });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserMission_usersId",
                table: "ApplicationUserMission",
                column: "usersId");

            migrationBuilder.CreateIndex(
                name: "IX_UserMissions_missionId",
                table: "UserMissions",
                column: "missionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationUserMission");

            migrationBuilder.DropTable(
                name: "UserMissions");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f463736-68c2-4ed2-909e-3405ea970b93", "AQAAAAEAACcQAAAAEHAQIIGGhPBMtfr4x2KiZILIbP8dzn8LR4jUG4AwNrT8oE/gk9AGyhnHnVnoe69m6g==", "1851d004-48a0-4329-9282-ac55e51154a9" });
        }
    }
}
