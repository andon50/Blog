using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Categorys_CategoryId",
                table: "Blogs");

            migrationBuilder.DeleteData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: "C");

            migrationBuilder.DeleteData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: "J");

            migrationBuilder.AlterColumn<string>(
                name: "CategoryId",
                table: "Blogs",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.InsertData(
                table: "Categorys",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { "P", "Politics" },
                    { "E", "Economy" },
                    { "W", "Weather" },
                    { "S", "Sports" }
                });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "BlogId",
                keyValue: 1,
                columns: new[] { "BlogPost", "CategoryId" },
                values: new object[] { "Senaste nytt från Ekot ", "P" });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "BlogId",
                keyValue: 2,
                columns: new[] { "BlogPost", "CategoryId" },
                values: new object[] { "TT nyheter i sammanfattning ... ", "P" });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "BlogId",
                keyValue: 3,
                columns: new[] { "BlogPost", "CategoryId" },
                values: new object[] { "Änglarna gjorde mål på Sankte Pär i Pärleporten ... ", "S" });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "BlogId",
                keyValue: 4,
                columns: new[] { "BlogPost", "CategoryId" },
                values: new object[] { "Vädret mycket regn, åska och det blåser smådj_vlar", "W" });

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Categorys_CategoryId",
                table: "Blogs",
                column: "CategoryId",
                principalTable: "Categorys",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Categorys_CategoryId",
                table: "Blogs");

            migrationBuilder.DeleteData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: "E");

            migrationBuilder.DeleteData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: "P");

            migrationBuilder.DeleteData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: "S");

            migrationBuilder.DeleteData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: "W");

            migrationBuilder.AlterColumn<string>(
                name: "CategoryId",
                table: "Blogs",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Categorys",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { "C", "C Sharp" });

            migrationBuilder.InsertData(
                table: "Categorys",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { "J", "Java" });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "BlogId",
                keyValue: 1,
                columns: new[] { "BlogPost", "CategoryId" },
                values: new object[] { "Älskar att koda i C sharp ... ", "C" });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "BlogId",
                keyValue: 2,
                columns: new[] { "BlogPost", "CategoryId" },
                values: new object[] { "Älskar att koda i Java ... ", "J" });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "BlogId",
                keyValue: 3,
                columns: new[] { "BlogPost", "CategoryId" },
                values: new object[] { "Tycker inte om att koda i C sharp ... ", "C" });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "BlogId",
                keyValue: 4,
                columns: new[] { "BlogPost", "CategoryId" },
                values: new object[] { "Tycker inte om att koda i Java ... men gillar Java kaffe ", "J" });

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Categorys_CategoryId",
                table: "Blogs",
                column: "CategoryId",
                principalTable: "Categorys",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
