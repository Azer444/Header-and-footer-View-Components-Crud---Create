using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkProject.Migrations
{
    public partial class CreateTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 10, 17, 14, 36, 38, 60, DateTimeKind.Local).AddTicks(8272));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 10, 17, 14, 36, 38, 62, DateTimeKind.Local).AddTicks(5963));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 10, 17, 14, 36, 38, 62, DateTimeKind.Local).AddTicks(6026));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 10, 17, 11, 36, 27, 728, DateTimeKind.Local).AddTicks(2930));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 10, 17, 11, 36, 27, 731, DateTimeKind.Local).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 10, 17, 11, 36, 27, 731, DateTimeKind.Local).AddTicks(789));
        }
    }
}
