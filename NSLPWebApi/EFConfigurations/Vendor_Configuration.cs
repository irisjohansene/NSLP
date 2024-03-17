using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NSLPWebApi.Models;

namespace NSLPWebApi.EFConfigurations
{
    public class Vendor_Configuration : IEntityTypeConfiguration<Vendor>
    {
        public void Configure(EntityTypeBuilder<Vendor> builder)
        {
            builder.HasKey(mti => mti.VendorId);
            builder.Property(mt => mt.VendorId)
            .ValueGeneratedOnAdd();
        }
    }
}