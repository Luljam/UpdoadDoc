using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UploadDoc.Data.Migrations
{
    public partial class unico : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreaded",
                table: "Pessoas",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 10, 12, 46, 40, 665, DateTimeKind.Local).AddTicks(9329),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 5, 10, 12, 26, 19, 966, DateTimeKind.Local).AddTicks(9485));

            migrationBuilder.CreateIndex(
                name: "IX_Pessoas_Prontuario",
                table: "Pessoas",
                column: "Prontuario",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Pessoas_Prontuario",
                table: "Pessoas");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreaded",
                table: "Pessoas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 10, 12, 26, 19, 966, DateTimeKind.Local).AddTicks(9485),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 5, 10, 12, 46, 40, 665, DateTimeKind.Local).AddTicks(9329));
        }
    }
}
