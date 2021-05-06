using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UploadDoc.Data.Migrations
{
    public partial class CommonFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreaded",
                table: "Pessoas",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "Pessoas",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Pessoas",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateCreaded",
                table: "Pessoas");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "Pessoas");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Pessoas");
        }
    }
}
