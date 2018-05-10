using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace HackatonData.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Status_Capital",
                table: "Status",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Status_Fee",
                table: "Status",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Sak_Capital",
                table: "Sreg",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Sak_Fee",
                table: "Sreg",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status_Capital",
                table: "Status");

            migrationBuilder.DropColumn(
                name: "Status_Fee",
                table: "Status");

            migrationBuilder.DropColumn(
                name: "Sak_Capital",
                table: "Sreg");

            migrationBuilder.DropColumn(
                name: "Sak_Fee",
                table: "Sreg");
        }
    }
}
