using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace summer.API.Migrations
{
    public partial class Note2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DateTo",
                table: "Notes",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "DateFrom",
                table: "Notes",
                nullable: true,
                oldClrType: typeof(DateTime));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateTo",
                table: "Notes",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateFrom",
                table: "Notes",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
