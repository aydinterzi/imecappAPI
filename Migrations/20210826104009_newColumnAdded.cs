using Microsoft.EntityFrameworkCore.Migrations;

namespace imecappAPI.Migrations
{
    public partial class newColumnAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Language",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "progLanguage",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Language",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "progLanguage",
                table: "Posts");
        }
    }
}
