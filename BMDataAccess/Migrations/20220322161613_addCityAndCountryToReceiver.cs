using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BMDataAccess.Migrations
{
    public partial class addCityAndCountryToReceiver : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Receiver");

            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "Receiver",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "Receiver",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Receiver_CityId",
                table: "Receiver",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Receiver_CountryId",
                table: "Receiver",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Receiver_City_CityId",
                table: "Receiver",
                column: "CityId",
                principalTable: "City",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Receiver_Country_CountryId",
                table: "Receiver",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Receiver_City_CityId",
                table: "Receiver");

            migrationBuilder.DropForeignKey(
                name: "FK_Receiver_Country_CountryId",
                table: "Receiver");

            migrationBuilder.DropIndex(
                name: "IX_Receiver_CityId",
                table: "Receiver");

            migrationBuilder.DropIndex(
                name: "IX_Receiver_CountryId",
                table: "Receiver");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Receiver");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Receiver");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Receiver",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
