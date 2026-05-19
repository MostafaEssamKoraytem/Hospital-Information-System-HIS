using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Domain.Interfaces.Services
{
    public interface IAntivirusScanner
    {
        Task ScanAsync(Stream fileStream, CancellationToken cancellationToken);
    }
}
