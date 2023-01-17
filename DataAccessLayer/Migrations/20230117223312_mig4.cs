using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Catagorys_CategoryID",
                table: "Blogs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Catagorys",
                table: "Catagorys");

            migrationBuilder.RenameTable(
                name: "Catagorys",
                newName: "Categories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Categories_CategoryID",
                table: "Blogs",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Categories_CategoryID",
                table: "Blogs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Catagorys");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Catagorys",
                table: "Catagorys",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Catagorys_CategoryID",
                table: "Blogs",
                column: "CategoryID",
                principalTable: "Catagorys",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
