using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Domain.Interfaces.Services
{
    public interface IFileStorageService
    {
        Task<string> UploadAsync(Stream fileStream, string fileName, CancellationToken cancellationToken);
    }
}
