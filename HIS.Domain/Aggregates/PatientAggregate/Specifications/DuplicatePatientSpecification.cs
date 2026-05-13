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
    public sealed class DuplicatePatientSpecification : Specification<Patient>
    {
        public DuplicatePatientSpecification(
            string nationalId,
            string phoneNumber)
        {
            Criteria = patient =>
                patient.NationalIdentity.Value == nationalId ||
                patient.PhoneNumber.Value == phoneNumber;
        }
    }
}
