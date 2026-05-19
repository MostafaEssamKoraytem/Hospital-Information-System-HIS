using HIS.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Infrastructure.Services
{
    public class FileStorageService : IFileStorageService
    {
        public Task<string> UploadAsync(Stream fileStream, string fileName, CancellationToken cancellationToken)
        {
            // upload to S3 / Azure Blob / local storage
            return Task.FromResult($"https://storage/{fileName}");
        }

        public Task<string> UploadS3(){
                        // upload to S3
            return Task.FromResult("https://s3.amazonaws.com/bucket/file");
        }

        public Task<string> uploadAzureBlob()
        { 
            // upload to Azure Blob
            return Task.FromResult("https://azureblobstorage/container/file");
        }

    }
}
