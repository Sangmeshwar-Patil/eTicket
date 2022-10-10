using Microsoft.EntityFrameworkCore.Migrations;

namespace eTicket.Migrations
{
    public partial class MovieFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MyProperty",
                table: "Movies",
                newName: "MovieCategory");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MovieCategory",
                table: "Movies",
                newName: "MyProperty");
        }
    }
}
