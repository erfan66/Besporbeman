using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BMDataAccess.Migrations
{
    public partial class addMorePropertiesToGoods : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "Goods",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Height",
                table: "Goods",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Length",
                table: "Goods",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Weight",
                table: "Goods",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Width",
                table: "Goods",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Count",
                table: "Goods");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "Goods");

            migrationBuilder.DropColumn(
                name: "Length",
                table: "Goods");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Goods");

            migrationBuilder.DropColumn(
                name: "Width",
                table: "Goods");
        }
    }
}
