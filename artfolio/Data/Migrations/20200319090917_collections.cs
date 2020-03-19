using Microsoft.EntityFrameworkCore.Migrations;

namespace artfolio.Data.Migrations
{
    public partial class collections : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArtworkCollections");

            migrationBuilder.AddColumn<int>(
                name: "CollectionId",
                table: "Artworks",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "CreativeCommons",
                keyColumn: "CreativeCommonsId",
                keyValue: 7,
                column: "Acronym",
                value: "cc-zero");

            migrationBuilder.CreateIndex(
                name: "IX_Artworks_CollectionId",
                table: "Artworks",
                column: "CollectionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Artworks_Collections_CollectionId",
                table: "Artworks",
                column: "CollectionId",
                principalTable: "Collections",
                principalColumn: "CollectionId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Artworks_Collections_CollectionId",
                table: "Artworks");

            migrationBuilder.DropIndex(
                name: "IX_Artworks_CollectionId",
                table: "Artworks");

            migrationBuilder.DropColumn(
                name: "CollectionId",
                table: "Artworks");

            migrationBuilder.CreateTable(
                name: "ArtworkCollections",
                columns: table => new
                {
                    ArtworkCollectionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArtworkId = table.Column<int>(type: "int", nullable: true),
                    CollectionId = table.Column<int>(type: "int", nullable: true),
                    IsMasterpiece = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtworkCollections", x => x.ArtworkCollectionId);
                    table.ForeignKey(
                        name: "FK_ArtworkCollections_Artworks_ArtworkId",
                        column: x => x.ArtworkId,
                        principalTable: "Artworks",
                        principalColumn: "ArtworkId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ArtworkCollections_Collections_CollectionId",
                        column: x => x.CollectionId,
                        principalTable: "Collections",
                        principalColumn: "CollectionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "CreativeCommons",
                keyColumn: "CreativeCommonsId",
                keyValue: 7,
                column: "Acronym",
                value: "zero");

            migrationBuilder.CreateIndex(
                name: "IX_ArtworkCollections_ArtworkId",
                table: "ArtworkCollections",
                column: "ArtworkId");

            migrationBuilder.CreateIndex(
                name: "IX_ArtworkCollections_CollectionId",
                table: "ArtworkCollections",
                column: "CollectionId");
        }
    }
}
