using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BrightlandsCasus.Data.Migrations
{
    public partial class LokaalBedrijf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bedrijven",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bedrijven", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Verdiepingen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Beschrijving = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Verdiepingen", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lokalen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LokaalNummer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VerdiepingId = table.Column<int>(type: "int", nullable: false),
                    LokaalBedrijfId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lokalen", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lokalen_Verdiepingen_VerdiepingId",
                        column: x => x.VerdiepingId,
                        principalTable: "Verdiepingen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "lokaalBedrijf",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LokaalId = table.Column<int>(type: "int", nullable: false),
                    BedijfId = table.Column<int>(type: "int", nullable: false),
                    LokaalNummer = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lokaalBedrijf", x => x.Id);
                    table.ForeignKey(
                        name: "FK_lokaalBedrijf_Bedrijven_BedijfId",
                        column: x => x.BedijfId,
                        principalTable: "Bedrijven",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_lokaalBedrijf_Lokalen_LokaalId",
                        column: x => x.LokaalId,
                        principalTable: "Lokalen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_lokaalBedrijf_BedijfId",
                table: "lokaalBedrijf",
                column: "BedijfId");

            migrationBuilder.CreateIndex(
                name: "IX_lokaalBedrijf_LokaalId",
                table: "lokaalBedrijf",
                column: "LokaalId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Lokalen_VerdiepingId",
                table: "Lokalen",
                column: "VerdiepingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "lokaalBedrijf");

            migrationBuilder.DropTable(
                name: "Bedrijven");

            migrationBuilder.DropTable(
                name: "Lokalen");

            migrationBuilder.DropTable(
                name: "Verdiepingen");
        }
    }
}
