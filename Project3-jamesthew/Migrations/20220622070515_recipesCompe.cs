using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project3_jamesthew.Migrations
{
    public partial class recipesCompe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "recipesCompetitions",
                columns: table => new
                {
                    RecipesCompetitionId = table.Column<int>(type: "int", nullable: false)
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
                    ContestId = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    RecipesPic = table.Column<string>(type: "varchar(50)", nullable: false),
                    RecipesTitle = table.Column<string>(type: "varchar(30)", nullable: false),
                    RecipesDescription = table.Column<string>(type: "varchar(30)", nullable: false),
                    UserName = table.Column<string>(type: "varchar(50)", nullable: false),
                    UserEmail = table.Column<string>(type: "varchar(30)", nullable: false),
                    SubmitDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Winner = table.Column<string>(type: "varchar(50)", nullable: false),
                    UserPic = table.Column<string>(type: "varchar(30)", nullable: false),
                    UserDescription = table.Column<string>(type: "varchar(500)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_recipesCompetitions", x => x.RecipesCompetitionId);
                    table.ForeignKey(
                        name: "FK_recipesCompetitions_contests_ContestId",
                        column: x => x.ContestId,
                        principalTable: "contests",
                        principalColumn: "ContestId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_recipesCompetitions_ContestId",
                table: "recipesCompetitions",
                column: "ContestId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "recipesCompetitions");
        }
    }
}
