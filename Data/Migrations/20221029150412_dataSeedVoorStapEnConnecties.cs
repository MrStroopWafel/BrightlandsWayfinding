using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BrightlandsCasus.Data.Migrations
{
    public partial class dataSeedVoorStapEnConnecties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Stap",
                columns: new[] { "Id", "LokaalId", "StappenBeschrijving" },
                values: new object[,]
                {
                    { 1, null, "Ingang" },
                    { 2, null, "Trap begaande grond" },
                    { 3, null, "WC" },
                    { 4, null, "Administratie" },
                    { 5, null, "Eerste verdieping lift" },
                    { 6, 1, "Lokaal 1" },
                    { 7, null, "Zithal" },
                    { 8, null, "1e verdieping" },
                    { 9, null, "1e verdieping gang links" },
                    { 10, null, "1e verdieping gang rechts" },
                    { 11, null, "1e verdieping gang rechtdoor" },
                    { 12, 2, "Lokaal 2" },
                    { 13, 3, "Lokaal 3" },
                    { 14, 4, "Lokaal 4" },
                    { 15, 5, "Lokaal 5" },
                    { 16, 6, "Lokaal 6" }
                });

            migrationBuilder.InsertData(
                table: "StapConnectie",
                columns: new[] { "Id", "Afstand", "NaarId", "RouteUitelg", "VanId" },
                values: new object[,]
                {
                    { 1, 2, 2, "Loop links naar de trap", 1 },
                    { 2, 3, 3, "Loop rechts naar de wc", 1 },
                    { 3, 2, 4, "Loop rechtdoor naar de administratie", 1 },
                    { 4, 5, 5, "Loop links naar de traplift", 1 },
                    { 5, 1, 7, "Loop rechtdoor naar de zithal", 1 },
                    { 6, 12, 8, "loop de trap op", 2 },
                    { 7, 6, 9, "Loop links de gang op", 8 },
                    { 8, 3, 10, "Loop rechts de gang op", 8 },
                    { 9, 6, 11, "Loop rechtdoor de gang op", 8 },
                    { 10, 8, 12, "Open de deur van lokaal 2", 9 },
                    { 11, 9, 13, "Open de deur van lokaal 3", 9 },
                    { 12, 2, 14, "Open de deur van lokaal 4", 10 },
                    { 13, 4, 15, "Open de deur van lokaal 5", 10 },
                    { 14, 5, 16, "Open de deur van lokaal 6", 11 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Stap",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Stap",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Stap",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Stap",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Stap",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Stap",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Stap",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Stap",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Stap",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Stap",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "StapConnectie",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StapConnectie",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "StapConnectie",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "StapConnectie",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "StapConnectie",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "StapConnectie",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "StapConnectie",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "StapConnectie",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "StapConnectie",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "StapConnectie",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "StapConnectie",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "StapConnectie",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "StapConnectie",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "StapConnectie",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Stap",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Stap",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Stap",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Stap",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Stap",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Stap",
                keyColumn: "Id",
                keyValue: 11);
        }
    }
}
