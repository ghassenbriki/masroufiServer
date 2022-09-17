using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace masroufiServer.migrations
{
    /// <inheritdoc />
    public partial class miig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3aeec4b2-33ef-4334-9ea7-b4f14239c832", "AQAAAAEAACcQAAAAEC7HMZMQStmta8h+LH/I48ZBN/waWLRN3cBJ6kmkou63elHOJTYlyXkn59YY9T6/HA==", "b4a5a749-e5c4-4d2f-8517-c5e07a2d7ba7" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b4cacce5-ee0b-4830-91c1-db02a7e2eee0", "AQAAAAEAACcQAAAAEL8gLdT1Ob8DCsG8cmJtQtJa57dQvHevmyw/CqbcBZZ6WYkQofxtvUQF0KZEAhV0qQ==", "53f2cf65-da3d-4239-9629-fa696f7b4d86" });
        }
    }
}
