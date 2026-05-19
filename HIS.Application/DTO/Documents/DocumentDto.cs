using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Application.DTO.Documents
{
    public sealed class DocumentDto
    {
        public Guid Id { get; init; }

        public string FileName { get; init; } = default!;

        public string MimeType { get; init; } = default!;

        public long FileSize { get; init; }

        public DateTime UploadedAt { get; init; }

        public string DownloadUrl { get; init; } = default!;
    }
}
