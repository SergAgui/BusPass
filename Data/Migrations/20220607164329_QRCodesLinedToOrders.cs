using Microsoft.EntityFrameworkCore.Migrations;

namespace BusPass.Data.Migrations
{
    public partial class QRCodesLinedToOrders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "QRCModel");

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "QRCModel",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "QRCModel");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "QRCModel",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
