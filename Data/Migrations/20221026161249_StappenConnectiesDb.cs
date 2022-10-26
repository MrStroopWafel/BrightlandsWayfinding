using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BrightlandsCasus.Data.Migrations
{
    public partial class StappenConnectiesDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StapConnecties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    vanId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StapConnecties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stappen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StappenBeschrijving = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lokaalId = table.Column<int>(type: "int", nullable: true),
                    stappenConnectieId = table.Column<int>(type: "int", nullable: true),
                    StapConnectiesId = table.Column<int>(type: "int", nullable: true),
                    StapConnectiesId1 = table.Column<int>(type: "int", nullable: true),
                    StapConnectiesId2 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stappen", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stappen_StapConnecties_StapConnectiesId",
                        column: x => x.StapConnectiesId,
                        principalTable: "StapConnecties",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Stappen_StapConnecties_StapConnectiesId1",
                        column: x => x.StapConnectiesId1,
                        principalTable: "StapConnecties",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Stappen_StapConnecties_StapConnectiesId2",
                        column: x => x.StapConnectiesId2,
                        principalTable: "StapConnecties",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Stappen_StapConnectiesId",
                table: "Stappen",
                column: "StapConnectiesId");

            migrationBuilder.CreateIndex(
                name: "IX_Stappen_StapConnectiesId1",
                table: "Stappen",
                column: "StapConnectiesId1");

            migrationBuilder.CreateIndex(
                name: "IX_Stappen_StapConnectiesId2",
                table: "Stappen",
                column: "StapConnectiesId2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stappen");

            migrationBuilder.DropTable(
                name: "StapConnecties");
        }
    }
}
