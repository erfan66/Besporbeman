using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BMDataAccess.Migrations
{
    public partial class removeCountryFromDestination : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Destination_Country_CountryId",
                table: "Destination");

            migrationBuilder.DropIndex(
                name: "IX_Destination_CountryId",
                table: "Destination");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Destination");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "Destination",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Destination_CountryId",
                table: "Destination",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Destination_Country_CountryId",
                table: "Destination",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
