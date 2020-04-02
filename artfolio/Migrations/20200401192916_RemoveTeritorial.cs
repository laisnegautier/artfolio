using Microsoft.EntityFrameworkCore.Migrations;

namespace artfolio.Migrations
{
    public partial class RemoveTeritorial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TerritorialJuridiction",
                table: "Artworks");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TerritorialJuridiction",
                table: "Artworks",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
