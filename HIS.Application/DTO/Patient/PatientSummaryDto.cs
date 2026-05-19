using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Application.DTO.Patient
{
    public sealed class PatientSummaryDto
    {
        public Guid Id { get; init; }

        public string MRN { get; init; } = default!;

        public string FullName { get; init; } = default!;

        public string PhoneNumber { get; init; } = default!;

        public string Gender { get; init; } = default!;

        public string Status { get; init; } = default!;
    }
}
