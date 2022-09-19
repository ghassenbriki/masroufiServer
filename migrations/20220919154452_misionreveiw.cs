using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace masroufiServer.migrations
{
    /// <inheritdoc />
    public partial class misionreveiw : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "partagé",
                table: "Missions");

            migrationBuilder.DropColumn(
                name: "vu",
                table: "Missions");

            migrationBuilder.AddColumn<int>(
                name: "nbShare",
                table: "Missions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "nbView",
                table: "Missions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b739c10-7796-455b-9fdf-0b0543df170a", "AQAAAAEAACcQAAAAEPcVFr6y/YS8VfGVjqZNJ3YKS+EfelVvl2iYAW3a1wLUbeAQrGEecYnutozDcnQ2/g==", "26f0340b-a0cf-4ff0-b6be-df1227511304" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "nbShare",
                table: "Missions");

            migrationBuilder.DropColumn(
                name: "nbView",
                table: "Missions");

            migrationBuilder.AddColumn<bool>(
                name: "partagé",
                table: "Missions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "vu",
                table: "Missions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0c28b8ab-2d08-446d-ad4f-67330770773a", "AQAAAAEAACcQAAAAEKh+veF66pT0I817AGrretKxQdGy3Nxyt9cbRxdJt3YNph4PWLDp2VsXNn3MfMLBEw==", "0627eb25-6d41-4eaf-82c3-0ca6b1228307" });
        }
    }
}
