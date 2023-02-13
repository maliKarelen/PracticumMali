using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class createData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "ChildOfUser",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "ChildOfUser",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ChildOfUser_UserId",
                table: "ChildOfUser",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ChildOfUser_User_UserId",
                table: "ChildOfUser",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChildOfUser_User_UserId",
                table: "ChildOfUser");

            migrationBuilder.DropIndex(
                name: "IX_ChildOfUser_UserId",
                table: "ChildOfUser");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "ChildOfUser");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ChildOfUser");
        }
    }
}
