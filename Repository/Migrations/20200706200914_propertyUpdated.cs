using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class propertyUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PropFilter",
                table: "Properties",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PropFilter",
                table: "Properties");
        }
    }
}
