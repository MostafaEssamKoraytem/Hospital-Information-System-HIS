using HIS.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Domain.Aggregates.PatientAggregate.Entities.SubEntities
{
    public sealed class MedicalRecord : BaseEntity<Guid>
    {
        public Guid PatientId { get; private set; }

        public string Diagnosis { get; private set; }

        public string Treatment { get; private set; }

        public string TreatingPhysician { get; private set; }

        public DateOnly RecordDate { get; private set; }

        private MedicalRecord()
        {
        }

        public MedicalRecord(
            Guid patientId,
            string diagnosis,
            string treatment,
            string treatingPhysician,
            DateOnly recordDate)
        {
            if (string.IsNullOrWhiteSpace(diagnosis))
                throw new Exception("Diagnosis is required.");

            if (string.IsNullOrWhiteSpace(treatingPhysician))
                throw new Exception("Treating physician is required.");

            if (recordDate > DateOnly.FromDateTime(DateTime.UtcNow))
                throw new Exception("Record date cannot be future.");

            Id = Guid.NewGuid();

            PatientId = patientId;
            Diagnosis = diagnosis;
            Treatment = treatment;
            TreatingPhysician = treatingPhysician;
            RecordDate = recordDate;
        }
    }
}
