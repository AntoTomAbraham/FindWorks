using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace studentFreelance.Migrations
{
    public partial class bidmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bid");

            migrationBuilder.CreateTable(
                name: "bids",
                columns: table => new
                {
                    bid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    prID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FRemail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    deadline = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    amount = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    desc = table.Column<string>(type: "nvarchar(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bids", x => x.bid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bids");

            migrationBuilder.CreateTable(
                name: "bid",
                columns: table => new
                {
                    bid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FRemail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    amount = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    deadline = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    desc = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    prID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bid", x => x.bid);
                });
        }
    }
}
