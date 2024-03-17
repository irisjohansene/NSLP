using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NSLPWebApi.Migrations
{
    public partial class DropIngredientTypeIdOnIngredientTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ingredients_IngredientTypes_IngredientSubTypeId",
                table: "Ingredients");

            migrationBuilder.DropIndex(
                name: "IX_Ingredients_IngredientSubTypeId",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "IngredientSubTypeId",
                table: "Ingredients");

            migrationBuilder.AlterColumn<int>(
            name: "IngredientId",
            table: "MenuToIngredientOrRecipes",
            nullable: true,
            oldClrType: typeof(int),
            oldType: "int");

            migrationBuilder.AlterColumn<int>(
            name: "RecipeId",
            table: "MenuToIngredientOrRecipes",
            nullable: true,
            oldClrType: typeof(int),
            oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IngredientSubTypeId",
                table: "Ingredients",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_IngredientSubTypeId",
                table: "Ingredients",
                column: "IngredientSubTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredients_IngredientTypes_IngredientSubTypeId",
                table: "Ingredients",
                column: "IngredientSubTypeId",
                principalTable: "IngredientTypes",
                principalColumn: "IngredientTypeId");
        }
    }
}
