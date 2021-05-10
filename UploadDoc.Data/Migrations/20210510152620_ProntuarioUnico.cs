using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UploadDoc.Data.Migrations
{
    public partial class ProntuarioUnico : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreaded",
                table: "Pessoas",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 10, 12, 26, 19, 966, DateTimeKind.Local).AddTicks(9485),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 5, 6, 17, 47, 49, 238, DateTimeKind.Local).AddTicks(8674));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreaded",
                table: "Pessoas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 6, 17, 47, 49, 238, DateTimeKind.Local).AddTicks(8674),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 5, 10, 12, 26, 19, 966, DateTimeKind.Local).AddTicks(9485));
        }
    }
}
