using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Application.DTO.Insurrance
{
    public sealed class InsurancePolicyDto
    {
        public string ProviderName { get; init; } = default!;

        public string PolicyNumber { get; init; } = default!;

        public DateOnly ExpiryDate { get; init; }

        public bool IsExpired { get; init; }
    }
}
