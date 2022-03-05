using Microsoft.EntityFrameworkCore.Migrations;

namespace NetCoreFrame.Entity.Migrations
{
    public partial class ChangePro2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "ProductionStation");

            migrationBuilder.AddColumn<string>(
                name: "ProductionName",
                table: "ProductionStation",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StationName",
                table: "ProductionStation",
                maxLength: 100,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductionName",
                table: "ProductionStation");

            migrationBuilder.DropColumn(
                name: "StationName",
                table: "ProductionStation");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "ProductionStation",
                type: "varchar(100) CHARACTER SET utf8mb4",
                maxLength: 100,
                nullable: true);
        }
    }
}
