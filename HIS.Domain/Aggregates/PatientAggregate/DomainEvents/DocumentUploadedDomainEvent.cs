using HIS.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Domain.Aggregates.PatientAggregate.DomainEvents
{
    public record DocumentUploadedDomainEvent( Guid PatientId, Guid DocumentId): DomainEvent;
}
