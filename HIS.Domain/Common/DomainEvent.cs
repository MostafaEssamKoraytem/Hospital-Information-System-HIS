using HIS.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Domain.Common
{
    public abstract record DomainEvent : IDomainEvent
    {
        public DateTime OccurredOnUtc { get; init; }
            = DateTime.UtcNow;
    }
}
