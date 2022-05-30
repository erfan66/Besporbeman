using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BMDataAccess.Migrations
{
    public partial class dropApplicationUserFromAdvertise : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Advertise_AspNetUsers_UserId",
                table: "Advertise");

            migrationBuilder.DropIndex(
                name: "IX_Advertise_UserId",
                table: "Advertise");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Advertise");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Advertise",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Advertise_UserId",
                table: "Advertise",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Advertise_AspNetUsers_UserId",
                table: "Advertise",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
