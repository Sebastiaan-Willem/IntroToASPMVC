using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IntroToASPMVC.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Genres = table.Column<int>(type: "int", nullable: false),
                    YearOfRelease = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genres", "Rating", "Title", "YearOfRelease" },
                values: new object[,]
                {
                    { 1, "There is no spoon etc", 0, 8, "The Matrix", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Space surfing with pirates", 2, 10, "Treasure Planet", new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Lion family drama", 2, 9, "The Lion King", new DateTime(1994, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Hasn't happened yet so who knows?", 6, 10, "Back to the Future: The actual Future", new DateTime(2054, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
