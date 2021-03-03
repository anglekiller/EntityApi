using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityframworkCodeFirst.Migrations
{
    public partial class fixPublisher3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PublisherName",
                table: "Publishers",
                newName: "PublisherName1");

            migrationBuilder.RenameColumn(
                name: "PublisherId",
                table: "Publishers",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "PublisherId1",
                table: "Publishers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PublisherId1",
                table: "Publishers");

            migrationBuilder.RenameColumn(
                name: "PublisherName1",
                table: "Publishers",
                newName: "PublisherName");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Publishers",
                newName: "PublisherId");
        }
    }
}
