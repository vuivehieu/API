using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project3_jamesthew.Migrations
{
    public partial class tipsE : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tipsEntities",
                columns: table => new
                {
                    TipsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipsTitle = table.Column<string>(type: "varchar(100)", nullable: false),
                    TipsDescription = table.Column<string>(type: "varchar(250)", nullable: false),
                    TipsImage = table.Column<string>(type: "varchar(1500)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipsEntities", x => x.TipsId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tipsEntities");
        }
    }
}
