using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace masroufiServer.migrations
{
    /// <inheritdoc />
    public partial class mission2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b4cacce5-ee0b-4830-91c1-db02a7e2eee0", "AQAAAAEAACcQAAAAEL8gLdT1Ob8DCsG8cmJtQtJa57dQvHevmyw/CqbcBZZ6WYkQofxtvUQF0KZEAhV0qQ==", "53f2cf65-da3d-4239-9629-fa696f7b4d86" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f2521fb8-dbd7-4630-93be-74a09d59b43b", "AQAAAAEAACcQAAAAEKVDmr4RLrl5s76LThGhGjpaFosJauaMeX8yDwUfQGF8qesAYwC72hbqomhFeTOb1A==", "6dfd0183-8c2c-4cc0-9dff-8e9b8663edea" });
        }
    }
}
