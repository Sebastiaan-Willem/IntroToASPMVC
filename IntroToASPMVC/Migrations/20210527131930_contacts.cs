using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IntroToASPMVC.Migrations
{
    public partial class contacts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TelephoneNumber = table.Column<int>(type: "int", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HouseNumber = table.Column<int>(type: "int", nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<int>(type: "int", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Contacts_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "DateOfBirth", "Email", "FirstName", "Name", "TelephoneNumber" },
                values: new object[] { 1, new DateTime(1345, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "frodo@baggins.com", "Frodo", "Baggins", 123456789 });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "DateOfBirth", "Email", "FirstName", "Name", "TelephoneNumber" },
                values: new object[] { 2, new DateTime(1305, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "bilbo@baggins.com", "Bilbo", "Baggins", 321012345 });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "DateOfBirth", "Email", "FirstName", "Name", "TelephoneNumber" },
                values: new object[] { 3, new DateTime(1178, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "gandalf@thewizard.com", "Gandalf", "the Grey", 987654321 });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "ContactId", "HouseNumber", "PostalCode", "Street", "Unit" },
                values: new object[] { 1, "The Shire", 1, 15, 4500, "TestLane", "A" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "ContactId", "HouseNumber", "PostalCode", "Street", "Unit" },
                values: new object[] { 2, "Rivendell", 2, 146, 3500, "That one room next to the waterfall", "B" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "ContactId", "HouseNumber", "PostalCode", "Street", "Unit" },
                values: new object[] { 3, "Minas Tirith", 3, 813, 2500, "7th level", "C" });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_ContactId",
                table: "Addresses",
                column: "ContactId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Contacts");
        }
    }
}
