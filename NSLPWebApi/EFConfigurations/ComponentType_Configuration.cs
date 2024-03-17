using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using NSLPWebApi.Models;

namespace NSLPWebApi.EFConfigurations
{
    public class ComponentType_Configuration : IEntityTypeConfiguration<ComponentType>
    {
        public void Configure(EntityTypeBuilder<ComponentType> builder)
        {
            builder.HasKey(a => a.ComponentTypeId);
            builder.Property(a => a.Name).HasMaxLength(60).IsRequired(false);
            builder.HasMany(x => x.SubTypes).WithOne(x => x.ComponentType).HasForeignKey(x => x.ComponentTypeId);
        }
    }
}
