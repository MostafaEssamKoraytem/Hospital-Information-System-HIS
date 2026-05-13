using HIS.Domain.Aggregates.PatientAggregate.Entities.SubEntities;
using HIS.Domain.Common;
using HIS.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Domain.Aggregates.PatientAggregate.Specifications
{
    public sealed class InsuranceExpirySpecification : Specification<InsurancePolicy>
    {
        public InsuranceExpirySpecification()
        {
            Criteria = insurance =>
                insurance.IsExpired;
        }
    }
}