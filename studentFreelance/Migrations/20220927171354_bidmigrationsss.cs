using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace studentFreelance.Migrations
{
    public partial class bidmigrationsss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "bidId",
                table: "bid",
                newName: "bid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "bid",
                table: "bid",
                newName: "bidId");
        }
    }
}
