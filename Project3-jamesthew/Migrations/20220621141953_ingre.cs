using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project3_jamesthew.Migrations
{
    public partial class ingre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "usersIngredients",
                columns: table => new
                {
                    IngredientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IngredientName = table.Column<string>(type: "varchar(30)", nullable: false),
                    Quantity = table.Column<string>(type: "varchar(30)", nullable: false),
                    RecipesId = table.Column<int>(type: "int", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usersIngredients", x => x.IngredientId);
                    table.ForeignKey(
                        name: "FK_usersIngredients_recipes_RecipesId",
                        column: x => x.RecipesId,
                        principalTable: "recipes",
                        principalColumn: "RecipesId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_usersIngredients_RecipesId",
                table: "usersIngredients",
                column: "RecipesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "usersIngredients");
        }
    }
}
