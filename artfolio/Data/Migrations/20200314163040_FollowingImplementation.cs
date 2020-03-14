using Microsoft.EntityFrameworkCore.Migrations;

namespace artfolio.Data.Migrations
{
    public partial class FollowingImplementation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FollowRelations",
                columns: table => new
                {
                    FromArtistId = table.Column<string>(nullable: false),
                    ToArtistId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FollowRelations", x => new { x.FromArtistId, x.ToArtistId });
                    table.ForeignKey(
                        name: "FK_FollowRelations_AspNetUsers_FromArtistId",
                        column: x => x.FromArtistId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FollowRelations_AspNetUsers_ToArtistId",
                        column: x => x.ToArtistId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FollowRelations_ToArtistId",
                table: "FollowRelations",
                column: "ToArtistId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FollowRelations");
        }
    }
}
