using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace masroufiServer.migrations
{
    /// <inheritdoc />
    public partial class db : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "528457c3-8ae9-4a1c-84ce-9619631f58d4", "AQAAAAEAACcQAAAAECzhec7scGdjiDI0MdGjQCi++Hxy2a2TsbndV1HXyu9ya0AXV42gX48AHWCXtdZLMw==", "2e88d97f-9533-49fd-931c-8f7b6744db25" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db8a7ab9-d134-40d9-a943-78c990d42014", "AQAAAAEAACcQAAAAEKp4A0rDCN+x9TpRLTvSbpUYR7W8WWYox0OT8eAISgDXCdY+x1q60B9GMLBuO4c5Hg==", "9426fc01-aa4a-4a45-9822-371174df30ee" });
        }
    }
}
