using Microsoft.EntityFrameworkCore.Migrations;

namespace ItBrains.Migrations
{
    public partial class ChangeManyTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Opinion",
                table: "GraduatedOpinions",
                newName: "RuDescription");

            migrationBuilder.AddColumn<string>(
                name: "AzDescription",
                table: "GraduatedOpinions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EnDescription",
                table: "GraduatedOpinions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AzTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RuTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AzDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RuDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropColumn(
                name: "AzDescription",
                table: "GraduatedOpinions");

            migrationBuilder.DropColumn(
                name: "EnDescription",
                table: "GraduatedOpinions");

            migrationBuilder.RenameColumn(
                name: "RuDescription",
                table: "GraduatedOpinions",
                newName: "Opinion");
        }
    }
}
