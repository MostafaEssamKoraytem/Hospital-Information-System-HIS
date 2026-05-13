using HIS.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Domain.Aggregates.PatientAggregate.Entities.SubEntities
{
    public sealed class DocumentRecord : BaseEntity<Guid>
    {
        private const long MaxFileSizeInBytes = 10 * 1024 * 1024;

        private static readonly string[] AllowedMimeTypes =
        [
            "application/pdf",
            "image/jpeg",
            "image/png"
        ];

        public Guid PatientId { get; private set; }

        public string FileName { get; private set; }

        public string MimeType { get; private set; }

        public long FileSize { get; private set; }

        public string StoragePath { get; private set; }

        public DateTime UploadedAt { get; private set; }

        private DocumentRecord()
        {
        }

        public DocumentRecord(
            Guid patientId,
            string fileName,
            string mimeType,
            long fileSize,
            string storagePath)
        {
            if (string.IsNullOrWhiteSpace(fileName))
                throw new Exception("File name required.");

            if (!AllowedMimeTypes.Contains(mimeType))
                throw new Exception("Invalid file type.");

            if (fileSize > MaxFileSizeInBytes)
                throw new Exception("File size exceeds 10MB.");

            Id = Guid.NewGuid();

            PatientId = patientId;
            FileName = fileName;
            MimeType = mimeType;
            FileSize = fileSize;
            StoragePath = storagePath;
            UploadedAt = DateTime.UtcNow;
        }


        
    }
}
