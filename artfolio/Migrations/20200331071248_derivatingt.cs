using Microsoft.EntityFrameworkCore.Migrations;

namespace artfolio.Migrations
{
    public partial class derivatingt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDerivating",
                table: "Artworks",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LicenseDerivating",
                table: "Artworks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LinkDerivating",
                table: "Artworks",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDerivating",
                table: "Artworks");

            migrationBuilder.DropColumn(
                name: "LicenseDerivating",
                table: "Artworks");

            migrationBuilder.DropColumn(
                name: "LinkDerivating",
                table: "Artworks");
        }
    }
}
