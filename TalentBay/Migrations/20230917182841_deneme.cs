using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace TalentBay.Migrations
{
    public partial class deneme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "VarChar(20)", nullable: false),
                    Mail = table.Column<string>(type: "VarChar(50)", nullable: false),
                    Password = table.Column<string>(type: "VarChar(20)", nullable: false),
                    ConfirmPassword = table.Column<string>(type: "VarChar(20)", nullable: true), 
                    IsStudent = table.Column<bool>(type: "bit", nullable: false) 
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
