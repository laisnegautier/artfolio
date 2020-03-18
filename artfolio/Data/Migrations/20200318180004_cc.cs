using Microsoft.EntityFrameworkCore.Migrations;

namespace artfolio.Data.Migrations
{
    public partial class cc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TerritoryJuridiction",
                table: "Artworks",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CreativeCommons",
                columns: table => new
                {
                    CreativeCommonsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Acronym = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    LicenseDeedUrl = table.Column<string>(nullable: true),
                    LegalCodeUrl = table.Column<string>(nullable: true),
                    BY = table.Column<bool>(nullable: false),
                    SA = table.Column<bool>(nullable: false),
                    ND = table.Column<bool>(nullable: false),
                    NC = table.Column<bool>(nullable: false),
                    Zero = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreativeCommons", x => x.CreativeCommonsId);
                });

            migrationBuilder.InsertData(
                table: "CreativeCommons",
                columns: new[] { "CreativeCommonsId", "Acronym", "BY", "Description", "LegalCodeUrl", "LicenseDeedUrl", "NC", "ND", "SA", "Title", "Zero" },
                values: new object[,]
                {
                    { 1, "by", true, "This license lets others distribute, remix, tweak, and build upon your work, even commercially, as long as they credit you for the original creation. ", "https://creativecommons.org/licenses/by/4.0/legalcode", "https://creativecommons.org/licenses/by/4.0", false, false, false, "Attribution", false },
                    { 2, "by-sa", true, "This license lets others remix, tweak, and build upon your work even for commercial purposes, as long as they credit you and license their new creations under the identical terms.", "https://creativecommons.org/licenses/by-sa/4.0/legalcode", "https://creativecommons.org/licenses/by-sa/4.0", false, false, true, "Attribution-ShareAlike", false },
                    { 3, "by-nd", true, "This license lets others reuse the work for any purpose, including commercially; however, it cannot be shared with others in adapted form, and credit must be provided to you.", "https://creativecommons.org/licenses/by-nd/4.0/legalcode", "https://creativecommons.org/licenses/by-nd/4.0", false, true, false, "Attribution-NoDerivs", false },
                    { 4, "by-nc", true, "This license lets others remix, tweak, and build upon your work non-commercially, and although their new works must also acknowledge you and be non-commercial, they don’t have to license their derivative works on the same terms.", "https://creativecommons.org/licenses/by-nc/4.0/legalcode", "https://creativecommons.org/licenses/by-nc/4.0", true, false, false, "Attribution-NonCommercial", false },
                    { 5, "by-nc-sa", true, "This license lets others remix, tweak, and build upon your work non-commercially, as long as they credit you and license their new creations under the identical terms.", "https://creativecommons.org/licenses/by-nc-sa/4.0/legalcode", "https://creativecommons.org/licenses/by-nc-sa/4.0", true, false, true, "Attribution-NonCommercial-ShareAlike", false },
                    { 6, "by-nc-nd", true, "This license is the most restrictive of our six main licenses, only allowing others to download your works and share them with others as long as they credit you, but they can’t change them in any way or use them commercially.", "https://creativecommons.org/licenses/by-nc-nd/4.0/legalcode", "https://creativecommons.org/licenses/by-nc-nd/4.0", true, true, false, "Attribution-NonCommercial-NoDerivs", false },
                    { 7, "zero", false, "Use this universal tool if you are a holder of copyright or database rights, and you wish to waive all your interests that may exist in your work worldwide. Because copyright laws differ around the world, you may use this tool even though you may not have copyright in your jurisdiction, but want to be sure to eliminate any copyrights you may have in other jurisdictions.", "https://creativecommons.org/publicdomain/zero/1.0/legalcode", "https://creativecommons.org/publicdomain/zero/1.0/", false, false, false, "CC0", true }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CreativeCommons");

            migrationBuilder.DropColumn(
                name: "TerritoryJuridiction",
                table: "Artworks");
        }
    }
}
