using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BMDataAccess.Migrations
{
    public partial class addMorePropertyToDoc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Width",
                table: "Doc",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Width",
                table: "Doc");
        }
    }
}
