using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Postgres.Persistance.Migrations
{
    public partial class ReferenceImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Identities");

            migrationBuilder.CreateTable(
                name: "ReferenceImages",
                columns: table => new
                {
                    ReferenceImageId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Image = table.Column<byte[]>(nullable: true),
                    IdentityId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReferenceImages", x => x.ReferenceImageId);
                    table.ForeignKey(
                        name: "FK_ReferenceImages_Identities_IdentityId",
                        column: x => x.IdentityId,
                        principalTable: "Identities",
                        principalColumn: "IdentityId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReferenceImages_IdentityId",
                table: "ReferenceImages",
                column: "IdentityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReferenceImages");

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Identities",
                nullable: true);
        }
    }
}
