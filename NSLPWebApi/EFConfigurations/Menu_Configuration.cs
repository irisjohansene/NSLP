using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using NSLPWebApi.Models;
using NuGet.Protocol;

namespace NSLPWebApi.EFConfigurations
{
    public class Menu_Configuration : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.HasKey(mti => mti.MenuId);
            builder.Property(mti => mti.MenuId).HasMaxLength(12).IsRequired();

            // Configure MenuDate property
            builder.Property(e => e.MenuDate)
                .IsRequired();

            // Configure MenuTypeId property
            builder.Property(e => e.MenuTypeId)
                .IsRequired();

            // Configure the first MenuType relationship
            builder.HasOne(i => i.MenuType)
                   .WithMany()
                   .HasForeignKey(i => i.MenuTypeId)
                   .IsRequired(true).OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(x => x.MenuToIngredientOrRecipes).WithOne(x => x.Menu).HasForeignKey(x => x.MenuId);
        }
    }
}
