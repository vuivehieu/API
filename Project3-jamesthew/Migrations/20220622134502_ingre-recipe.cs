using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project3_jamesthew.Migrations
{
    public partial class ingrerecipe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ingredients",
                columns: table => new
                {
                    IngredientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IngredientName = table.Column<string>(type: "varchar(50)", nullable: false),
                    Quantity = table.Column<string>(type: "varchar(50)", nullable: false),
                    RecipeCompetitionId = table.Column<int>(type: "int", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ingredients", x => x.IngredientId);
                    table.ForeignKey(
                        name: "FK_ingredients_recipesCompetitions_RecipeCompetitionId",
                        column: x => x.RecipeCompetitionId,
                        principalTable: "recipesCompetitions",
                        principalColumn: "RecipesCompetitionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ingredients_RecipeCompetitionId",
                table: "ingredients",
                column: "RecipeCompetitionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ingredients");
        }
    }
}
