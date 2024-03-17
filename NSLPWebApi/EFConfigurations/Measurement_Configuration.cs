using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NSLPWebApi.Models;

namespace NSLPWebApi.EFConfigurations
{
    public class Measurement_Configuration : IEntityTypeConfiguration<Measurement>
    {
        public void Configure(EntityTypeBuilder<Measurement> builder)
        {
            builder.HasKey(mti => mti.MeasurementId);
            builder.Property(mt => mt.MeasurementId)
            .ValueGeneratedOnAdd();
        }
    }
}