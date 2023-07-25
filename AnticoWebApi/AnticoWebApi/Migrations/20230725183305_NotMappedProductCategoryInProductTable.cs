using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnticoWebApi.Migrations
{
    /// <inheritdoc />
    public partial class NotMappedProductCategoryInProductTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductCategories_Id_CategoryIdId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_Id_CategoryIdId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Id_CategoryIdId",
                table: "Products");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id_CategoryIdId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Products_Id_CategoryIdId",
                table: "Products",
                column: "Id_CategoryIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductCategories_Id_CategoryIdId",
                table: "Products",
                column: "Id_CategoryIdId",
                principalTable: "ProductCategories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
