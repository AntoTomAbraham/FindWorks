using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace studentFreelance.Migrations
{
    public partial class bidmigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "bid",
                columns: table => new
                {
                    bidId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    prID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FRemail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    deadline = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    amount = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    desc = table.Column<string>(type: "nvarchar(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bid", x => x.bidId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bid");
        }
    }
}
