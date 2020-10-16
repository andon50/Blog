using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Migrations
{
    public partial class changednameofGetDateTimetoTimeStamp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GetDateTime",
                table: "Blogs");

            migrationBuilder.AddColumn<string>(
                name: "TimeStamp",
                table: "Blogs",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "TimeStamp",
                value: "2020-06-01");

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "TimeStamp",
                value: "2020-06-02");

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "TimeStamp",
                value: "2020-06-03");

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "TimeStamp",
                value: "2020-06-04");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TimeStamp",
                table: "Blogs");

            migrationBuilder.AddColumn<string>(
                name: "GetDateTime",
                table: "Blogs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "GetDateTime",
                value: "2020-06-01");

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "GetDateTime",
                value: "2020-06-02");

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "GetDateTime",
                value: "2020-06-03");

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "BlogId",
                keyValue: 4,
                column: "GetDateTime",
                value: "2020-06-04");
        }
    }
}
