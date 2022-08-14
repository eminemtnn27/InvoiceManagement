using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class updatedsMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UsersId",
                table: "flats");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UsersId",
                table: "flats",
                type: "int",
                nullable: true);
        }
    }
}
