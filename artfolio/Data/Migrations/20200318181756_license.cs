using Microsoft.EntityFrameworkCore.Migrations;

namespace artfolio.Data.Migrations
{
    public partial class license : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "License",
                table: "Artworks");

            migrationBuilder.DropColumn(
                name: "TerritoryJuridiction",
                table: "Artworks");

            migrationBuilder.AddColumn<int>(
                name: "CCLicenseCreativeCommonsId",
                table: "Artworks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TerritorialJuridiction",
                table: "Artworks",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Artworks_CCLicenseCreativeCommonsId",
                table: "Artworks",
                column: "CCLicenseCreativeCommonsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Artworks_CreativeCommons_CCLicenseCreativeCommonsId",
                table: "Artworks",
                column: "CCLicenseCreativeCommonsId",
                principalTable: "CreativeCommons",
                principalColumn: "CreativeCommonsId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Artworks_CreativeCommons_CCLicenseCreativeCommonsId",
                table: "Artworks");

            migrationBuilder.DropIndex(
                name: "IX_Artworks_CCLicenseCreativeCommonsId",
                table: "Artworks");

            migrationBuilder.DropColumn(
                name: "CCLicenseCreativeCommonsId",
                table: "Artworks");

            migrationBuilder.DropColumn(
                name: "TerritorialJuridiction",
                table: "Artworks");

            migrationBuilder.AddColumn<int>(
                name: "License",
                table: "Artworks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "TerritoryJuridiction",
                table: "Artworks",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
