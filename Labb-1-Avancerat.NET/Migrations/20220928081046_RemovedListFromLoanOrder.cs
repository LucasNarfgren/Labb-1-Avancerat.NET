using Microsoft.EntityFrameworkCore.Migrations;

namespace Labb_1_Avancerat.NET.Migrations
{
    public partial class RemovedListFromLoanOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LoanOrders_LoanOrders_LoanOrderId1",
                table: "LoanOrders");

            migrationBuilder.DropIndex(
                name: "IX_LoanOrders_LoanOrderId1",
                table: "LoanOrders");

            migrationBuilder.DropColumn(
                name: "LoanOrderId1",
                table: "LoanOrders");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LoanOrderId1",
                table: "LoanOrders",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_LoanOrders_LoanOrderId1",
                table: "LoanOrders",
                column: "LoanOrderId1");

            migrationBuilder.AddForeignKey(
                name: "FK_LoanOrders_LoanOrders_LoanOrderId1",
                table: "LoanOrders",
                column: "LoanOrderId1",
                principalTable: "LoanOrders",
                principalColumn: "LoanOrderId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
