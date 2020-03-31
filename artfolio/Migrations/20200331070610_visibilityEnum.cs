using Microsoft.EntityFrameworkCore.Migrations;

namespace artfolio.Migrations
{
    public partial class visibilityEnum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "AspNetUsers",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<bool>(
                name: "Privacy",
                table: "Artworks",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Privacy",
                table: "Artworks",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool));
        }
    }
}
