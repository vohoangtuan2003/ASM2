using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class _2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Author_AuthorId",
                table: "Product");

            migrationBuilder.RenameColumn(
                name: "AuthorId",
                table: "Product",
                newName: "AuthorID");

            migrationBuilder.RenameIndex(
                name: "IX_Product_AuthorId",
                table: "Product",
                newName: "IX_Product_AuthorID");

            migrationBuilder.AddColumn<string>(
                name: "AuthorName",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AuthorName",
                table: "Author",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Author_AuthorID",
                table: "Product",
                column: "AuthorID",
                principalTable: "Author",
                principalColumn: "AuthorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Author_AuthorID",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "AuthorName",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "AuthorName",
                table: "Author");

            migrationBuilder.RenameColumn(
                name: "AuthorID",
                table: "Product",
                newName: "AuthorId");

            migrationBuilder.RenameIndex(
                name: "IX_Product_AuthorID",
                table: "Product",
                newName: "IX_Product_AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Author_AuthorId",
                table: "Product",
                column: "AuthorId",
                principalTable: "Author",
                principalColumn: "AuthorId");
        }
    }
}
