using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BMDataAccess.Migrations
{
    public partial class addGoodsToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Goods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KindId = table.Column<int>(type: "int", nullable: false),
                    MaterialId = table.Column<int>(type: "int", nullable: false)
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
                name: "IX_Goods_KindId",
                table: "Goods",
                column: "KindId");

            migrationBuilder.CreateIndex(
                name: "IX_Goods_MaterialId",
                table: "Goods",
                column: "MaterialId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Goods");
        }
    }
}
