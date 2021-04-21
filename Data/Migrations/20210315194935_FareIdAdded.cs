using Microsoft.EntityFrameworkCore.Migrations;

namespace BusPass.Data.Migrations
{
    public partial class FareIdAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Fares_FareId",
                table: "Orders");

            migrationBuilder.AlterColumn<int>(
                name: "FareId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PriceId",
                table: "Fares",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Fares_FareId",
                table: "Orders",
                column: "FareId",
                principalTable: "Fares",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Fares_FareId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "PriceId",
                table: "Fares");

            migrationBuilder.AlterColumn<int>(
                name: "FareId",
                table: "Orders",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Fares_FareId",
                table: "Orders",
                column: "FareId",
                principalTable: "Fares",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
