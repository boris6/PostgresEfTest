using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Postgres.Persistance.Migrations
{
    public partial class somethingSomethingSomething : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_AggregatedEvents_AggregatedEventsId",
                table: "Events");

            migrationBuilder.AlterColumn<Guid>(
                name: "AggregatedEventsId",
                table: "Events",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_AggregatedEvents_AggregatedEventsId",
                table: "Events",
                column: "AggregatedEventsId",
                principalTable: "AggregatedEvents",
                principalColumn: "AggregatedEventsId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_AggregatedEvents_AggregatedEventsId",
                table: "Events");

            migrationBuilder.AlterColumn<Guid>(
                name: "AggregatedEventsId",
                table: "Events",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddForeignKey(
                name: "FK_Events_AggregatedEvents_AggregatedEventsId",
                table: "Events",
                column: "AggregatedEventsId",
                principalTable: "AggregatedEvents",
                principalColumn: "AggregatedEventsId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
