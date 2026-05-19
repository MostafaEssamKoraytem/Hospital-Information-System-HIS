using HIS.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Infrastructure.Services
{
    public class AntivirusScanner : IAntivirusScanner
    {
        public Task ScanAsync(Stream fileStream, CancellationToken cancellationToken)
        {
            // integrate with ClamAV / cloud scanner
            return Task.CompletedTask;
        }
    }
}
