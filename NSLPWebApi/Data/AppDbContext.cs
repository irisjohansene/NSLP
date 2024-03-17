using Microsoft.EntityFrameworkCore;
using NSLPWebApi.EFConfigurations;
using NSLPWebApi.Models;
using System.Drawing;
using System.Reflection.Metadata;

namespace NSLPWebApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Models.Document> Documents { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<MenuType> MenuTypes { get; set; }
        public DbSet<Measurement> Measurements { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<IngredientType> IngredientTypes { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<RecipeToIngredient> RecipeToIngredients { get; set; }
        public DbSet<MenuToIngredientOrRecipe> MenuToIngredientOrRecipes { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        //
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Models.Document>(new Document_Configuration());
            modelBuilder.ApplyConfiguration<Ingredient>(new Ingredient_Configuration());
            modelBuilder.ApplyConfiguration<IngredientType>(new IngredientType_Configuration());
            modelBuilder.ApplyConfiguration<Measurement>(new Measurement_Configuration());
            modelBuilder.ApplyConfiguration<Menu>(new Menu_Configuration());
            modelBuilder.ApplyConfiguration<MenuToIngredientOrRecipe>(new MenuToIngredientOrRecipe_Configuration());
            modelBuilder.ApplyConfiguration<MenuType>(new MenuType_Configuration());
            modelBuilder.ApplyConfiguration<OrderDetail>(new OrderDetail_Configuration());
            modelBuilder.ApplyConfiguration<Order>(new Order_Configuration());
            modelBuilder.ApplyConfiguration<Recipe>(new Recipe_Configuration());
            modelBuilder.ApplyConfiguration<RecipeToIngredient>(new RecipeToIngredient_Configuration());
            modelBuilder.ApplyConfiguration<Setting>(new Setting_Configuration());
            modelBuilder.ApplyConfiguration<Vendor>(new Vendor_Configuration());
            modelBuilder.ApplyConfiguration<ProductCategory>(new ProductCategory_Configuration());
        }
    }
}
