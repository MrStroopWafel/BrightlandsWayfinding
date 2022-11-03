using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BrightlandsCasus.Data.Migrations
{
    public partial class StappenENStappenConnectie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stap",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StappenBeschrijving = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LokaalId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stap", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StapConnectie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VanId = table.Column<int>(type: "int", nullable: false),
                    NaarId = table.Column<int>(type: "int", nullable: false),
                    Afstand = table.Column<int>(type: "int", nullable: false),
                    RouteUitelg = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VanStapId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StapConnectie", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StapConnectie_Stap_VanStapId",
                        column: x => x.VanStapId,
                        principalTable: "Stap",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StapConnectie_VanStapId",
                table: "StapConnectie",
                column: "VanStapId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StapConnectie");

            migrationBuilder.DropTable(
                name: "Stap");
        }
    }
}
