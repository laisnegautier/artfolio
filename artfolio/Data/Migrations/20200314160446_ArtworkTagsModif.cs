using Microsoft.EntityFrameworkCore.Migrations;

namespace artfolio.Data.Migrations
{
    public partial class ArtworkTagsModif : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ArtworkTags",
                table: "ArtworkTags");

            migrationBuilder.DropIndex(
                name: "IX_ArtworkTags_ArtworkId",
                table: "ArtworkTags");

            migrationBuilder.DropColumn(
                name: "ArtworkTagId",
                table: "ArtworkTags");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ArtworkTags",
                table: "ArtworkTags",
                columns: new[] { "ArtworkId", "TagId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ArtworkTags",
                table: "ArtworkTags");

            migrationBuilder.AddColumn<int>(
                name: "ArtworkTagId",
                table: "ArtworkTags",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ArtworkTags",
                table: "ArtworkTags",
                column: "ArtworkTagId");

            migrationBuilder.CreateIndex(
                name: "IX_ArtworkTags_ArtworkId",
                table: "ArtworkTags",
                column: "ArtworkId");
        }
    }
}
