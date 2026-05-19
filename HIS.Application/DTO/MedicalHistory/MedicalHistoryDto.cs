using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Application.DTO.MedicalHistory
{
    public sealed class MedicalHistoryDto
    {
        public Guid Id { get; init; }

        public string Diagnosis { get; init; } = default!;

        public string Treatment { get; init; } = default!;

        public string TreatingPhysician { get; init; } = default!;

        public DateOnly RecordDate { get; init; }
    }
}
