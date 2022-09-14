using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace masroufiServer.migrations
{
    /// <inheritdoc />
    public partial class userINterrets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "interrets",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "interrets",
                table: "AspNetUsers");
        }
    }
}
