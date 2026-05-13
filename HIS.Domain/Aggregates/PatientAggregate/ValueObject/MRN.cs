using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObj = HIS.Domain.Common.ValueObject;

namespace HIS.Domain.Aggregates.PatientAggregate.ValueObject
{
    public class MRN : ValueObj
    {
        public string Value { get; private set; }

        private MRN(string value)
        {
            Value = value;
        }

        public static MRN Generate()
        {
            return new MRN($"MRN-{DateTime.UtcNow:yyyyMMdd}-{Random.Shared.Next(1000, 9999)}");
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
