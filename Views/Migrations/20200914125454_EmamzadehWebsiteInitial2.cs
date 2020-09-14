using Microsoft.EntityFrameworkCore.Migrations;

namespace Emamzadeh.Migrations
{
    public partial class EmamzadehWebsiteInitial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LinkedInURL",
                table: "Professors",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StudentImg",
                table: "Histories",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LinkedInURL",
                table: "Professors");

            migrationBuilder.DropColumn(
                name: "StudentImg",
                table: "Histories");
        }
    }
}
