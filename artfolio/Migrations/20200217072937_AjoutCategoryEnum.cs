using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace artfolio.Migrations
{
    public partial class AjoutCategoryEnum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Artworks_ArtworkCategory_ArtworkCategoryId",
                table: "Artworks");

            migrationBuilder.DropTable(
                name: "ArtworkCategory");

            migrationBuilder.DropIndex(
                name: "IX_Artworks_ArtworkCategoryId",
                table: "Artworks");

            migrationBuilder.DropColumn(
                name: "ArtworkCategoryId",
                table: "Artworks");

            migrationBuilder.AddColumn<int>(
                name: "Category",
                table: "Artworks",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Artworks");

            migrationBuilder.AddColumn<int>(
                name: "ArtworkCategoryId",
                table: "Artworks",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ArtworkCategory",
                columns: table => new
                {
                    ArtworkCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtworkCategory", x => x.ArtworkCategoryId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Artworks_ArtworkCategoryId",
                table: "Artworks",
                column: "ArtworkCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Artworks_ArtworkCategory_ArtworkCategoryId",
                table: "Artworks",
                column: "ArtworkCategoryId",
                principalTable: "ArtworkCategory",
                principalColumn: "ArtworkCategoryId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
