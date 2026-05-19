using HIS.Application.DTO.Insurrance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Application.DTO.Patient
{
    public sealed class UpdatePatientRequest
    {
        public string FirstName { get; init; } = default!;

        public string LastName { get; init; } = default!;

        public string PhoneNumber { get; init; } = default!;

        public string Street { get; init; } = default!;

        public string City { get; init; } = default!;

        public string Country { get; init; } = default!;

        public string Gender { get; init; } = default!;

        // Optional Insurance

        public InsurancePolicyDto? InsurancePolicy { get; init; }
    }
}
