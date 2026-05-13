using HIS.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Domain.Aggregates.PatientAggregate.Entities.SubEntities
{
    public sealed class AuditLog : BaseEntity<Guid>
    {
        public Guid PatientId { get; private set; }

        public string Action { get; private set; }

        public string PerformedBy { get; private set; }

        public DateTime PerformedAt { get; private set; }

        public string? Notes { get; private set; }

        private AuditLog()
        {
        }

        public AuditLog(
            Guid patientId,
            string action,
            string performedBy,
            string? notes = null)
        {
            if (string.IsNullOrWhiteSpace(action))
                throw new Exception("Action required.");

            if (string.IsNullOrWhiteSpace(performedBy))
                throw new Exception("PerformedBy required.");

            Id = Guid.NewGuid();

            PatientId = patientId;
            Action = action;
            PerformedBy = performedBy;
            Notes = notes;
            PerformedAt = DateTime.UtcNow;
        }
    }
}
