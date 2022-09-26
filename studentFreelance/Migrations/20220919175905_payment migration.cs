using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace studentFreelance.Migrations
{
    public partial class paymentmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "prID",
                table: "test",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "prID",
                table: "test");
        }
    }
}
