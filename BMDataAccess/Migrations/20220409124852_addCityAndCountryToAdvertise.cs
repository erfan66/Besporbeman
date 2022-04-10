using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BMDataAccess.Migrations
{
    public partial class addCityAndCountryToAdvertise : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "Advertise",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "Advertise",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Advertise_CityId",
                table: "Advertise",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Advertise_CountryId",
                table: "Advertise",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Advertise_City_CityId",
                table: "Advertise",
                column: "CityId",
                principalTable: "City",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Advertise_Country_CountryId",
                table: "Advertise",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Advertise_City_CityId",
                table: "Advertise");

            migrationBuilder.DropForeignKey(
                name: "FK_Advertise_Country_CountryId",
                table: "Advertise");

            migrationBuilder.DropIndex(
                name: "IX_Advertise_CityId",
                table: "Advertise");

            migrationBuilder.DropIndex(
                name: "IX_Advertise_CountryId",
                table: "Advertise");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Advertise");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Advertise");
        }
    }
}
