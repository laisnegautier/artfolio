using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace artfolio.Migrations
{
    public partial class artworkModelDataAnnotation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PublicationDate",
                table: "Artworks");

            migrationBuilder.AddColumn<DateTime>(
                name: "ReleaseDate",
                table: "Artworks",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReleaseDate",
                table: "Artworks");

            migrationBuilder.AddColumn<DateTime>(
                name: "PublicationDate",
                table: "Artworks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
