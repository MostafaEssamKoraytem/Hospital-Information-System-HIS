using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Application.DTO.Documents
{
    public sealed class UploadMedicalDocumentRequest
    {
        public IFormFile File { get; init; } = default!;
    }
}
