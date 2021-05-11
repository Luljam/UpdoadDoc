using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UploadDoc.Data.Migrations
{
    public partial class AddUserandAuthentication : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreaded",
                table: "Pessoas",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 10, 21, 30, 29, 6, DateTimeKind.Local).AddTicks(4817),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 5, 10, 12, 46, 40, 665, DateTimeKind.Local).AddTicks(9329));

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreaded = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2021, 5, 10, 21, 30, 29, 11, DateTimeKind.Local).AddTicks(462)),
                    DateUpdated = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false, defaultValue: true),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreaded",
                table: "Pessoas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 10, 12, 46, 40, 665, DateTimeKind.Local).AddTicks(9329),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 5, 10, 21, 30, 29, 6, DateTimeKind.Local).AddTicks(4817));
        }
    }
}
