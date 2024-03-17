using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using NSLPWebApi.Models;

namespace NSLPWebApi.EFConfigurations
{
    public class Ingredient_Configuration : IEntityTypeConfiguration<Ingredient>
    {
        public void Configure(EntityTypeBuilder<Ingredient> builder)
        {
            builder.HasKey(a => a.IngredientId);
            builder.Property(mt => mt.IngredientId)
            .ValueGeneratedOnAdd();
            builder.Property(x => x.Name).HasMaxLength(75).IsRequired();

            // Configure the first ProductCategory relationship
            builder.HasOne(i => i.ProductCategory)
                   .WithMany()
                   .HasForeignKey(i => i.ProductCategoryId)
                   .IsRequired(true).OnDelete(DeleteBehavior.NoAction);

            // Configure the first IngredientType relationship
            builder.HasOne(i => i.IngredientType)
                   .WithMany()
                   .HasForeignKey(i => i.IngredientTypeId)
                   .IsRequired(true).OnDelete(DeleteBehavior.NoAction);

            // Configure the first Measurement relationship
            builder.HasOne(i => i.APSMeasurement)
                   .WithMany()
                   .HasForeignKey(i => i.APSM)
                   .IsRequired(true).OnDelete(DeleteBehavior.NoAction);

            // Configure the second Measurement relationship
            builder.HasOne(i => i.APUMeasurement)
                   .WithMany()
                   .HasForeignKey(i => i.APUM)
                   .IsRequired(true).OnDelete(DeleteBehavior.NoAction);

            // Configure the third Measurement relationship
            builder.HasOne(i => i.APBMeasurement)
                   .WithMany()
                   .HasForeignKey(i => i.APBM)
                   .IsRequired(true).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
