using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using NSLPWebApi.Models;

namespace NSLPWebApi.EFConfigurations
{
    public class MenuToIngredient_Configuration : IEntityTypeConfiguration<MenuToIngredient>
    {
        public void Configure(EntityTypeBuilder<MenuToIngredient> builder)
        {
            builder.HasKey(mti => mti.MenuToIngredientId);

            builder.HasOne(mti => mti.Menu)
               .WithOne(m => m.MenuToIngredient)
               .HasForeignKey<MenuToIngredient>(mti => mti.MenuId);

            builder.HasOne(mti => mti.Ingredient)
                   .WithMany()
                   .HasForeignKey(mti => mti.IngredientId);
        }
    }
}
