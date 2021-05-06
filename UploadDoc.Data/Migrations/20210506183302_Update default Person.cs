using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UploadDoc.Data.Migrations
{
    public partial class UpdatedefaultPerson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pessoas",
                keyColumn: "PessoaID",
                keyValue: 1,
                columns: new[] { "DateCreaded", "IsActive" },
                values: new object[] { new DateTime(2021, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), true });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pessoas",
                keyColumn: "PessoaID",
                keyValue: 1,
                columns: new[] { "DateCreaded", "IsActive" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false });
        }
    }
}
