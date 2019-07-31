using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Postgres.Persistance.Migrations
{
    public partial class ChangeKeyType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MainReferenceImage",
                table: "ReferenceImages");

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferenceImageId",
                table: "ReferenceImages",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AddColumn<Guid>(
                name: "ReferenceImageId",
                table: "Identities",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReferenceImageId",
                table: "Identities");

            migrationBuilder.AlterColumn<int>(
                name: "ReferenceImageId",
                table: "ReferenceImages",
                nullable: false,
                oldClrType: typeof(Guid))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AddColumn<bool>(
                name: "MainReferenceImage",
                table: "ReferenceImages",
                nullable: false,
                defaultValue: false);
        }
    }
}
