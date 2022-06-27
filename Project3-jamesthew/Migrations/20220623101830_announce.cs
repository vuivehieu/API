using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project3_jamesthew.Migrations
{
    public partial class announce : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "announces",
                columns: table => new
                {
                    AnnounceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnnounceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "varchar(50)", nullable: false),
                    ContestId = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    RecipeCompetitionId = table.Column<int>(type: "int", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_announces", x => x.AnnounceId);
                    table.ForeignKey(
                        name: "FK_announces_contests_ContestId",
                        column: x => x.ContestId,
                        principalTable: "contests",
                        principalColumn: "ContestId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_announces_recipesCompetitions_RecipeCompetitionId",
                        column: x => x.RecipeCompetitionId,
                        principalTable: "recipesCompetitions",
                        principalColumn: "RecipesCompetitionId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_announces_ContestId",
                table: "announces",
                column: "ContestId");

            migrationBuilder.CreateIndex(
                name: "IX_announces_RecipeCompetitionId",
                table: "announces",
                column: "RecipeCompetitionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "announces");
        }
    }
}
