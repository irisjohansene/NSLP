using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using NSLPWebApi.Models;

namespace NSLPWebApi.EFConfigurations
{
    public class MenuType_Configuration : IEntityTypeConfiguration<MenuType>
    {
        public void Configure(EntityTypeBuilder<MenuType> builder)
        {
            builder.HasKey(mti => mti.MenuTypeId);
            builder.Property(mt => mt.MenuTypeId)
            .ValueGeneratedOnAdd();
        }
    }
}
