using HIS.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Domain.Aggregates.PatientAggregate.Entities.SubEntities
{
    public sealed class InsurancePolicy : BaseEntity<Guid>
    {
        public Guid PatientId { get; private set; }

        public string ProviderName { get; private set; }

        public string PolicyNumber { get; private set; }

        public DateOnly ExpiryDate { get; private set; }

        public bool IsExpired => ExpiryDate < DateOnly.FromDateTime(DateTime.UtcNow);

        private InsurancePolicy()
        {
        }

        public InsurancePolicy(Guid patientId,string providerName,string policyNumber,DateOnly expiryDate)
        {
            if (string.IsNullOrWhiteSpace(providerName))
                throw new Exception("Provider name required.");

            if (string.IsNullOrWhiteSpace(policyNumber))
                throw new Exception("Policy number required.");

            if (IsExpired)
                throw new Exception("Insurance policy expired.");

            Id = Guid.NewGuid();

            PatientId = patientId;
            ProviderName = providerName;
            PolicyNumber = policyNumber;
            ExpiryDate = expiryDate;
        }

        public void Renew(DateOnly newExpiryDate)
        {
            if (newExpiryDate <= DateOnly.FromDateTime(DateTime.UtcNow))
                throw new Exception("Invalid expiry date.");

            ExpiryDate = newExpiryDate;
        }
    }
}
