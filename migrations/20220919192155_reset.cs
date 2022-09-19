using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace masroufiServer.migrations
{
    /// <inheritdoc />
    public partial class reset : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd17d474-ccc1-4984-a48c-45e0af704838", "AQAAAAEAACcQAAAAEBZFXBZv4Ett0db8PixNflejCIpdmwPNvcPTNdlOhDSkVinPJGtP0npZ3M+VJvcu2Q==", "a4a3a39c-494f-46c4-9e57-45ea0860d1f6" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0fafc584-0ebd-447c-80c6-ae72b46e016a", "AQAAAAEAACcQAAAAEPgYiFI6ShMdAdbX+XEYuhfsPY8zzFwlePa0Lgsd5ZdOHTSzB6IZ/QHWdZ9XBNGOlA==", "b03292ea-7938-4046-93b9-7f2fdd74978f" });
        }
    }
}
