using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Postgres.Persistance.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AggregatedEvents",
                columns: table => new
                {
                    AggregatedEventsId = table.Column<Guid>(nullable: false),
                    IdentityId = table.Column<string>(nullable: true),
                    Recognized = table.Column<bool>(nullable: false),
                    CameraId = table.Column<string>(nullable: true),
                    TimestampStart = table.Column<DateTimeOffset>(nullable: false),
                    TimestampEnd = table.Column<DateTimeOffset>(nullable: false),
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
                    IdentityId = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    MiddleName = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    Info = table.Column<string>(nullable: true),
                    Image = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Identities", x => x.IdentityId);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    FrcEventId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Rectangle = table.Column<string>(type: "jsonb", nullable: true),
                    Confidence = table.Column<string>(type: "jsonb", nullable: true),
                    Timestamp = table.Column<DateTimeOffset>(nullable: false),
                    Image = table.Column<byte[]>(nullable: true),
                    Framenumber = table.Column<int>(nullable: false),
                    HeadId = table.Column<string>(nullable: true),
                    AggregatedEventsId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.FrcEventId);
                    table.ForeignKey(
                        name: "FK_Events_AggregatedEvents_AggregatedEventsId",
                        column: x => x.AggregatedEventsId,
                        principalTable: "AggregatedEvents",
                        principalColumn: "AggregatedEventsId",
                        onDelete: ReferentialAction.Cascade);
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
