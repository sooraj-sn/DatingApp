using Microsoft.EntityFrameworkCore.Migrations;

namespace DatingApp.API.Data.Migrations
{
    public partial class UserPasswordAdded1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PaswordSalt",
                table: "Users",
                newName: "PasswordSalt");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PasswordSalt",
                table: "Users",
                newName: "PaswordSalt");
        }
    }
}
