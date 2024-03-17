using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using NSLPWebApi.Models;

namespace NSLPWebApi.EFConfigurations
{
    public class Recipe_Configuration : IEntityTypeConfiguration<Recipe>
    {
        public void Configure(EntityTypeBuilder<Recipe> builder)
        {
            builder.HasKey(a => a.RecipeId);
            builder.Property(mt => mt.RecipeId)
            .ValueGeneratedOnAdd();
            builder.Property(a => a.RecipeName).HasMaxLength(60);

            // Configure the first ProductCategory relationship
            builder.HasOne(i => i.ProductCategory)
                   .WithMany()
                   .HasForeignKey(i => i.ProductCategoryId)
                   .IsRequired(true).OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(x => x.RecipeToIngredients).WithOne(x => x.Recipe).HasForeignKey(x => x.RecipeId);
        }
    }
}
