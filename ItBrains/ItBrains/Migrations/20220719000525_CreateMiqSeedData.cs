using Microsoft.EntityFrameworkCore.Migrations;

namespace ItBrains.Migrations
{
    public partial class CreateMiqSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Miqs",
                columns: new[] { "Id", "Link" },
                values: new object[] { 1, "https ile link olmalidir burda" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Miqs",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
