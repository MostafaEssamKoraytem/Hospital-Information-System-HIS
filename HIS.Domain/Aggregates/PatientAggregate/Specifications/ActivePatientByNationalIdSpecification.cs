using HIS.Domain.Aggregates.PatientAggregate.Entities;
using HIS.Domain.Common;
using HIS.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Domain.Aggregates.PatientAggregate.Specifications
{
    public sealed class ActivePatientByNationalIdSpecification: Specification<Patient>
    {
        public ActivePatientByNationalIdSpecification(string nationalId)
        {
            Criteria = patient =>
                patient.NationalIdentity.Value == nationalId && patient.IsActive;
        }

        public bool IsSatisfiedBy(Patient entity)
        {
            throw new NotImplementedException();
        }
    }
}
