using Microsoft.EntityFrameworkCore.Migrations;

namespace Emamzadeh.Migrations
{
    public partial class AddMappAddressToProfessors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MapAddress",
                table: "Professors",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MapAddress",
                table: "Professors");
        }
    }
}
