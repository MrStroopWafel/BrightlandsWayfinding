using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BrightlandsCasus.Data.Migrations
{
    public partial class NieuweFkRelatie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StapConnectie_Stap_VanId",
                table: "StapConnectie");

            migrationBuilder.RenameColumn(
                name: "VanId",
                table: "StapConnectie",
                newName: "StapToId");

            migrationBuilder.RenameColumn(
                name: "NaarId",
                table: "StapConnectie",
                newName: "StapFromId");

            migrationBuilder.RenameIndex(
                name: "IX_StapConnectie_VanId",
                table: "StapConnectie",
                newName: "IX_StapConnectie_StapToId");

            migrationBuilder.UpdateData(
                table: "StapConnectie",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "StapFromId", "StapToId" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "StapConnectie",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "StapFromId", "StapToId" },
                values: new object[] { 1, 3 });

            migrationBuilder.UpdateData(
                table: "StapConnectie",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "StapFromId", "StapToId" },
                values: new object[] { 1, 4 });

            migrationBuilder.UpdateData(
                table: "StapConnectie",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "StapFromId", "StapToId" },
                values: new object[] { 1, 5 });

            migrationBuilder.UpdateData(
                table: "StapConnectie",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "StapFromId", "StapToId" },
                values: new object[] { 1, 7 });

            migrationBuilder.UpdateData(
                table: "StapConnectie",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "StapFromId", "StapToId" },
                values: new object[] { 2, 8 });

            migrationBuilder.UpdateData(
                table: "StapConnectie",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "StapFromId", "StapToId" },
                values: new object[] { 8, 9 });

            migrationBuilder.UpdateData(
                table: "StapConnectie",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "StapFromId", "StapToId" },
                values: new object[] { 8, 10 });

            migrationBuilder.UpdateData(
                table: "StapConnectie",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "StapFromId", "StapToId" },
                values: new object[] { 8, 11 });

            migrationBuilder.UpdateData(
                table: "StapConnectie",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "StapFromId", "StapToId" },
                values: new object[] { 9, 12 });

            migrationBuilder.UpdateData(
                table: "StapConnectie",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "StapFromId", "StapToId" },
                values: new object[] { 9, 13 });

            migrationBuilder.UpdateData(
                table: "StapConnectie",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "StapFromId", "StapToId" },
                values: new object[] { 10, 14 });

            migrationBuilder.UpdateData(
                table: "StapConnectie",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "StapFromId", "StapToId" },
                values: new object[] { 10, 15 });

            migrationBuilder.UpdateData(
                table: "StapConnectie",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "StapFromId", "StapToId" },
                values: new object[] { 11, 16 });

            migrationBuilder.CreateIndex(
                name: "IX_StapConnectie_StapFromId",
                table: "StapConnectie",
                column: "StapFromId");

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

            migrationBuilder.RenameColumn(
                name: "StapToId",
                table: "StapConnectie",
                newName: "VanId");

            migrationBuilder.RenameColumn(
                name: "StapFromId",
                table: "StapConnectie",
                newName: "NaarId");

            migrationBuilder.RenameIndex(
                name: "IX_StapConnectie_StapToId",
                table: "StapConnectie",
                newName: "IX_StapConnectie_VanId");

            migrationBuilder.UpdateData(
                table: "StapConnectie",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "NaarId", "VanId" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "StapConnectie",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "NaarId", "VanId" },
                values: new object[] { 3, 1 });

            migrationBuilder.UpdateData(
                table: "StapConnectie",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "NaarId", "VanId" },
                values: new object[] { 4, 1 });

            migrationBuilder.UpdateData(
                table: "StapConnectie",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "NaarId", "VanId" },
                values: new object[] { 5, 1 });

            migrationBuilder.UpdateData(
                table: "StapConnectie",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "NaarId", "VanId" },
                values: new object[] { 7, 1 });

            migrationBuilder.UpdateData(
                table: "StapConnectie",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "NaarId", "VanId" },
                values: new object[] { 8, 2 });

            migrationBuilder.UpdateData(
                table: "StapConnectie",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "NaarId", "VanId" },
                values: new object[] { 9, 8 });

            migrationBuilder.UpdateData(
                table: "StapConnectie",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "NaarId", "VanId" },
                values: new object[] { 10, 8 });

            migrationBuilder.UpdateData(
                table: "StapConnectie",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "NaarId", "VanId" },
                values: new object[] { 11, 8 });

            migrationBuilder.UpdateData(
                table: "StapConnectie",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "NaarId", "VanId" },
                values: new object[] { 12, 9 });

            migrationBuilder.UpdateData(
                table: "StapConnectie",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "NaarId", "VanId" },
                values: new object[] { 13, 9 });

            migrationBuilder.UpdateData(
                table: "StapConnectie",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "NaarId", "VanId" },
                values: new object[] { 14, 10 });

            migrationBuilder.UpdateData(
                table: "StapConnectie",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "NaarId", "VanId" },
                values: new object[] { 15, 10 });

            migrationBuilder.UpdateData(
                table: "StapConnectie",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "NaarId", "VanId" },
                values: new object[] { 16, 11 });

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
