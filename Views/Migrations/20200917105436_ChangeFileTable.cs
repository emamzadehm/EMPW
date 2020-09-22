using Microsoft.EntityFrameworkCore.Migrations;

namespace Emamzadeh.Migrations
{
    public partial class ChangeFileTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileAddress",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "TypeID",
                table: "Files");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FileAddress",
                table: "Files",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TypeID",
                table: "Files",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
