using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project3_jamesthew.Migrations
{
    public partial class faq : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "faqs",
                columns: table => new
                {
                    FaqId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FaqQuestion = table.Column<string>(type: "varchar(1500)", nullable: false),
                    FaqAns = table.Column<string>(type: "varchar(1500)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_faqs", x => x.FaqId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "faqs");
        }
    }
}
