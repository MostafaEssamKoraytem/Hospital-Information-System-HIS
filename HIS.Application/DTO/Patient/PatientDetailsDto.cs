using HIS.Application.DTO.Documents;
using HIS.Application.DTO.Insurrance;
using HIS.Application.DTO.MedicalHistory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Application.DTO.Patient
{
    public sealed class PatientDetailsDto
    {
        public Guid Id { get; init; }

        public string MRN { get; init; } = default!;

        public string FullName { get; init; } = default!;

        public string NationalIdentity { get; init; } = default!;

        public string IdentityType { get; init; } = default!;

        public string PhoneNumber { get; init; } = default!;

        public string Address { get; init; } = default!;

        public DateOnly DateOfBirth { get; init; }

        public int Age { get; init; }

        public string Gender { get; init; } = default!;

        public string Status { get; init; } = default!;

        public InsurancePolicyDto? InsurancePolicy { get; init; }

        public IReadOnlyCollection<DocumentDto> Documents
        { get; init; } = [];

        public IReadOnlyCollection<MedicalHistoryDto> MedicalHistory
        { get; init; } = [];
    }
}
