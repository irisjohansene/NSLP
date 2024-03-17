using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using NSLPWebApi.Models;

namespace NSLPWebApi.EFConfigurations
{
    public class OrderDetail_Configuration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.HasKey(mti => mti.OrderDetailId);
            builder.Property(mt => mt.OrderDetailId)
            .ValueGeneratedOnAdd();

            builder.HasOne(mti => mti.Vendor)
                   .WithMany()
                   .HasForeignKey(mti => mti.VendorId).OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(mti => mti.Ingredient)
                   .WithMany()
                   .HasForeignKey(mti => mti.IngredientId).OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(mti => mti.Measurement)
                   .WithMany()
                   .HasForeignKey(mti => mti.MeasurementId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
