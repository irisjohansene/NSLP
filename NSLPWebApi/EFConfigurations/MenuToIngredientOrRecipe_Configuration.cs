using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using NSLPWebApi.Models;

namespace NSLPWebApi.EFConfigurations
{
    public class MenuToIngredientOrRecipe_Configuration : IEntityTypeConfiguration<MenuToIngredientOrRecipe>
    {
        public void Configure(EntityTypeBuilder<MenuToIngredientOrRecipe> builder)
        {
            builder.HasKey(mti => mti.MenuToIngredientOrRecipeId);
            builder.Property(mt => mt.MenuToIngredientOrRecipeId)
            .ValueGeneratedOnAdd();

            builder.HasOne(mti => mti.Ingredient)
                   .WithMany()
                   .HasForeignKey(mti => mti.IngredientId)
                   .IsRequired(false);

            builder.HasOne(mti => mti.Recipe)
                   .WithMany()
                   .HasForeignKey(mti => mti.RecipeId)
                   .IsRequired(false);

            builder.HasOne(mti => mti.Measurement)
                   .WithMany()
                   .HasForeignKey(mti => mti.MeasurementId)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }

}
