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
    public sealed class AuditLogConfiguration
    : IEntityTypeConfiguration<AuditLog>
    {
        public void Configure(EntityTypeBuilder<AuditLog> builder)
        {
            builder.ToTable("AuditLogs");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Action)
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(x => x.PerformedBy)
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(x => x.Notes)
                .HasMaxLength(2000);

            builder.Property(x => x.PerformedAt)
                .IsRequired();
        }
    }
}
