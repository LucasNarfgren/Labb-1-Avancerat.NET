using Microsoft.EntityFrameworkCore.Migrations;

namespace Labb_1_Avancerat.NET.Migrations
{
    public partial class RemovedTableReturnedBooks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LoanOrders_ReturnBooks_ReturnBookReturnedBooksId",
                table: "LoanOrders");

            migrationBuilder.DropTable(
                name: "ReturnBooks");

            migrationBuilder.DropIndex(
                name: "IX_LoanOrders_ReturnBookReturnedBooksId",
                table: "LoanOrders");

            migrationBuilder.DropColumn(
                name: "ReturnBookReturnedBooksId",
                table: "LoanOrders");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReturnBookReturnedBooksId",
                table: "LoanOrders",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ReturnBooks",
                columns: table => new
                {
                    ReturnedBooksId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReturnBooks", x => x.ReturnedBooksId);
                });

            migrationBuilder.InsertData(
                table: "ReturnBooks",
                column: "ReturnedBooksId",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_LoanOrders_ReturnBookReturnedBooksId",
                table: "LoanOrders",
                column: "ReturnBookReturnedBooksId");

            migrationBuilder.AddForeignKey(
                name: "FK_LoanOrders_ReturnBooks_ReturnBookReturnedBooksId",
                table: "LoanOrders",
                column: "ReturnBookReturnedBooksId",
                principalTable: "ReturnBooks",
                principalColumn: "ReturnedBooksId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
