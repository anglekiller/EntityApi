using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityframworkCodeFirst.Migrations
{
    public partial class _11x : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price1",
                table: "Publishers",
                newName: "State");

            migrationBuilder.AddColumn<int>(
                name: "publisherId",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Publishers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Publishers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_publisherId",
                table: "User",
                column: "publisherId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Publishers_publisherId",
                table: "User",
                column: "publisherId",
                principalTable: "Publishers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Publishers_publisherId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_publisherId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "publisherId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Publishers");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Publishers");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "Publishers",
                newName: "Price1");
        }
    }
}
