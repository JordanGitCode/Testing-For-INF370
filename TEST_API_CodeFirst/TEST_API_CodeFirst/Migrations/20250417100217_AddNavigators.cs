using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TEST_API_CodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class AddNavigators : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Genders_Gender_ID1",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Races_Race_ID1",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_Role_ID1",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Titles_Title_ID1",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_Gender_ID1",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_Race_ID1",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_Role_ID1",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_Title_ID1",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Gender_ID1",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Race_ID1",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Role_ID1",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Title_ID1",
                table: "Users");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Gender_ID",
                table: "Users",
                column: "Gender_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Race_ID",
                table: "Users",
                column: "Race_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Role_ID",
                table: "Users",
                column: "Role_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Title_ID",
                table: "Users",
                column: "Title_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Genders_Gender_ID",
                table: "Users",
                column: "Gender_ID",
                principalTable: "Genders",
                principalColumn: "Gender_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Races_Race_ID",
                table: "Users",
                column: "Race_ID",
                principalTable: "Races",
                principalColumn: "Race_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roles_Role_ID",
                table: "Users",
                column: "Role_ID",
                principalTable: "Roles",
                principalColumn: "Role_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Titles_Title_ID",
                table: "Users",
                column: "Title_ID",
                principalTable: "Titles",
                principalColumn: "Title_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Genders_Gender_ID",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Races_Race_ID",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_Role_ID",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Titles_Title_ID",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_Gender_ID",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_Race_ID",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_Role_ID",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_Title_ID",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "Gender_ID1",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Race_ID1",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Role_ID1",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Title_ID1",
                table: "Users",
                type: "int",
                nullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Genders_Gender_ID1",
                table: "Users",
                column: "Gender_ID1",
                principalTable: "Genders",
                principalColumn: "Gender_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Races_Race_ID1",
                table: "Users",
                column: "Race_ID1",
                principalTable: "Races",
                principalColumn: "Race_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roles_Role_ID1",
                table: "Users",
                column: "Role_ID1",
                principalTable: "Roles",
                principalColumn: "Role_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Titles_Title_ID1",
                table: "Users",
                column: "Title_ID1",
                principalTable: "Titles",
                principalColumn: "Title_ID");
        }
    }
}
