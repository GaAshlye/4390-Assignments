using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TheCodingClub2.Migrations
{
    public partial class AddProjectCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ProjectID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PName = table.Column<string>(nullable: true),
                    dd = table.Column<DateTime>(nullable: false),
                    compname = table.Column<string>(nullable: true),
                    teamLead = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ProjectID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Projects");
        }
    }
}
