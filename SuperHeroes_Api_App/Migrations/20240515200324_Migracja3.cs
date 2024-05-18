using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SuperHeroes_Api_App.Migrations
{
    /// <inheritdoc />
    public partial class Migracja3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_hero_attribute_attributee_attribute_id",
                table: "hero_attribute");

            migrationBuilder.DropPrimaryKey(
                name: "PK_attributee",
                table: "attributee");

            migrationBuilder.RenameTable(
                name: "attributee",
                newName: "attribute");

            migrationBuilder.AddPrimaryKey(
                name: "PK_attribute",
                table: "attribute",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_hero_attribute_attribute_attribute_id",
                table: "hero_attribute",
                column: "attribute_id",
                principalTable: "attribute",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_hero_attribute_attribute_attribute_id",
                table: "hero_attribute");

            migrationBuilder.DropPrimaryKey(
                name: "PK_attribute",
                table: "attribute");

            migrationBuilder.RenameTable(
                name: "attribute",
                newName: "attributee");

            migrationBuilder.AddPrimaryKey(
                name: "PK_attributee",
                table: "attributee",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_hero_attribute_attributee_attribute_id",
                table: "hero_attribute",
                column: "attribute_id",
                principalTable: "attributee",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
