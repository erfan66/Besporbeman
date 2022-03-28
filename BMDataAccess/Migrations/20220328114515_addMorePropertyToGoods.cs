using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BMDataAccess.Migrations
{
    public partial class addMorePropertyToGoods : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Goods",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "Goods");
        }
    }
}
