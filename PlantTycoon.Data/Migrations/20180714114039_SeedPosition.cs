using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace PlantTycoon.Data.Migrations
{
    public partial class SeedPosition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PositionColumn",
                table: "Seeds",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PositionRow",
                table: "Seeds",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PositionSection",
                table: "Seeds",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PositionColumn",
                table: "Seeds");

            migrationBuilder.DropColumn(
                name: "PositionRow",
                table: "Seeds");

            migrationBuilder.DropColumn(
                name: "PositionSection",
                table: "Seeds");
        }
    }
}
