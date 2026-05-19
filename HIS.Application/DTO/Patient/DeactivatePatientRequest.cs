using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Application.DTO.Patient
{
    public sealed class DeactivatePatientRequest
    {
        public string Reason { get; init; } = default!;
    }
}
