using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalCollection.Migrations
{
    public partial class Seededdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 1, 8, 22, 10, 56, 228, DateTimeKind.Local).AddTicks(7540));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 1, 8, 22, 10, 56, 229, DateTimeKind.Local).AddTicks(70));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 1, 8, 22, 10, 56, 229, DateTimeKind.Local).AddTicks(140));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 1, 8, 22, 10, 56, 229, DateTimeKind.Local).AddTicks(140));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 1, 8, 22, 10, 56, 229, DateTimeKind.Local).AddTicks(150));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 1, 8, 22, 10, 56, 229, DateTimeKind.Local).AddTicks(150));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 1, 8, 2, 37, 27, 624, DateTimeKind.Local).AddTicks(1780));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 1, 8, 2, 37, 27, 624, DateTimeKind.Local).AddTicks(4510));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 1, 8, 2, 37, 27, 624, DateTimeKind.Local).AddTicks(4710));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 1, 8, 2, 37, 27, 624, DateTimeKind.Local).AddTicks(4940));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 1, 8, 2, 37, 27, 624, DateTimeKind.Local).AddTicks(4940));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 1, 8, 2, 37, 27, 624, DateTimeKind.Local).AddTicks(4940));
        }
    }
}
