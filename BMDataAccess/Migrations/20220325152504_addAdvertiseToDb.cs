using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BMDataAccess.Migrations
{
    public partial class addAdvertiseToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Advertise",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfAdvertise = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ValidityDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KindId = table.Column<int>(type: "int", nullable: false),
                    MaterialId = table.Column<int>(type: "int", nullable: false),
                    SenderId = table.Column<int>(type: "int", nullable: false),
                    TransferId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advertise", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Advertise_Kind_KindId",
                        column: x => x.KindId,
                        principalTable: "Kind",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Advertise_Material_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Material",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Advertise_Sender_SenderId",
                        column: x => x.SenderId,
                        principalTable: "Sender",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Advertise_Transfer_TransferId",
                        column: x => x.TransferId,
                        principalTable: "Transfer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Advertise_KindId",
                table: "Advertise",
                column: "KindId");

            migrationBuilder.CreateIndex(
                name: "IX_Advertise_MaterialId",
                table: "Advertise",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_Advertise_SenderId",
                table: "Advertise",
                column: "SenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Advertise_TransferId",
                table: "Advertise",
                column: "TransferId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Advertise");
        }
    }
}
