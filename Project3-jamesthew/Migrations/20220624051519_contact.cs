using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project3_jamesthew.Migrations
{
    public partial class contact : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "contacts",
                columns: table => new
                {
                    ContactId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "varchar(50)", nullable: false),
                    UserEmail = table.Column<string>(type: "varchar(50)", nullable: false),
                    UserNumber = table.Column<string>(type: "varchar(20)", nullable: false),
                    UserMessage = table.Column<string>(type: "varchar(1500)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contacts", x => x.ContactId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "contacts");
        }
    }
}
