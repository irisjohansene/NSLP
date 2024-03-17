using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using NSLPWebApi.Models;

namespace NSLPWebApi.EFConfigurations
{
    public class Parameter_Configuration : IEntityTypeConfiguration<Parameter>
    {
        public void Configure(EntityTypeBuilder<Parameter> builder)
        {
            builder.HasKey(x => x.ParameterType);
            builder.Property(x => x.ParameterType).HasMaxLength(25).IsRequired();
            builder.Property(x => x.ParameterValue).HasColumnType("Int").IsRequired();
            builder.Property(x => x.ParameterString).HasMaxLength(50).IsRequired();
            builder.Property(x => x.ParameterSite).HasMaxLength(1).IsRequired();
        }

    }
}
