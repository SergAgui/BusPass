using Microsoft.EntityFrameworkCore.Migrations;

namespace BusPass.Data.Migrations
{
    public partial class FareAndServiceEnumsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AlertType",
                table: "ServiceAlerts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PassType",
                table: "Fares",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AlertType",
                table: "ServiceAlerts");

            migrationBuilder.DropColumn(
                name: "PassType",
                table: "Fares");
        }
    }
}
