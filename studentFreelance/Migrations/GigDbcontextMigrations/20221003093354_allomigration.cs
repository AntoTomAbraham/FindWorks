using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace studentFreelance.Migrations.GigDbcontextMigrations
{
    public partial class allomigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "allo",
                columns: table => new
                {
                    allId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    prID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FRemail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    deadline = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    status = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    dealDate = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_allo", x => x.allId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "allo");
        }
    }
}
