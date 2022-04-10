using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BMDataAccess.Migrations
{
    public partial class removeSenderFromAdvertise : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Advertise_Sender_SenderId",
                table: "Advertise");

            migrationBuilder.DropIndex(
                name: "IX_Advertise_SenderId",
                table: "Advertise");

            migrationBuilder.DropColumn(
                name: "SenderId",
                table: "Advertise");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SenderId",
                table: "Advertise",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Advertise_SenderId",
                table: "Advertise",
                column: "SenderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Advertise_Sender_SenderId",
                table: "Advertise",
                column: "SenderId",
                principalTable: "Sender",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
