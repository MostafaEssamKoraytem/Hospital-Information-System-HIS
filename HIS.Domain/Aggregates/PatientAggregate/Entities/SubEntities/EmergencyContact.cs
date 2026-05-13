using HIS.Domain.Aggregates.PatientAggregate.ValueObject;
using HIS.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Domain.Aggregates.PatientAggregate.Entities.SubEntities
{
    public sealed class EmergencyContact : BaseEntity<Guid>
    {
        public Guid PatientId { get; private set; }

        public string FullName { get; private set; }

        public string Relationship { get; private set; }

        public PhoneNumber PhoneNumber { get; private set; }

        private EmergencyContact()
        {
        }

        public EmergencyContact(
            Guid patientId,
            string fullName,
            string relationship,
            PhoneNumber phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(fullName))
                throw new Exception("Contact name required.");

            if (string.IsNullOrWhiteSpace(relationship))
                throw new Exception("Relationship required.");

            Id = Guid.NewGuid();

            PatientId = patientId;
            FullName = fullName;
            Relationship = relationship;
            PhoneNumber = phoneNumber;
        }

        public void UpdatePhoneNumber(PhoneNumber phoneNumber)
        {
            PhoneNumber = phoneNumber;
        }
    }
}
