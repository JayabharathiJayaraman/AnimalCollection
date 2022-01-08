using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalCollection.Migrations
{
    public partial class Seed_Data_For_Animal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "AnimalName",
                table: "Animals",
                type: "longtext",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "AnimalTypes",
                columns: new[] { "AnimalTypeId", "AnimalTypeName" },
                values: new object[] { 1, "AnimalTypeName 1" });

            migrationBuilder.InsertData(
                table: "AnimalTypes",
                columns: new[] { "AnimalTypeId", "AnimalTypeName" },
                values: new object[] { 2, "AnimalTypeName 2" });

            migrationBuilder.InsertData(
                table: "AnimalTypes",
                columns: new[] { "AnimalTypeId", "AnimalTypeName" },
                values: new object[] { 3, "AnimalTypeName 3" });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "AnimalName", "AnimalTypeId", "CreatedDate" },
                values: new object[,]
                {
                    { 1, "AnimalName 1", 1, new DateTime(2022, 1, 8, 2, 37, 27, 624, DateTimeKind.Local).AddTicks(1780) },
                    { 2, "AnimalName 2", 2, new DateTime(2022, 1, 8, 2, 37, 27, 624, DateTimeKind.Local).AddTicks(4510) },
                    { 3, "AnimalName 3", 2, new DateTime(2022, 1, 8, 2, 37, 27, 624, DateTimeKind.Local).AddTicks(4710) },
                    { 4, "AnimalName 4", 3, new DateTime(2022, 1, 8, 2, 37, 27, 624, DateTimeKind.Local).AddTicks(4940) },
                    { 5, "AnimalName 5", 3, new DateTime(2022, 1, 8, 2, 37, 27, 624, DateTimeKind.Local).AddTicks(4940) },
                    { 6, "AnimalName 6", 3, new DateTime(2022, 1, 8, 2, 37, 27, 624, DateTimeKind.Local).AddTicks(4940) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AnimalTypes",
                keyColumn: "AnimalTypeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AnimalTypes",
                keyColumn: "AnimalTypeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AnimalTypes",
                keyColumn: "AnimalTypeId",
                keyValue: 3);

            migrationBuilder.AlterColumn<string>(
                name: "AnimalName",
                table: "Animals",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
