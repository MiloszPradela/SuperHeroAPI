using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SuperHeroes_Api_App.Migrations
{
    /// <inheritdoc />
    public partial class MIgracja2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "attributee",
                table: "attributee",
                newName: "attribute_name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "attribute_name",
                table: "attributee",
                newName: "attributee");
        }
    }
}
