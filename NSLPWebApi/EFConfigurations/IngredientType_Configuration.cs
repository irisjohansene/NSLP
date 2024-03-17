using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using NSLPWebApi.Models;

namespace NSLPWebApi.EFConfigurations
{
    public class IngredientType_Configuration : IEntityTypeConfiguration<IngredientType>
    {
        public void Configure(EntityTypeBuilder<IngredientType> builder)
        {
            builder.HasKey(a => a.IngredientTypeId);
            builder.Property(mt => mt.IngredientTypeId)
            .ValueGeneratedOnAdd();

            builder.HasOne(i => i.MenuType)
               .WithMany()
               .HasForeignKey(i => i.MenuTypeId);

            // Configure the first Measurement relationship
            builder.HasOne(i => i.MPDMeasurement)
                   .WithMany()
                   .HasForeignKey(i => i.MPDM)
                   .IsRequired(true).OnDelete(DeleteBehavior.NoAction); // Depending on your requirements

            // Configure the second Measurement relationship
            builder.HasOne(i => i.MPWMeasurement)
                   .WithMany()
                   .HasForeignKey(i => i.MPWM)
                   .IsRequired(false).OnDelete(DeleteBehavior.NoAction); // Depending on your requirements

            // Configure the third Measurement relationship
            builder.HasOne(i => i.MXDMeasurement)
                   .WithMany()
                   .HasForeignKey(i => i.MXDM)
                   .IsRequired(false).OnDelete(DeleteBehavior.NoAction); // Depending on your requirements

            // Configure the third Measurement relationship
            builder.HasOne(i => i.MXWMeasurement)
                   .WithMany()
                   .HasForeignKey(i => i.MXWM)
                   .IsRequired(false).OnDelete(DeleteBehavior.NoAction); // Depending on your requirements
        }
    }
}
