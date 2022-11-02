using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BrightlandsCasus.Data.Migrations
{
    public partial class relatieStap_StapConnectie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StapConnectie_Stap_VanStapId",
                table: "StapConnectie");

            migrationBuilder.DropIndex(
                name: "IX_StapConnectie_VanStapId",
                table: "StapConnectie");

            migrationBuilder.DropColumn(
                name: "VanStapId",
                table: "StapConnectie");

            migrationBuilder.CreateIndex(
                name: "IX_StapConnectie_VanId",
                table: "StapConnectie",
                column: "VanId");

            migrationBuilder.AddForeignKey(
                name: "FK_StapConnectie_Stap_VanId",
                table: "StapConnectie",
                column: "VanId",
                principalTable: "Stap",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StapConnectie_Stap_VanId",
                table: "StapConnectie");

            migrationBuilder.DropIndex(
                name: "IX_StapConnectie_VanId",
                table: "StapConnectie");

            migrationBuilder.AddColumn<int>(
                name: "VanStapId",
                table: "StapConnectie",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_StapConnectie_VanStapId",
                table: "StapConnectie",
                column: "VanStapId");

            migrationBuilder.AddForeignKey(
                name: "FK_StapConnectie_Stap_VanStapId",
                table: "StapConnectie",
                column: "VanStapId",
                principalTable: "Stap",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
