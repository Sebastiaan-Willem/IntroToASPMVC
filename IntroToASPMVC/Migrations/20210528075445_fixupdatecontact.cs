using Microsoft.EntityFrameworkCore.Migrations;

namespace IntroToASPMVC.Migrations
{
    public partial class fixupdatecontact : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Contacts_ContactId",
                table: "Addresses");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_ContactId",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "ContactId",
                table: "Addresses");

            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "Contacts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddressId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddressId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddressId",
                value: 3);

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_AddressId",
                table: "Contacts",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Addresses_AddressId",
                table: "Contacts",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Addresses_AddressId",
                table: "Contacts");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_AddressId",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Contacts");

            migrationBuilder.AddColumn<int>(
                name: "ContactId",
                table: "Addresses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "ContactId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "ContactId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 3,
                column: "ContactId",
                value: 3);

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_ContactId",
                table: "Addresses",
                column: "ContactId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Contacts_ContactId",
                table: "Addresses",
                column: "ContactId",
                principalTable: "Contacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
