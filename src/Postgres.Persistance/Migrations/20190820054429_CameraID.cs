using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Postgres.Persistance.Migrations
{
    public partial class CameraID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                "CustomerId",
                "Identities",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                "CustomerId",
                "Categories",
                nullable: true);

            migrationBuilder.DropColumn(
                "CameraId",
                "Cameras");

            migrationBuilder.AddColumn<Guid>(
                "CameraId",
                "Cameras",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                "Active",
                "Cameras",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<byte[]>(
                "DisplayImage",
                "Cameras",
                nullable: true);

            migrationBuilder.DropColumn(
                "CameraId",
                "AggregatedEvents");

            migrationBuilder.AddColumn<Guid>(
                "CameraId",
                "AggregatedEvents",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                "CustomerId",
                "Identities");

            migrationBuilder.DropColumn(
                "CustomerId",
                "Categories");

            migrationBuilder.DropColumn(
                "Active",
                "Cameras");

            migrationBuilder.DropColumn(
                "DisplayImage",
                "Cameras");

            migrationBuilder.DropColumn(
                "ReferenceImageId",
                "Cameras");

            migrationBuilder.AddColumn<string>(
                "ReferenceImageId",
                "Cameras");

            migrationBuilder.DropColumn(
                "ReferenceImageId",
                "AggregatedEvents");

            migrationBuilder.AddColumn<string>(
                "ReferenceImageId",
                "AggregatedEvents");
        }
    }
}