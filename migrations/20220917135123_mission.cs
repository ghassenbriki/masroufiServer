using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace masroufiServer.migrations
{
    /// <inheritdoc />
    public partial class mission : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Missions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    spot = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    vu = table.Column<bool>(type: "bit", nullable: false),
                    partagé = table.Column<bool>(type: "bit", nullable: false),
                    coinsShare = table.Column<int>(type: "int", nullable: true),
                    coinsview = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Missions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Missions_AspNetUsers_userId",
                        column: x => x.userId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f2521fb8-dbd7-4630-93be-74a09d59b43b", "AQAAAAEAACcQAAAAEKVDmr4RLrl5s76LThGhGjpaFosJauaMeX8yDwUfQGF8qesAYwC72hbqomhFeTOb1A==", "6dfd0183-8c2c-4cc0-9dff-8e9b8663edea" });

            migrationBuilder.CreateIndex(
                name: "IX_Missions_userId",
                table: "Missions",
                column: "userId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Missions");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39147cfc-6572-48d6-b311-c04f71f14b10", "AQAAAAEAACcQAAAAENU8Q9Mkng0VbcT4tFAByBuzv4S4efNFWp12YSpmmFBeCIBMRNAAK6vIQbwa+bclfQ==", "64d819ea-de31-4eee-a527-d53b1b7e4558" });
        }
    }
}
