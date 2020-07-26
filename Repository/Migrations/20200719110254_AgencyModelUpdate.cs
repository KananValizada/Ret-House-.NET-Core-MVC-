using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class AgencyModelUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Agencies",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Agencies_CategoryId",
                table: "Agencies",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Agencies_Categories_CategoryId",
                table: "Agencies",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agencies_Categories_CategoryId",
                table: "Agencies");

            migrationBuilder.DropIndex(
                name: "IX_Agencies_CategoryId",
                table: "Agencies");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Agencies");
        }
    }
}
