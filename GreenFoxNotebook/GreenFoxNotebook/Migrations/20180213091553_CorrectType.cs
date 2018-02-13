using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace GreenFoxNotebook.Migrations
{
    public partial class CorrectType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Reporter",
                table: "Tickets",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Reporter",
                table: "Tickets",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
