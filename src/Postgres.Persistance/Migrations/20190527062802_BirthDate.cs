using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Postgres.Persistance.Migrations
{
    public partial class BirthDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Identities");

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "Identities",
                type: "date",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "Identities");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Identities",
                nullable: true);
        }
    }
}
