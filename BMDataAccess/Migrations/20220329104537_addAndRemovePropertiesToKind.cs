using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BMDataAccess.Migrations
{
    public partial class addAndRemovePropertiesToKind : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kind_Doc_DocId",
                table: "Kind");

            migrationBuilder.DropForeignKey(
                name: "FK_Kind_Electronic_ElectronicId",
                table: "Kind");

            migrationBuilder.DropForeignKey(
                name: "FK_Kind_NonElectronic_NonElectronicId",
                table: "Kind");

            migrationBuilder.DropTable(
                name: "Doc");

            migrationBuilder.DropTable(
                name: "Electronic");

            migrationBuilder.DropTable(
                name: "NonElectronic");

            migrationBuilder.DropIndex(
                name: "IX_Kind_DocId",
                table: "Kind");

            migrationBuilder.DropIndex(
                name: "IX_Kind_ElectronicId",
                table: "Kind");

            migrationBuilder.DropIndex(
                name: "IX_Kind_NonElectronicId",
                table: "Kind");

            migrationBuilder.DropColumn(
                name: "DocId",
                table: "Kind");

            migrationBuilder.DropColumn(
                name: "ElectronicId",
                table: "Kind");

            migrationBuilder.DropColumn(
                name: "NonElectronicId",
                table: "Kind");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DocId",
                table: "Kind",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ElectronicId",
                table: "Kind",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NonElectronicId",
                table: "Kind",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Doc",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Count = table.Column<int>(type: "int", nullable: false),
                    Height = table.Column<double>(type: "float", nullable: false),
                    Length = table.Column<double>(type: "float", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    Width = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doc", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Electronic",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Count = table.Column<int>(type: "int", nullable: false),
                    Height = table.Column<double>(type: "float", nullable: false),
                    Length = table.Column<double>(type: "float", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    Width = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Electronic", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NonElectronic",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Count = table.Column<int>(type: "int", nullable: false),
                    Height = table.Column<double>(type: "float", nullable: false),
                    Length = table.Column<double>(type: "float", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    Width = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NonElectronic", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kind_DocId",
                table: "Kind",
                column: "DocId");

            migrationBuilder.CreateIndex(
                name: "IX_Kind_ElectronicId",
                table: "Kind",
                column: "ElectronicId");

            migrationBuilder.CreateIndex(
                name: "IX_Kind_NonElectronicId",
                table: "Kind",
                column: "NonElectronicId");

            migrationBuilder.AddForeignKey(
                name: "FK_Kind_Doc_DocId",
                table: "Kind",
                column: "DocId",
                principalTable: "Doc",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Kind_Electronic_ElectronicId",
                table: "Kind",
                column: "ElectronicId",
                principalTable: "Electronic",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Kind_NonElectronic_NonElectronicId",
                table: "Kind",
                column: "NonElectronicId",
                principalTable: "NonElectronic",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
