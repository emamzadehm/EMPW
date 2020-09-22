using Microsoft.EntityFrameworkCore.Migrations;

namespace Emamzadeh.Migrations
{
    public partial class UpdateFileTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FileExtention",
                table: "Files",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "FileLenght",
                table: "Files",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileExtention",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "FileLenght",
                table: "Files");
        }
    }
}
