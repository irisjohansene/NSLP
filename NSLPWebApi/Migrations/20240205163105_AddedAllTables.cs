using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NSLPWebApi.Migrations
{
    public partial class AddedAllTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    DocumentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsRequired = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.DocumentId);
                });

            migrationBuilder.CreateTable(
                name: "Measurements",
                columns: table => new
                {
                    MeasurementId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MeasurementName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Measurements", x => x.MeasurementId);
                });

            migrationBuilder.CreateTable(
                name: "MenuTypes",
                columns: table => new
                {
                    MenuTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuTypes", x => x.MenuTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    From = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Till = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Completed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    ProductCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.ProductCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    AccountId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SFAName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RAName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AmountOfStudents = table.Column<int>(type: "int", nullable: false),
                    CEPFreeReduced = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.AccountId);
                });

            migrationBuilder.CreateTable(
                name: "Vendors",
                columns: table => new
                {
                    VendorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VendorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendors", x => x.VendorId);
                });

            migrationBuilder.CreateTable(
                name: "IngredientTypes",
                columns: table => new
                {
                    IngredientTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IngredientTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MinPerDay = table.Column<double>(type: "float", nullable: false),
                    MPDM = table.Column<int>(type: "int", nullable: false),
                    MinPerWeek = table.Column<double>(type: "float", nullable: false),
                    MPWM = table.Column<int>(type: "int", nullable: false),
                    MaxPerDay = table.Column<double>(type: "float", nullable: false),
                    MXDM = table.Column<int>(type: "int", nullable: false),
                    MaxPerWeek = table.Column<double>(type: "float", nullable: false),
                    MXWM = table.Column<int>(type: "int", nullable: false),
                    StudentAge = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MenuTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientTypes", x => x.IngredientTypeId);
                    table.ForeignKey(
                        name: "FK_IngredientTypes_Measurements_MPDM",
                        column: x => x.MPDM,
                        principalTable: "Measurements",
                        principalColumn: "MeasurementId");
                    table.ForeignKey(
                        name: "FK_IngredientTypes_Measurements_MPWM",
                        column: x => x.MPWM,
                        principalTable: "Measurements",
                        principalColumn: "MeasurementId");
                    table.ForeignKey(
                        name: "FK_IngredientTypes_Measurements_MXDM",
                        column: x => x.MXDM,
                        principalTable: "Measurements",
                        principalColumn: "MeasurementId");
                    table.ForeignKey(
                        name: "FK_IngredientTypes_Measurements_MXWM",
                        column: x => x.MXWM,
                        principalTable: "Measurements",
                        principalColumn: "MeasurementId");
                    table.ForeignKey(
                        name: "FK_IngredientTypes_MenuTypes_MenuTypeId",
                        column: x => x.MenuTypeId,
                        principalTable: "MenuTypes",
                        principalColumn: "MenuTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    MenuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MenuTypeId = table.Column<int>(type: "int", nullable: false)
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
                name: "Recipes",
                columns: table => new
                {
                    RecipeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecipeName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Hot = table.Column<bool>(type: "bit", nullable: false),
                    Cold = table.Column<bool>(type: "bit", nullable: false),
                    ProductCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.RecipeId);
                    table.ForeignKey(
                        name: "FK_Recipes_ProductCategories_ProductCategoryId",
                        column: x => x.ProductCategoryId,
                        principalTable: "ProductCategories",
                        principalColumn: "ProductCategoryId");
                });

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    IngredientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    AmountPerServing = table.Column<double>(type: "float", nullable: false),
                    APSM = table.Column<int>(type: "int", nullable: false),
                    AmountPerUnit = table.Column<double>(type: "float", nullable: false),
                    APUM = table.Column<int>(type: "int", nullable: false),
                    AmountPerBulkUnit = table.Column<double>(type: "float", nullable: false),
                    APBM = table.Column<int>(type: "int", nullable: false),
                    Sodiummg = table.Column<double>(type: "float", nullable: false),
                    MadeInUSA = table.Column<bool>(type: "bit", nullable: false),
                    Hot = table.Column<bool>(type: "bit", nullable: false),
                    Cold = table.Column<bool>(type: "bit", nullable: false),
                    IngredientTypeId = table.Column<int>(type: "int", nullable: false),
                    IngredientSubTypeId = table.Column<int>(type: "int", nullable: false),
                    ProductCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.IngredientId);
                    table.ForeignKey(
                        name: "FK_Ingredients_IngredientTypes_IngredientSubTypeId",
                        column: x => x.IngredientSubTypeId,
                        principalTable: "IngredientTypes",
                        principalColumn: "IngredientTypeId");
                    table.ForeignKey(
                        name: "FK_Ingredients_IngredientTypes_IngredientTypeId",
                        column: x => x.IngredientTypeId,
                        principalTable: "IngredientTypes",
                        principalColumn: "IngredientTypeId");
                    table.ForeignKey(
                        name: "FK_Ingredients_Measurements_APBM",
                        column: x => x.APBM,
                        principalTable: "Measurements",
                        principalColumn: "MeasurementId");
                    table.ForeignKey(
                        name: "FK_Ingredients_Measurements_APSM",
                        column: x => x.APSM,
                        principalTable: "Measurements",
                        principalColumn: "MeasurementId");
                    table.ForeignKey(
                        name: "FK_Ingredients_Measurements_APUM",
                        column: x => x.APUM,
                        principalTable: "Measurements",
                        principalColumn: "MeasurementId");
                    table.ForeignKey(
                        name: "FK_Ingredients_ProductCategories_ProductCategoryId",
                        column: x => x.ProductCategoryId,
                        principalTable: "ProductCategories",
                        principalColumn: "ProductCategoryId");
                });

            migrationBuilder.CreateTable(
                name: "MenuToIngredientOrRecipes",
                columns: table => new
                {
                    MenuToIngredientOrRecipeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuantityOffered = table.Column<double>(type: "float", nullable: false),
                    QtyMeasurement = table.Column<double>(type: "float", nullable: false),
                    QtyServed = table.Column<double>(type: "float", nullable: false),
                    Leftovers = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Temperature = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Attendance = table.Column<int>(type: "int", nullable: false),
                    IngredientId = table.Column<int>(type: "int", nullable: true),
                    RecipeId = table.Column<int>(type: "int", nullable: true),
                    MeasurementId = table.Column<int>(type: "int", nullable: false),
                    MenuId = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    Ordered = table.Column<bool>(type: "bit", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    VendorId = table.Column<int>(type: "int", nullable: false),
                    IngredientId = table.Column<int>(type: "int", nullable: false),
                    MeasurementId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailId);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Ingredients_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "IngredientId");
                    table.ForeignKey(
                        name: "FK_OrderDetails_Measurements_MeasurementId",
                        column: x => x.MeasurementId,
                        principalTable: "Measurements",
                        principalColumn: "MeasurementId");
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId");
                    table.ForeignKey(
                        name: "FK_OrderDetails_Vendors_VendorId",
                        column: x => x.VendorId,
                        principalTable: "Vendors",
                        principalColumn: "VendorId");
                });

            migrationBuilder.CreateTable(
                name: "RecipeToIngredients",
                columns: table => new
                {
                    RecipeToIngredientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    IngredientId = table.Column<int>(type: "int", nullable: false),
                    RecipeId = table.Column<int>(type: "int", nullable: false),
                    MeasurementId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeToIngredients", x => x.RecipeToIngredientId);
                    table.ForeignKey(
                        name: "FK_RecipeToIngredients_Ingredients_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "IngredientId");
                    table.ForeignKey(
                        name: "FK_RecipeToIngredients_Measurements_MeasurementId",
                        column: x => x.MeasurementId,
                        principalTable: "Measurements",
                        principalColumn: "MeasurementId");
                    table.ForeignKey(
                        name: "FK_RecipeToIngredients_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "RecipeId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_APBM",
                table: "Ingredients",
                column: "APBM");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_APSM",
                table: "Ingredients",
                column: "APSM");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_APUM",
                table: "Ingredients",
                column: "APUM");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_IngredientSubTypeId",
                table: "Ingredients",
                column: "IngredientSubTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_IngredientTypeId",
                table: "Ingredients",
                column: "IngredientTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_ProductCategoryId",
                table: "Ingredients",
                column: "ProductCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_IngredientTypes_MenuTypeId",
                table: "IngredientTypes",
                column: "MenuTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_IngredientTypes_MPDM",
                table: "IngredientTypes",
                column: "MPDM");

            migrationBuilder.CreateIndex(
                name: "IX_IngredientTypes_MPWM",
                table: "IngredientTypes",
                column: "MPWM");

            migrationBuilder.CreateIndex(
                name: "IX_IngredientTypes_MXDM",
                table: "IngredientTypes",
                column: "MXDM");

            migrationBuilder.CreateIndex(
                name: "IX_IngredientTypes_MXWM",
                table: "IngredientTypes",
                column: "MXWM");

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

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_IngredientId",
                table: "OrderDetails",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_MeasurementId",
                table: "OrderDetails",
                column: "MeasurementId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_VendorId",
                table: "OrderDetails",
                column: "VendorId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_ProductCategoryId",
                table: "Recipes",
                column: "ProductCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeToIngredients_IngredientId",
                table: "RecipeToIngredients",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeToIngredients_MeasurementId",
                table: "RecipeToIngredients",
                column: "MeasurementId");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeToIngredients_RecipeId",
                table: "RecipeToIngredients",
                column: "RecipeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "MenuToIngredientOrRecipes");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "RecipeToIngredients");

            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Vendors");

            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.DropTable(
                name: "IngredientTypes");

            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "Measurements");

            migrationBuilder.DropTable(
                name: "MenuTypes");
        }
    }
}
