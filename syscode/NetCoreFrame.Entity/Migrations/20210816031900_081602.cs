using Microsoft.EntityFrameworkCore.Migrations;

namespace NetCoreFrame.Entity.Migrations
{
    public partial class _081602 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DataStatus",
                table: "Frame_Information",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsPush",
                table: "Frame_Information",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataStatus",
                table: "Frame_Information");

            migrationBuilder.DropColumn(
                name: "IsPush",
                table: "Frame_Information");
        }
    }
}
