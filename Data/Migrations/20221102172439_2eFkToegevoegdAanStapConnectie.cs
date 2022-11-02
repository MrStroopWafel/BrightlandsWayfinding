using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BrightlandsCasus.Data.Migrations
{
    public partial class _2eFkToegevoegdAanStapConnectie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StapConnectie_Stap_VanId",
                table: "StapConnectie");

            migrationBuilder.DropIndex(
                name: "IX_StapConnectie_VanId",
                table: "StapConnectie");

            migrationBuilder.AddColumn<int>(
                name: "StapFromId",
                table: "StapConnectie",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StapToId",
                table: "StapConnectie",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_StapConnectie_StapFromId",
                table: "StapConnectie",
                column: "StapFromId");

            migrationBuilder.CreateIndex(
                name: "IX_StapConnectie_StapToId",
                table: "StapConnectie",
                column: "StapToId");

            migrationBuilder.AddForeignKey(
                name: "FK_StapConnectie_Stap_StapFromId",
                table: "StapConnectie",
                column: "StapFromId",
                principalTable: "Stap",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StapConnectie_Stap_StapToId",
                table: "StapConnectie",
                column: "StapToId",
                principalTable: "Stap",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StapConnectie_Stap_StapFromId",
                table: "StapConnectie");

            migrationBuilder.DropForeignKey(
                name: "FK_StapConnectie_Stap_StapToId",
                table: "StapConnectie");

            migrationBuilder.DropIndex(
                name: "IX_StapConnectie_StapFromId",
                table: "StapConnectie");

            migrationBuilder.DropIndex(
                name: "IX_StapConnectie_StapToId",
                table: "StapConnectie");

            migrationBuilder.DropColumn(
                name: "StapFromId",
                table: "StapConnectie");

            migrationBuilder.DropColumn(
                name: "StapToId",
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
    }
}
