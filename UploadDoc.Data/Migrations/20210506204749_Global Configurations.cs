using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UploadDoc.Data.Migrations
{
    public partial class GlobalConfigurations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Pessoas",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreaded",
                table: "Pessoas",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 6, 17, 47, 49, 238, DateTimeKind.Local).AddTicks(8674),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Pessoas",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreaded",
                table: "Pessoas",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 5, 6, 17, 47, 49, 238, DateTimeKind.Local).AddTicks(8674));
        }
    }
}
