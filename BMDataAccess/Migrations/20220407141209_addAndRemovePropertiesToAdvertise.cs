using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BMDataAccess.Migrations
{
    public partial class addAndRemovePropertiesToAdvertise : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Advertise",
                newName: "Title");

            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "Advertise",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Height",
                table: "Advertise",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Length",
                table: "Advertise",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Weight",
                table: "Advertise",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Width",
                table: "Advertise",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Count",
                table: "Advertise");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "Advertise");

            migrationBuilder.DropColumn(
                name: "Length",
                table: "Advertise");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Advertise");

            migrationBuilder.DropColumn(
                name: "Width",
                table: "Advertise");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Advertise",
                newName: "Image");
        }
    }
}
