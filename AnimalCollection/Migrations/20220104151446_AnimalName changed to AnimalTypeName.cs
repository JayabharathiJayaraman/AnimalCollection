using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalCollection.Migrations
{
    public partial class AnimalNamechangedtoAnimalTypeName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AnimalName",
                table: "AnimalTypes",
                newName: "AnimalTypeName");

            migrationBuilder.AddColumn<string>(
                name: "AnimalName",
                table: "Animals",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnimalName",
                table: "Animals");

            migrationBuilder.RenameColumn(
                name: "AnimalTypeName",
                table: "AnimalTypes",
                newName: "AnimalName");
        }
    }
}
