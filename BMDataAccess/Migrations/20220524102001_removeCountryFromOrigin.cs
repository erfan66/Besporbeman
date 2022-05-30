using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BMDataAccess.Migrations
{
    public partial class removeCountryFromOrigin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Origin_Country_CountryId",
                table: "Origin");

            migrationBuilder.DropIndex(
                name: "IX_Origin_CountryId",
                table: "Origin");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Origin");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "Origin",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Origin_CountryId",
                table: "Origin",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Origin_Country_CountryId",
                table: "Origin",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
