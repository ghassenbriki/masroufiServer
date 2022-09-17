using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace masroufiServer.migrations
{
    /// <inheritdoc />
    public partial class mig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ville",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "ville" },
                values: new object[] { "39147cfc-6572-48d6-b311-c04f71f14b10", "AQAAAAEAACcQAAAAENU8Q9Mkng0VbcT4tFAByBuzv4S4efNFWp12YSpmmFBeCIBMRNAAK6vIQbwa+bclfQ==", "64d819ea-de31-4eee-a527-d53b1b7e4558", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ville",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0c02a863-0bca-4a4a-a315-61e60c98af43", "AQAAAAEAACcQAAAAEOtP6BFb5/TfWlJkEPlRO+OLYvLLaoSQqqvQB3RsdB5BVRt31t9pJNzd9QY5CygMxQ==", "7b43c34c-2da6-4ad7-9b9a-49e5697124ff" });
        }
    }
}
