using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BMDataAccess.Migrations
{
    public partial class addAndRemovePropertyToTransfer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Advertise_Transfer_TransferId",
                table: "Advertise");

            migrationBuilder.DropForeignKey(
                name: "FK_Transfer_Kind_KindId",
                table: "Transfer");

            migrationBuilder.DropForeignKey(
                name: "FK_Transfer_Material_MaterialId",
                table: "Transfer");

            migrationBuilder.DropForeignKey(
                name: "FK_Transfer_Sender_SenderId",
                table: "Transfer");

            migrationBuilder.DropTable(
                name: "Goods");

            migrationBuilder.DropIndex(
                name: "IX_Transfer_KindId",
                table: "Transfer");

            migrationBuilder.DropIndex(
                name: "IX_Transfer_MaterialId",
                table: "Transfer");

            migrationBuilder.DropIndex(
                name: "IX_Advertise_TransferId",
                table: "Advertise");

            migrationBuilder.DropColumn(
                name: "KindId",
                table: "Transfer");

            migrationBuilder.DropColumn(
                name: "MaterialId",
                table: "Transfer");

            migrationBuilder.DropColumn(
                name: "TransferId",
                table: "Advertise");

            migrationBuilder.RenameColumn(
                name: "SenderId",
                table: "Transfer",
                newName: "AdvertiseId");

            migrationBuilder.RenameIndex(
                name: "IX_Transfer_SenderId",
                table: "Transfer",
                newName: "IX_Transfer_AdvertiseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Transfer_Advertise_AdvertiseId",
                table: "Transfer",
                column: "AdvertiseId",
                principalTable: "Advertise",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transfer_Advertise_AdvertiseId",
                table: "Transfer");

            migrationBuilder.RenameColumn(
                name: "AdvertiseId",
                table: "Transfer",
                newName: "SenderId");

            migrationBuilder.RenameIndex(
                name: "IX_Transfer_AdvertiseId",
                table: "Transfer",
                newName: "IX_Transfer_SenderId");

            migrationBuilder.AddColumn<int>(
                name: "KindId",
                table: "Transfer",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MaterialId",
                table: "Transfer",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TransferId",
                table: "Advertise",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Goods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KindId = table.Column<int>(type: "int", nullable: false),
                    MaterialId = table.Column<int>(type: "int", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Height = table.Column<double>(type: "float", nullable: false),
                    Length = table.Column<double>(type: "float", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    Width = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Goods_Kind_KindId",
                        column: x => x.KindId,
                        principalTable: "Kind",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Goods_Material_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Material",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Transfer_KindId",
                table: "Transfer",
                column: "KindId");

            migrationBuilder.CreateIndex(
                name: "IX_Transfer_MaterialId",
                table: "Transfer",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_Advertise_TransferId",
                table: "Advertise",
                column: "TransferId");

            migrationBuilder.CreateIndex(
                name: "IX_Goods_KindId",
                table: "Goods",
                column: "KindId");

            migrationBuilder.CreateIndex(
                name: "IX_Goods_MaterialId",
                table: "Goods",
                column: "MaterialId");

            migrationBuilder.AddForeignKey(
                name: "FK_Advertise_Transfer_TransferId",
                table: "Advertise",
                column: "TransferId",
                principalTable: "Transfer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transfer_Kind_KindId",
                table: "Transfer",
                column: "KindId",
                principalTable: "Kind",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transfer_Material_MaterialId",
                table: "Transfer",
                column: "MaterialId",
                principalTable: "Material",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transfer_Sender_SenderId",
                table: "Transfer",
                column: "SenderId",
                principalTable: "Sender",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
