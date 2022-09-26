using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace studentFreelance.Migrations
{
    public partial class projectmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "project",
                columns: table => new
                {
                    prID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    title = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    desc = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    amount = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    deadline = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    status = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_project", x => x.prID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "project");
        }
    }
}
