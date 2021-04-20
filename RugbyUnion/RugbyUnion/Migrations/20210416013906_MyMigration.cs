using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RugbyUnion.Migrations
{
    public partial class MyMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    PlayerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamId = table.Column<int>(type: "int", nullable: false),
                    PlayerName = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    BirthDate = table.Column<string>(type: "varchar(10)", nullable: true),
                    Height = table.Column<string>(type: "varchar(100)", nullable: true),
                    Weight = table.Column<string>(type: "varchar(100)", nullable: true),
                    PlaceofBirth = table.Column<string>(type: "varchar(10)", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(100)", nullable: true),
                    CreateTime = table.Column<string>(type: "varchar(100)", nullable: true),
                    IsActive = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.PlayerId);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    TeamId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamName = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    Ground = table.Column<string>(type: "varchar(10)", nullable: true),
                    Coach = table.Column<string>(type: "varchar(100)", nullable: true),
                    FoundedYear = table.Column<string>(type: "varchar(100)", nullable: true),
                    Region = table.Column<string>(type: "varchar(10)", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(100)", nullable: true),
                    CreateTime = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.TeamId);
                });

            migrationBuilder.CreateTable(
                name: "UnionAdmin",
                columns: table => new
                {
                    AdminId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Password = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnionAdmin", x => x.AdminId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "UnionAdmin");
        }
    }
}
