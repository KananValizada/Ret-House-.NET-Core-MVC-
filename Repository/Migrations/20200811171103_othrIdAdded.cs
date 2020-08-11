using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class othrIdAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "othrId",
                table: "Categories",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "othrId",
                table: "Categories");
        }
    }
}
