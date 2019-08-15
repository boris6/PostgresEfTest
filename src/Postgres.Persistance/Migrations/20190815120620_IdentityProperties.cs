using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Postgres.Persistance.Migrations
{
    public partial class IdentityProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Identities",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Identities",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Identities",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Identities",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpiryDate",
                table: "Identities",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostalCode",
                table: "Identities",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Street",
                table: "Identities",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TelephoneNumber",
                table: "Identities",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "Identities");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Identities");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Identities");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Identities");

            migrationBuilder.DropColumn(
                name: "ExpiryDate",
                table: "Identities");

            migrationBuilder.DropColumn(
                name: "PostalCode",
                table: "Identities");

            migrationBuilder.DropColumn(
                name: "Street",
                table: "Identities");

            migrationBuilder.DropColumn(
                name: "TelephoneNumber",
                table: "Identities");
        }
    }
}
