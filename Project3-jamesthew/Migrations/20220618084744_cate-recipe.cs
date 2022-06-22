using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project3_jamesthew.Migrations
{
    public partial class caterecipe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "varchar(50)", nullable: false),
                    CategoryDescription = table.Column<string>(type: "varchar(500)", nullable: false),
                    CategoryIcon = table.Column<string>(type: "varchar(300)", nullable: false),
                    CategoryImg = table.Column<string>(type: "varchar(1000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "recipes",
                columns: table => new
                {
                    RecipesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrepationTime = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    CookingTime = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    Difficulty = table.Column<string>(type: "varchar(30)", nullable: false),
                    Serve = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    Calories = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    Proteins = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    Carbs = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    Fat = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    SaturatedFat = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    Fiber = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    Sugar = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    Salt = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    CategoriesId = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    RecipesPic = table.Column<string>(type: "varchar(30)", nullable: false),
                    RecipesTitle = table.Column<string>(type: "varchar(30)", nullable: false),
                    RecipesDescription = table.Column<string>(type: "varchar(30)", nullable: false),
                    IsPaid = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_recipes", x => x.RecipesId);
                    table.ForeignKey(
                        name: "FK_recipes_categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_recipes_CategoriesId",
                table: "recipes",
                column: "CategoriesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "recipes");

            migrationBuilder.DropTable(
                name: "categories");
        }
    }
}
