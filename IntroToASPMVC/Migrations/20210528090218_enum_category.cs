using Microsoft.EntityFrameworkCore.Migrations;

namespace IntroToASPMVC.Migrations
{
    public partial class enum_category : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Category",
                table: "Contacts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Category", "ProfilePictureUrl" },
                values: new object[] { 2, "http://placeimg.com/200/200/animals" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Category", "ProfilePictureUrl" },
                values: new object[] { 2, "http://placeimg.com/200/200/animals" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Category", "ProfilePictureUrl" },
                values: new object[] { 2, "http://placeimg.com/200/200/animals" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Contacts");

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 1,
                column: "ProfilePictureUrl",
                value: "https://static.wikia.nocookie.net/lotr/images/5/54/Untitledjk.png/revision/latest/scale-to-width-down/350?cb=20130313174543");

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 2,
                column: "ProfilePictureUrl",
                value: "https://static.wikia.nocookie.net/lotr/images/6/68/Bilbo_baggins.jpg/revision/latest/scale-to-width-down/289?cb=20130202022550");

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 3,
                column: "ProfilePictureUrl",
                value: "https://static.wikia.nocookie.net/lotr/images/e/e7/Gandalf_the_Grey.jpg/revision/latest/scale-to-width-down/350?cb=20121110131754");
        }
    }
}
