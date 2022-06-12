﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Model.Migrations
{
    public partial class RatingPrecision : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Rating",
                table: "Coments",
                type: "decimal(2,2)",
                precision: 2,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(2)",
                oldPrecision: 2);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Rating",
                table: "Coments",
                type: "decimal(2)",
                precision: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(2,2)",
                oldPrecision: 2,
                oldScale: 2);
        }
    }
}
