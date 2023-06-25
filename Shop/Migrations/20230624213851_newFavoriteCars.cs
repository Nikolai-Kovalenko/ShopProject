using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop.Migrations
{
    public partial class newFavoriteCars : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "shopCartId",
                table: "ShopCartItem",
                newName: "ShopCartId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ShopCartId",
                table: "ShopCartItem",
                newName: "shopCartId");
        }
    }
}
