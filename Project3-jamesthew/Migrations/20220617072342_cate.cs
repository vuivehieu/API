using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project3_jamesthew.Migrations
{
    public partial class cate : Migration
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "categories");
        }
    }
}
