using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NSLPWebApi.Migrations
{
    public partial class ModifyMenuIdAndAddParameterTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MenuToIngredientOrRecipes");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.CreateTable(
                name: "Parameters",
                columns: table => new
                {
                    ParameterType = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    ParameterValue = table.Column<int>(type: "Int", nullable: false),
                    ParameterString = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ParameterSite = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parameters", x => x.ParameterType);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parameters");

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    MenuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuTypeId = table.Column<int>(type: "int", nullable: false),
                    MenuDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.MenuId);
                    table.ForeignKey(
                        name: "FK_Menus_MenuTypes_MenuTypeId",
                        column: x => x.MenuTypeId,
                        principalTable: "MenuTypes",
                        principalColumn: "MenuTypeId");
                });

            migrationBuilder.CreateTable(
                name: "MenuToIngredientOrRecipes",
                columns: table => new
                {
                    MenuToIngredientOrRecipeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IngredientId = table.Column<int>(type: "int", nullable: true),
                    MeasurementId = table.Column<int>(type: "int", nullable: false),
                    MenuId = table.Column<int>(type: "int", nullable: false),
                    RecipeId = table.Column<int>(type: "int", nullable: true),
                    Attendance = table.Column<int>(type: "int", nullable: false),
                    Leftovers = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QtyMeasurement = table.Column<double>(type: "float", nullable: false),
                    QtyServed = table.Column<double>(type: "float", nullable: false),
                    QuantityOffered = table.Column<double>(type: "float", nullable: false),
                    Temperature = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuToIngredientOrRecipes", x => x.MenuToIngredientOrRecipeId);
                    table.ForeignKey(
                        name: "FK_MenuToIngredientOrRecipes_Ingredients_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "IngredientId");
                    table.ForeignKey(
                        name: "FK_MenuToIngredientOrRecipes_Measurements_MeasurementId",
                        column: x => x.MeasurementId,
                        principalTable: "Measurements",
                        principalColumn: "MeasurementId");
                    table.ForeignKey(
                        name: "FK_MenuToIngredientOrRecipes_Menus_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menus",
                        principalColumn: "MenuId");
                    table.ForeignKey(
                        name: "FK_MenuToIngredientOrRecipes_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "RecipeId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Menus_MenuTypeId",
                table: "Menus",
                column: "MenuTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuToIngredientOrRecipes_IngredientId",
                table: "MenuToIngredientOrRecipes",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuToIngredientOrRecipes_MeasurementId",
                table: "MenuToIngredientOrRecipes",
                column: "MeasurementId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuToIngredientOrRecipes_MenuId",
                table: "MenuToIngredientOrRecipes",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuToIngredientOrRecipes_RecipeId",
                table: "MenuToIngredientOrRecipes",
                column: "RecipeId");
        }
    }
}
