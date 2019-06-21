using Microsoft.EntityFrameworkCore.Migrations;

namespace Postgres.Persistance.Migrations
{
    public partial class ForeignKeyReferenceIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReferenceImages_Identities_IdentityId",
                table: "ReferenceImages");

            migrationBuilder.AlterColumn<string>(
                name: "IdentityId",
                table: "ReferenceImages",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ReferenceImages_Identities_IdentityId",
                table: "ReferenceImages",
                column: "IdentityId",
                principalTable: "Identities",
                principalColumn: "IdentityId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReferenceImages_Identities_IdentityId",
                table: "ReferenceImages");

            migrationBuilder.AlterColumn<string>(
                name: "IdentityId",
                table: "ReferenceImages",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddForeignKey(
                name: "FK_ReferenceImages_Identities_IdentityId",
                table: "ReferenceImages",
                column: "IdentityId",
                principalTable: "Identities",
                principalColumn: "IdentityId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
