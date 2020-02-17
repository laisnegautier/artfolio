using Microsoft.EntityFrameworkCore.Migrations;

namespace artfolio.Migrations
{
    public partial class UpdateDocumentMedia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Documents");

            migrationBuilder.AddColumn<int>(
                name: "Media",
                table: "Documents",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Media",
                table: "Documents");

            migrationBuilder.AddColumn<int>(
                name: "Category",
                table: "Documents",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
