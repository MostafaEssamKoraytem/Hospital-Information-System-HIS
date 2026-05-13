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
    public class CanDeactivatePatientSpecification : Specification<Patient>
    {
        public CanDeactivatePatientSpecification() { }
        public bool IsSatisfiedBy(Patient patient)
        {
           // return patient.appointments.count > 0;
           return true; 
        }
    }
}
