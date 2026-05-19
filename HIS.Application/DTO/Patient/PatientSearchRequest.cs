using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Application.DTO.Patient
{
    public sealed class PatientSearchRequest
    {
        public string? Name { get; init; }

        public string? NationalIdentity { get; init; }

        public string? MRN { get; init; }

        public string? PhoneNumber { get; init; }

        public int PageNumber { get; init; } = 1;

        public int PageSize { get; init; } = 10;
        
    }
}
