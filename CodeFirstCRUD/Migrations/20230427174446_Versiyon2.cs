using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirstCRUD.Migrations
{
    public partial class Versiyon2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Kisiler",
                columns: new[] { "KisiID", "Ad", "Soyad", "Telefon" },
                values: new object[,]
                {
                    { 1, "Burak", "Kilicaslan", "5554443322" },
                    { 2, "Beyza", "Kilicaslan", "9990001122" },
                    { 3, "John", "Doe", "5555555555" },
                    { 4, "Nancy", "Grancer", "7778889900" },
                    { 5, "David", "Concord", "3334058725" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Kisiler",
                keyColumn: "KisiID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Kisiler",
                keyColumn: "KisiID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Kisiler",
                keyColumn: "KisiID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Kisiler",
                keyColumn: "KisiID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Kisiler",
                keyColumn: "KisiID",
                keyValue: 5);
        }
    }
}
