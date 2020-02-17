using Microsoft.EntityFrameworkCore.Migrations;

namespace artfolio.Migrations
{
    public partial class modifDocument : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Documents_Artworks_ArtworkId",
                table: "Documents");

            migrationBuilder.AlterColumn<int>(
                name: "ArtworkId",
                table: "Documents",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "File",
                table: "Documents",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_Artworks_ArtworkId",
                table: "Documents",
                column: "ArtworkId",
                principalTable: "Artworks",
                principalColumn: "ArtworkId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Documents_Artworks_ArtworkId",
                table: "Documents");

            migrationBuilder.DropColumn(
                name: "File",
                table: "Documents");

            migrationBuilder.AlterColumn<int>(
                name: "ArtworkId",
                table: "Documents",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_Artworks_ArtworkId",
                table: "Documents",
                column: "ArtworkId",
                principalTable: "Artworks",
                principalColumn: "ArtworkId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
