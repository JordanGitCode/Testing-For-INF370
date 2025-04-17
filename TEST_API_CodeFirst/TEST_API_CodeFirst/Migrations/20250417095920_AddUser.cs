using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TEST_API_CodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class AddUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    User_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title_ID = table.Column<int>(type: "int", nullable: true),
                    Race_ID = table.Column<int>(type: "int", nullable: true),
                    Gender_ID = table.Column<int>(type: "int", nullable: true),
                    Role_ID = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IDNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CurrentPosition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title_ID1 = table.Column<int>(type: "int", nullable: true),
                    Race_ID1 = table.Column<int>(type: "int", nullable: true),
                    Gender_ID1 = table.Column<int>(type: "int", nullable: true),
                    Role_ID1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.User_ID);
                    table.ForeignKey(
                        name: "FK_Users_Genders_Gender_ID1",
                        column: x => x.Gender_ID1,
                        principalTable: "Genders",
                        principalColumn: "Gender_ID");
                    table.ForeignKey(
                        name: "FK_Users_Races_Race_ID1",
                        column: x => x.Race_ID1,
                        principalTable: "Races",
                        principalColumn: "Race_ID");
                    table.ForeignKey(
                        name: "FK_Users_Roles_Role_ID1",
                        column: x => x.Role_ID1,
                        principalTable: "Roles",
                        principalColumn: "Role_ID");
                    table.ForeignKey(
                        name: "FK_Users_Titles_Title_ID1",
                        column: x => x.Title_ID1,
                        principalTable: "Titles",
                        principalColumn: "Title_ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_Gender_ID1",
                table: "Users",
                column: "Gender_ID1");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Race_ID1",
                table: "Users",
                column: "Race_ID1");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Role_ID1",
                table: "Users",
                column: "Role_ID1");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Title_ID1",
                table: "Users",
                column: "Title_ID1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
