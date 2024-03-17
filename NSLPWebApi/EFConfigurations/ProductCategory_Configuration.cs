using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using NSLPWebApi.Models;

namespace NSLPWebApi.EFConfigurations
{
    public class ProductCategory_Configuration : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.HasKey(mti => mti.ProductCategoryId);
            builder.Property(mt => mt.ProductCategoryId)
            .ValueGeneratedOnAdd();
        }
    }
}
