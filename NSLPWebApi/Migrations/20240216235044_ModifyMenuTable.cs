using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NSLPWebApi.Migrations
{
    public partial class ModifyMenuTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Menu_MenuTypes_MenuTypeId",
                table: "Menu");

            migrationBuilder.DropForeignKey(
                name: "FK_MenuToIngredientOrRecipes_Menu_MenuId",
                table: "MenuToIngredientOrRecipes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Menu",
                table: "Menu");

            migrationBuilder.RenameTable(
                name: "Menu",
                newName: "Menus");

            migrationBuilder.RenameIndex(
                name: "IX_Menu_MenuTypeId",
                table: "Menus",
                newName: "IX_Menus_MenuTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Menus",
                table: "Menus",
                column: "MenuId");

            migrationBuilder.AddForeignKey(
                name: "FK_Menus_MenuTypes_MenuTypeId",
                table: "Menus",
                column: "MenuTypeId",
                principalTable: "MenuTypes",
                principalColumn: "MenuTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_MenuToIngredientOrRecipes_Menus_MenuId",
                table: "MenuToIngredientOrRecipes",
                column: "MenuId",
                principalTable: "Menus",
                principalColumn: "MenuId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Menus_MenuTypes_MenuTypeId",
                table: "Menus");

            migrationBuilder.DropForeignKey(
                name: "FK_MenuToIngredientOrRecipes_Menus_MenuId",
                table: "MenuToIngredientOrRecipes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Menus",
                table: "Menus");

            migrationBuilder.RenameTable(
                name: "Menus",
                newName: "Menu");

            migrationBuilder.RenameIndex(
                name: "IX_Menus_MenuTypeId",
                table: "Menu",
                newName: "IX_Menu_MenuTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Menu",
                table: "Menu",
                column: "MenuId");

            migrationBuilder.AddForeignKey(
                name: "FK_Menu_MenuTypes_MenuTypeId",
                table: "Menu",
                column: "MenuTypeId",
                principalTable: "MenuTypes",
                principalColumn: "MenuTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MenuToIngredientOrRecipes_Menu_MenuId",
                table: "MenuToIngredientOrRecipes",
                column: "MenuId",
                principalTable: "Menu",
                principalColumn: "MenuId");
        }
    }
}
