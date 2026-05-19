using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Application.DTO
{
    public class PatientDto
    {
        public string FullName { get; set; }
        public string NationalIdentity { get; set; }
        public string PhoneNumber { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public int Gender { get; set; } = 0;
    }
}
