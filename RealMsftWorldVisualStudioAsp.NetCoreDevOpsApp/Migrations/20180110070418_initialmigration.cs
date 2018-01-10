using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace RealMsftWorldVisualStudioAsp.NetCoreDevOpsApp.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContactInfos",
                columns: table => new
                {
                    Message = table.Column<string>(nullable: false),
                    Age = table.Column<int>(nullable: false),
                    Birthday = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    LastName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactInfos", x => x.Message);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactInfos");
        }
    }
}
