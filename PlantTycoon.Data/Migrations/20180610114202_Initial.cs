using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace PlantTycoon.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FlowerFormulas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FlowerA = table.Column<int>(nullable: false),
                    FlowerB = table.Column<int>(nullable: false),
                    InProgress = table.Column<bool>(nullable: false),
                    Result = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlowerFormulas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StemFormulas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InProgress = table.Column<bool>(nullable: false),
                    StemA = table.Column<int>(nullable: false),
                    StemB = table.Column<int>(nullable: false),
                    Result = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StemFormulas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FlowerFormulas");

            migrationBuilder.DropTable(
                name: "StemFormulas");
        }
    }
}
