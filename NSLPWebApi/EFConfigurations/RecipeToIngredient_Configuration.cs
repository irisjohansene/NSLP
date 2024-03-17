using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using NSLPWebApi.Models;

namespace NSLPWebApi.EFConfigurations
{
    public class RecipeToIngredient_Configuration : IEntityTypeConfiguration<RecipeToIngredient>
    {
        public void Configure(EntityTypeBuilder<RecipeToIngredient> builder)
        {
            builder.HasKey(mti => mti.RecipeToIngredientId);
            builder.Property(mt => mt.RecipeToIngredientId)
            .ValueGeneratedOnAdd();
            builder.HasOne(mti => mti.Ingredient).WithMany().HasForeignKey(mti => mti.IngredientId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(mti => mti.Measurement).WithMany().HasForeignKey(mti => mti.MeasurementId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
