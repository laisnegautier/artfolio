using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace artfolio.Migrations
{
    public partial class DeleteSomeDatabaseForMoreEnumeration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Documents_DocumentTypes_DocumentTypeId",
                table: "Documents");

            migrationBuilder.DropTable(
                name: "ArtworkLicenses");

            migrationBuilder.DropTable(
                name: "RelatedDocuments");

            migrationBuilder.DropTable(
                name: "CreativeCommonsLicenses");

            migrationBuilder.DropTable(
                name: "OtherLicenses");

            migrationBuilder.DropTable(
                name: "DocumentTypes");

            migrationBuilder.DropIndex(
                name: "IX_Documents_DocumentTypeId",
                table: "Documents");

            migrationBuilder.DropColumn(
                name: "DocumentTypeId",
                table: "Documents");

            migrationBuilder.AddColumn<int>(
                name: "Category",
                table: "Documents",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsMainDocument",
                table: "Documents",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Position",
                table: "Documents",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "License",
                table: "Artworks",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Privacy",
                table: "Artworks",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "PublicationDate",
                table: "Artworks",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Documents");

            migrationBuilder.DropColumn(
                name: "IsMainDocument",
                table: "Documents");

            migrationBuilder.DropColumn(
                name: "Position",
                table: "Documents");

            migrationBuilder.DropColumn(
                name: "License",
                table: "Artworks");

            migrationBuilder.DropColumn(
                name: "Privacy",
                table: "Artworks");

            migrationBuilder.DropColumn(
                name: "PublicationDate",
                table: "Artworks");

            migrationBuilder.AddColumn<int>(
                name: "DocumentTypeId",
                table: "Documents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CreativeCommonsLicenses",
                columns: table => new
                {
                    CreativeCommonsLicenseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeprecated = table.Column<bool>(type: "bit", nullable: false),
                    Logo = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OfficialLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Version = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreativeCommonsLicenses", x => x.CreativeCommonsLicenseId);
                });

            migrationBuilder.CreateTable(
                name: "DocumentTypes",
                columns: table => new
                {
                    DocumentTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentTypes", x => x.DocumentTypeId);
                });

            migrationBuilder.CreateTable(
                name: "OtherLicenses",
                columns: table => new
                {
                    OtherLicenseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherLicenses", x => x.OtherLicenseId);
                });

            migrationBuilder.CreateTable(
                name: "RelatedDocuments",
                columns: table => new
                {
                    RelatedDocumentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArtworkId = table.Column<int>(type: "int", nullable: false),
                    DocumentTypeId = table.Column<int>(type: "int", nullable: false),
                    Position = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelatedDocuments", x => x.RelatedDocumentId);
                    table.ForeignKey(
                        name: "FK_RelatedDocuments_Artworks_ArtworkId",
                        column: x => x.ArtworkId,
                        principalTable: "Artworks",
                        principalColumn: "ArtworkId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RelatedDocuments_DocumentTypes_DocumentTypeId",
                        column: x => x.DocumentTypeId,
                        principalTable: "DocumentTypes",
                        principalColumn: "DocumentTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArtworkLicenses",
                columns: table => new
                {
                    ArtworkLicenseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArtworkId = table.Column<int>(type: "int", nullable: false),
                    CreativeCommonsLicenseId = table.Column<int>(type: "int", nullable: true),
                    OtherLicenseId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtworkLicenses", x => x.ArtworkLicenseId);
                    table.ForeignKey(
                        name: "FK_ArtworkLicenses_Artworks_ArtworkId",
                        column: x => x.ArtworkId,
                        principalTable: "Artworks",
                        principalColumn: "ArtworkId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArtworkLicenses_CreativeCommonsLicenses_CreativeCommonsLicenseId",
                        column: x => x.CreativeCommonsLicenseId,
                        principalTable: "CreativeCommonsLicenses",
                        principalColumn: "CreativeCommonsLicenseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ArtworkLicenses_OtherLicenses_OtherLicenseId",
                        column: x => x.OtherLicenseId,
                        principalTable: "OtherLicenses",
                        principalColumn: "OtherLicenseId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "DocumentTypes",
                columns: new[] { "DocumentTypeId", "Type" },
                values: new object[,]
                {
                    { 1, "photography" },
                    { 2, "painting" },
                    { 3, "drawing" },
                    { 4, "writing" },
                    { 5, "audio" },
                    { 6, "sheetmusic" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Documents_DocumentTypeId",
                table: "Documents",
                column: "DocumentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ArtworkLicenses_ArtworkId",
                table: "ArtworkLicenses",
                column: "ArtworkId");

            migrationBuilder.CreateIndex(
                name: "IX_ArtworkLicenses_CreativeCommonsLicenseId",
                table: "ArtworkLicenses",
                column: "CreativeCommonsLicenseId");

            migrationBuilder.CreateIndex(
                name: "IX_ArtworkLicenses_OtherLicenseId",
                table: "ArtworkLicenses",
                column: "OtherLicenseId");

            migrationBuilder.CreateIndex(
                name: "IX_RelatedDocuments_ArtworkId",
                table: "RelatedDocuments",
                column: "ArtworkId");

            migrationBuilder.CreateIndex(
                name: "IX_RelatedDocuments_DocumentTypeId",
                table: "RelatedDocuments",
                column: "DocumentTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_DocumentTypes_DocumentTypeId",
                table: "Documents",
                column: "DocumentTypeId",
                principalTable: "DocumentTypes",
                principalColumn: "DocumentTypeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
