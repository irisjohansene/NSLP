using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NSLPWebApi.Models;

namespace NSLPWebApi.EFConfigurations
{
    public class Document_Configuration : IEntityTypeConfiguration<Document>
    {
        public void Configure(EntityTypeBuilder<Document> builder)
        {
            builder.HasKey(mti => mti.DocumentId);
            builder.Property(mt => mt.DocumentId)
            .ValueGeneratedOnAdd();
        }
    }
}