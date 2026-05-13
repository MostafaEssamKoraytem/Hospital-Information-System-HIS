using HIS.Domain.Aggregates.PatientAggregate.Entities.SubEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Infrastructure.Presestance.Configurations
{
    public sealed class DocumentRecordConfiguration
     : IEntityTypeConfiguration<DocumentRecord>
    {
        public void Configure(EntityTypeBuilder<DocumentRecord> builder)
        {
            builder.ToTable("Documents");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.FileName)
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(x => x.MimeType)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.StoragePath)
                .HasMaxLength(1000)
                .IsRequired();

            builder.Property(x => x.FileSize)
                .IsRequired();

            builder.Property(x => x.UploadedAt)
                .IsRequired();
        }
    }
}
