using Microsoft.EntityFrameworkCore.Migrations;

namespace Postgres.Persistance.Migrations
{
    public partial class ExternalId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ExternalImageId",
                table: "ReferenceImages",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExternalImageId",
                table: "ReferenceImages");
        }
    }
}
