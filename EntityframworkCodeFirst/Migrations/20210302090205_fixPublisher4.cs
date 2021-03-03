using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityframworkCodeFirst.Migrations
{
    public partial class fixPublisher4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PublisherId1",
                table: "Publishers");

            migrationBuilder.RenameColumn(
                name: "PublisherName1",
                table: "Publishers",
                newName: "Price1");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Publishers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Publishers");

            migrationBuilder.RenameColumn(
                name: "Price1",
                table: "Publishers",
                newName: "PublisherName1");

            migrationBuilder.AddColumn<int>(
                name: "PublisherId1",
                table: "Publishers",
                nullable: true);
        }
    }
}
