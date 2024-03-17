using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NSLPWebApi.Models;

namespace NSLPWebApi.EFConfigurations
{
    public class Order_Configuration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(mti => mti.OrderId);
            builder.Property(mt => mt.OrderId)
            .ValueGeneratedOnAdd();

            builder.HasMany(x => x.OrderDetails).WithOne(x => x.Order).HasForeignKey(x => x.OrderId);
        }
    }
}