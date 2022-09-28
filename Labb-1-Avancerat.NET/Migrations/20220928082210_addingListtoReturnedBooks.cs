using Microsoft.EntityFrameworkCore.Migrations;

namespace Labb_1_Avancerat.NET.Migrations
{
    public partial class addingListtoReturnedBooks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ReturnBooks",
                column: "ReturnedBooksId",
                value: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ReturnBooks",
                keyColumn: "ReturnedBooksId",
                keyValue: 1);
        }
    }
}
