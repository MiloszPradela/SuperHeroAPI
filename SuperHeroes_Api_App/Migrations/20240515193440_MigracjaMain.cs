using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace SuperHeroes_Api_App.Migrations
{
    /// <inheritdoc />
    public partial class MigracjaMain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "alignment",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    alignment = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_alignment", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "attributee",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    attributee = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_attributee", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "colour",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    colour = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_colour", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gender",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    gender = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gender", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "publisher",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    publisher_name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_publisher", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "race",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    race = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_race", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "superpower",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    power_name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_superpower", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "superhero",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    superhero_name = table.Column<string>(type: "text", nullable: false),
                    full_name = table.Column<string>(type: "text", nullable: false),
                    gender_id = table.Column<int>(type: "integer", nullable: false),
                    eye_colour_id = table.Column<int>(type: "integer", nullable: false),
                    hair_colour_id = table.Column<int>(type: "integer", nullable: false),
                    skin_colour_id = table.Column<int>(type: "integer", nullable: false),
                    race_id = table.Column<int>(type: "integer", nullable: false),
                    publisher_id = table.Column<int>(type: "integer", nullable: false),
                    alignment_id = table.Column<int>(type: "integer", nullable: false),
                    height_cm = table.Column<int>(type: "integer", nullable: false),
                    weight_kg = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_superhero", x => x.id);
                    table.ForeignKey(
                        name: "FK_superhero_alignment_alignment_id",
                        column: x => x.alignment_id,
                        principalTable: "alignment",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_superhero_colour_eye_colour_id",
                        column: x => x.eye_colour_id,
                        principalTable: "colour",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_superhero_colour_hair_colour_id",
                        column: x => x.hair_colour_id,
                        principalTable: "colour",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_superhero_colour_skin_colour_id",
                        column: x => x.skin_colour_id,
                        principalTable: "colour",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_superhero_gender_gender_id",
                        column: x => x.gender_id,
                        principalTable: "gender",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_superhero_publisher_publisher_id",
                        column: x => x.publisher_id,
                        principalTable: "publisher",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_superhero_race_race_id",
                        column: x => x.race_id,
                        principalTable: "race",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "hero_attribute",
                columns: table => new
                {
                    hero_id = table.Column<int>(type: "integer", nullable: false),
                    attribute_id = table.Column<int>(type: "integer", nullable: false),
                    attribute_value = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hero_attribute", x => new { x.hero_id, x.attribute_id });
                    table.ForeignKey(
                        name: "FK_hero_attribute_attributee_attribute_id",
                        column: x => x.attribute_id,
                        principalTable: "attributee",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_hero_attribute_superhero_hero_id",
                        column: x => x.hero_id,
                        principalTable: "superhero",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "hero_power",
                columns: table => new
                {
                    hero_id = table.Column<int>(type: "integer", nullable: false),
                    power_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hero_power", x => new { x.hero_id, x.power_id });
                    table.ForeignKey(
                        name: "FK_hero_power_superhero_hero_id",
                        column: x => x.hero_id,
                        principalTable: "superhero",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_hero_power_superpower_power_id",
                        column: x => x.power_id,
                        principalTable: "superpower",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_hero_attribute_attribute_id",
                table: "hero_attribute",
                column: "attribute_id");

            migrationBuilder.CreateIndex(
                name: "IX_hero_power_power_id",
                table: "hero_power",
                column: "power_id");

            migrationBuilder.CreateIndex(
                name: "IX_superhero_alignment_id",
                table: "superhero",
                column: "alignment_id");

            migrationBuilder.CreateIndex(
                name: "IX_superhero_eye_colour_id",
                table: "superhero",
                column: "eye_colour_id");

            migrationBuilder.CreateIndex(
                name: "IX_superhero_gender_id",
                table: "superhero",
                column: "gender_id");

            migrationBuilder.CreateIndex(
                name: "IX_superhero_hair_colour_id",
                table: "superhero",
                column: "hair_colour_id");

            migrationBuilder.CreateIndex(
                name: "IX_superhero_publisher_id",
                table: "superhero",
                column: "publisher_id");

            migrationBuilder.CreateIndex(
                name: "IX_superhero_race_id",
                table: "superhero",
                column: "race_id");

            migrationBuilder.CreateIndex(
                name: "IX_superhero_skin_colour_id",
                table: "superhero",
                column: "skin_colour_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "hero_attribute");

            migrationBuilder.DropTable(
                name: "hero_power");

            migrationBuilder.DropTable(
                name: "attributee");

            migrationBuilder.DropTable(
                name: "superhero");

            migrationBuilder.DropTable(
                name: "superpower");

            migrationBuilder.DropTable(
                name: "alignment");

            migrationBuilder.DropTable(
                name: "colour");

            migrationBuilder.DropTable(
                name: "gender");

            migrationBuilder.DropTable(
                name: "publisher");

            migrationBuilder.DropTable(
                name: "race");
        }
    }
}
