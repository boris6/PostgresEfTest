using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Postgres.Persistance.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AggregatedEvents",
                columns: table => new
                {
                    AggregatedEventsId = table.Column<Guid>(nullable: false),
                    IdentityId = table.Column<int>(nullable: false),
                    Recognized = table.Column<bool>(nullable: false),
                    TimestampStart = table.Column<DateTime>(nullable: false),
                    TimestampEnd = table.Column<DateTime>(nullable: false),
                    BestImage = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AggregatedEvents", x => x.AggregatedEventsId);
                });

            migrationBuilder.CreateTable(
                name: "Identities",
                columns: table => new
                {
                    IdentityId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Identities", x => x.IdentityId);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    EventId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Rectangle = table.Column<string>(type: "jsonb", nullable: true),
                    Confidence = table.Column<string>(type: "jsonb", nullable: true),
                    Timestamp = table.Column<DateTime>(nullable: false),
                    BestImage = table.Column<byte[]>(nullable: true),
                    AggregatedEventsId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.EventId);
                    table.ForeignKey(
                        name: "FK_Events_AggregatedEvents_AggregatedEventsId",
                        column: x => x.AggregatedEventsId,
                        principalTable: "AggregatedEvents",
                        principalColumn: "AggregatedEventsId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Events_AggregatedEventsId",
                table: "Events",
                column: "AggregatedEventsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Identities");

            migrationBuilder.DropTable(
                name: "AggregatedEvents");
        }
    }
}
