using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BMDataAccess.Migrations
{
    public partial class addMorePropertyToElectronic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Width",
                table: "Electronic",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Width",
                table: "Electronic");
        }
    }
}
