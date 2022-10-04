using Microsoft.EntityFrameworkCore.Migrations;

namespace ItBrains.Migrations
{
    public partial class ChangeManyTables2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VideoLessons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AzName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RuName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoLessons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Videos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoLessonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Videos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Videos_VideoLessons_VideoLessonId",
                        column: x => x.VideoLessonId,
                        principalTable: "VideoLessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Bios",
                columns: new[] { "Id", "Email", "Facebook", "Instagram", "Linkedin", "Mobile", "Telegram", "Youtube" },
                values: new object[] { 1, "info@itbrains.az", "https://www.facebook.com/itbrainacademy/", "https://www.instagram.com/proqramci_ol/", "https://www.linkedin.com/company/it-brains-training-center/about/", "+994507662000", "https://t.me/joinchat/TMKzDKQwRU1tqR_6", "https://www.youtube.com/c/ITBrains" });

            migrationBuilder.CreateIndex(
                name: "IX_Videos_VideoLessonId",
                table: "Videos",
                column: "VideoLessonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Videos");

            migrationBuilder.DropTable(
                name: "VideoLessons");

            migrationBuilder.DeleteData(
                table: "Bios",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
