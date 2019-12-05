using Microsoft.EntityFrameworkCore.Migrations;

namespace Postgres.Persistance.Migrations
{
    public partial class AddCameraProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "MaximumHeadSize",
                table: "Cameras",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "MinimumHeadSize",
                table: "Cameras",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Threshold",
                table: "Cameras",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaximumHeadSize",
                table: "Cameras");

            migrationBuilder.DropColumn(
                name: "MinimumHeadSize",
                table: "Cameras");

            migrationBuilder.DropColumn(
                name: "Threshold",
                table: "Cameras");
        }
    }
}
