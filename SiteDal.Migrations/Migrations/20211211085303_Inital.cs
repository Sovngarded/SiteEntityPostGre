using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SiteDal.Migrations.Migrations
{
    public partial class Inital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Schedule",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    ScheduleId = table.Column<int>(nullable: false),
                    ScheduleName = table.Column<string>(nullable: true),
                    ScheduleWhen = table.Column<string>(nullable: true),
                    ScheduleWhy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedule", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Schedule");
        }
    }
}
