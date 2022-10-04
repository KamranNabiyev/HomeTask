using Microsoft.EntityFrameworkCore.Migrations;

namespace ItBrains.Migrations
{
    public partial class ChangeTables2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeactive",
                table: "Videos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeactive",
                table: "VideoLessons",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeactive",
                table: "Videos");

            migrationBuilder.DropColumn(
                name: "IsDeactive",
                table: "VideoLessons");
        }
    }
}
