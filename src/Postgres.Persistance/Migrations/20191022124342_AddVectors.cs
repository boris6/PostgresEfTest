using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Postgres.Persistance.Migrations
{
    public partial class AddVectors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FeatureVectors",
                columns: table => new
                {
                    FeatureVectorId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    FeatureVectorData = table.Column<byte[]>(nullable: true),
                    ExternailId = table.Column<string>(nullable: true),
                    ReferenceImageId = table.Column<Guid>(nullable: true),
                    IdentityId = table.Column<Guid>(nullable: true),
                    CombinedVector = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeatureVectors", x => x.FeatureVectorId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FeatureVectors");
        }
    }
}
